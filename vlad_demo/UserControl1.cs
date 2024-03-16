using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace vlad_demo
{
    public partial class UserControl1 : UserControl
    {
        public product product;
        public UserControl1()
        {
            InitializeComponent();
        }
        private void UserControl1_Click(object sender, EventArgs e)
        {
            UserControl1 a = (UserControl1)sender;
            Form2 f2 = new Form2 (a, (Form1)a.Parent.Parent);
            f2.ShowDialog();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
