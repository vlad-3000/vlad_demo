using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vlad_demo
{
    public partial class Form2 : Form
    {
        public UserControl1 UserControl1;
        public Form1 f1;

        public Form2(UserControl1 usc, Form1 f1)
        {
            InitializeComponent();
            this.UserControl1 = usc;
            this.f1 = f1;
            comboBox1.Items.AddRange(new string[] { "INSERT", "UPDATE", "DELETE" });
            AllBlock();
        }

        public void AllBlock()
        {
            textBox1.ReadOnly = true;
            textBox1.Enabled = false;

            textBox2.ReadOnly = true;
            textBox2.Enabled = false;

            textBox3.ReadOnly = true;
            textBox3.Enabled = false;

            textBox4.ReadOnly = true;
            textBox4.Enabled = false;

            textBox5.ReadOnly = true;
            textBox5.Enabled = false;

            textBox6.ReadOnly = true;
            textBox6.Enabled = false;

            textBox7.ReadOnly = true;
            textBox7.Enabled = false;

            textBox8.ReadOnly = true;
            textBox8.Enabled = false;

            textBox9.ReadOnly = true;
            textBox9.Enabled = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                AllBlock();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";

                textBox2.ReadOnly = false;
                textBox2.Enabled = true;

                textBox3.ReadOnly = false;
                textBox3.Enabled = true;

                textBox4.ReadOnly = false;
                textBox4.Enabled = true;

                textBox5.ReadOnly = false;
                textBox5.Enabled = true;

                textBox6.ReadOnly = false;
                textBox6.Enabled = true;

                textBox7.ReadOnly = false;
                textBox7.Enabled = true;

                textBox8.ReadOnly = false;
                textBox8.Enabled = true;

                textBox9.ReadOnly = false;
                textBox9.Enabled = true;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                AllBlock();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";

                textBox1.Text = UserControl1.product.id.ToString();
                textBox2.Text = UserControl1.product.title;
                textBox3.Text = UserControl1.product.producttypeid.ToString();
                textBox4.Text = UserControl1.product.articlenumber;
                textBox5.Text = UserControl1.product.description;
                textBox6.Text = UserControl1.product.image;
                textBox7.Text = UserControl1.product.productionpersoncount.ToString();
                textBox8.Text = UserControl1.product.productionworkshopnumber.ToString();
                textBox9.Text = UserControl1.product.mincostforagent.ToString();

                textBox1.Enabled = true;

                textBox2.ReadOnly = false;
                textBox2.Enabled = true;

                textBox3.ReadOnly = false;
                textBox3.Enabled = true;

                textBox4.ReadOnly = false;
                textBox4.Enabled = true;

                textBox5.ReadOnly = false;
                textBox5.Enabled = true;

                textBox6.ReadOnly = false;
                textBox6.Enabled = true;

                textBox7.ReadOnly = false;
                textBox7.Enabled = true;

                textBox8.ReadOnly = false;
                textBox8.Enabled = true;

                textBox9.ReadOnly = false;
                textBox9.Enabled = true;

            }
            if (comboBox1.SelectedIndex == 2)
            {
                AllBlock();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";

                textBox1.Text = UserControl1.product.id.ToString();

                textBox1.ReadOnly = false;
                textBox1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (textBox2.Text.Trim(' ') != "" && textBox2.Text.Trim(' ') != "" && textBox3.Text.Trim(' ') != "" && textBox4.Text.Trim(' ') != "" && textBox6.Text.Trim(' ') != "" && textBox7.Text.Trim(' ') != "" && textBox8.Text.Trim(' ') != "")
                {
                    coon.sqlToDbWithChanges($"INSERT INTO public.product(title, producttypeid, articlenumber, description, image, productionpersoncount, productionworkshopnumber, mincostforagent) VALUES ('{textBox2.Text}', {textBox3.Text}, '{textBox4.Text}', '{textBox5.Text}', '{textBox6.Text}', {textBox7.Text}, {textBox8.Text}, {textBox9.Text});");
                    this.Close();
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (textBox1.Text.Trim(' ') != "" && textBox2.Text.Trim(' ') != "" && textBox2.Text.Trim(' ') != "" && textBox3.Text.Trim(' ') != "" && textBox4.Text.Trim(' ') != "" && textBox6.Text.Trim(' ') != "" && textBox7.Text.Trim(' ') != "" && textBox8.Text.Trim(' ') != "")
                {
                    coon.sqlToDbWithChanges($"UPDATE public.product SET title='{textBox2.Text}', producttypeid={textBox3.Text}, articlenumber='{textBox4.Text}', description='{textBox5.Text}', image='{textBox6.Text}', productionpersoncount={textBox7.Text}, productionworkshopnumber={textBox8.Text}, mincostforagent={textBox9.Text} WHERE id = {textBox1.Text};");
                    this.Close();
                }

            }
            if (comboBox1.SelectedIndex == 2)
            {
                if (textBox1.Text.Trim(' ') != "")
                {
                    coon.sqlToDbWithChanges($"DELETE FROM public.product WHERE id = {textBox1.Text};");
                    this.Close();
                }
            }
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            f1.productToFLP();
        }

    }
}
