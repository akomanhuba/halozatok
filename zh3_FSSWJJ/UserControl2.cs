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
    public partial class UserControl2 : UserControl
    {
        Models.TextbookSupportContext contex = new Models.TextbookSupportContext();
        public UserControl2()
        {
            InitializeComponent();

            listBox_stud.DisplayMember = "Neptun";
            studszur();


        }

        private void studszur()
        {
            listBox_stud.DataSource =
                (
                from i in contex.Students
                where i.Neptun.StartsWith(textBox_stud.Text)
                select i
                ).ToList();
        }

        private void listazas()
        {
            var id = ((Models.Student)listBox_stud.SelectedItem).StudentId;

            var adatok = from x in contex.Orders


                         where x.StudentFk == id
                         select new
                         {
                             x.TextbookFkNavigation.Title,
                             x.TextbookFkNavigation.Price,
                             x.TextbookFkNavigation.StockNumber
                         };
            dataGridView1.DataSource = adatok.ToList();
        }
        private void listBox_stud_SelectedIndexChanged(object sender, EventArgs e)
        {
            listazas();


        }

        private void textBox_stud_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox_stud, "");


        }

        private void textBox_stud_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_stud.Text.Length > 6)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox_stud, "Csak 6 betű alatt kereshet");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studszur();
        }
    }
}
