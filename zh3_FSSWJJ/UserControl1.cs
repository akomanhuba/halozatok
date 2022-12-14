using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zh3_FSSWJJ
{
    public partial class UserControl1 : UserControl
    {
        Models.TextbookSupportContext context = new Models.TextbookSupportContext();
        public UserControl1()
        {
            InitializeComponent();
            szuresdiak();
            szureskonyv();
            osszeszures();
            listBox__stud.DisplayMember = "Name";
            listBox__konyv.DisplayMember = "Title";
             listBox__rend.ValueMember = "OrderSK";
            listBox__rend.DisplayMember = "Title";



        }

        private void szuresdiak()
        {
            listBox__stud.DataSource =
                    (
                        from s in context.Students
                        where s.Name.Contains(textBox__stud.Text)
                        select s
                    ).ToList();
        }

        private void szureskonyv()
        {
            listBox__konyv.DataSource =
                    (
                        from t in context.Textbooks
                        where t.Title.Contains(textBox__konyv.Text)
                        select t
                    ).ToList();
        }

        private void textBox__stud_TextChanged(object sender, EventArgs e)
        {
            szuresdiak();
        }

        private void textBox__konyv_TextChanged(object sender, EventArgs e)
        {
            szureskonyv();
        }
        private void osszeszures()
        {
            Models.Student student = (Models.Student)listBox__stud.SelectedItem;
            var osszeszur = from x in context.Orders
                            where x.StudentFk == student.StudentId
                            select new
                            {
                                x.OrderSk,
                                x.StudentFk,
                                x.TextbookFkNavigation.Title,
                            };
            listBox__rend.DataSource = osszeszur.ToList();




        }

        private void listBox__stud_SelectedIndexChanged(object sender, EventArgs e)
        {
            osszeszures();
        }

        private void listBox__konyv_SelectedIndexChanged(object sender, EventArgs e)
        {
            osszeszures();
        }

        private void button_ad_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Biztosan hozzá akarod adni?", "Rendelés felvétele", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                Models.Student student = (Models.Student)listBox__stud.SelectedItem;


                Models.Textbook textbook = (Models.Textbook)listBox__konyv.SelectedItem;

                Models.Order hozzad = new Models.Order();
                hozzad.StudentFk = student.StudentId;
                hozzad.TextbookFk = textbook.TextbookId;
                context.Orders.Local.Add(hozzad);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                osszeszures();
            }
        }

        private void button2_vesz_Click(object sender, EventArgs e)
        {
            DialogResult ress = MessageBox.Show("Biztosan törölni szeretnél?", "Rendelés Törlése", MessageBoxButtons.YesNo);
            if (ress == System.Windows.Forms.DialogResult.Yes)
            {
                int elvesz = Convert.ToInt32(listBox__rend.SelectedValue);
                var sd = from x in context.Orders
                         where x.OrderSk == elvesz
                         select x;
                context.Orders.Remove(sd.FirstOrDefault());

                try
                {
                    context.SaveChanges();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                osszeszures();
            }
        }
    }
}
