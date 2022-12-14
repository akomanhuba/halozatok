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
    public partial class Form2 : Form
    {
        Models.TextbookSupportContext context = new Models.TextbookSupportContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = context.Students.ToList();

        }
    }
}
