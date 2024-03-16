using vlad_demo;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace vlad_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int endpage = 1;
        int currentMinPage = 0;
        int currentPage = 1;
        string sqlCommand = "SELECT * FROM Product ORDER BY id ASC";

        private void Form1_Load(object sender, EventArgs e)
        {
            pagesToFLP();
            productToFLP();
            comboBox1.Items.AddRange(new string[] { "“ËÔ 1", "“ËÔ 2" });
            comboBox2.Items.AddRange(new string[] { "ASC", "DESC" });
        }
        public void setEndPage()
        {
            List<product> list = coon.getSelectedProduct(sqlCommand);
            if (list.Count % 20 != 0)
            {
                endpage = list.Count / 20 + 1;
            }
            else
            {
                endpage = list.Count / 20;
            }
        }

        public void labelChangePage_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Text == "<")
            {
                if (currentMinPage != 0)
                {
                    currentMinPage--;
                    pagesToFLP();
                }
            }
            else if (label.Text == ">")
            {
                if (currentMinPage + 4 < endpage)
                {
                    currentMinPage++;
                    pagesToFLP();
                }
            }
            else
            {
                currentPage = Convert.ToInt32(label.Text);
                productToFLP();
            }
        }
        public void pagesToFLP()
        {
            flowLayoutPanel2.Controls.Clear();
            Label label = new Label();
            label.Size = new Size(15, 15);
            label.Text = "<";
            label.Click += labelChangePage_Click;
            flowLayoutPanel2.Controls.Add(label);
            for (int i = 0 + currentMinPage; i < 4 + currentMinPage; i++)
            {
                label = new Label();
                label.Size = new Size(25, 25);
                label.Text = $"{i + 1}";
                label.Click += labelChangePage_Click;
                flowLayoutPanel2.Controls.Add(label);
            }
            label = new Label();
            label.Size = new Size(15, 15);
            label.Text = ">";
            label.Click += labelChangePage_Click;
            flowLayoutPanel2.Controls.Add(label);
        }

        public void productToFLP()
        {
            flowLayoutPanelProducts.Controls.Clear();
            int iEnd = 20;
            setEndPage();
            List<product> list = coon.getSelectedProduct(sqlCommand);
            if (currentPage == endpage)
            {
                if (list.Count % 20 != 0)
                {
                    iEnd = list.Count % 20;
                }
            }
            if (currentPage > endpage)
            {
                iEnd = 0;
            }

            for (int i = 0 + (20 * (currentPage - 1)); i < iEnd + (20 * (currentPage - 1)); i++)
            {
                UserControl1 uct = new UserControl1();
                uct.Size = new Size(801, 133);
                uct.product = list[i];
                uct.labelProductArtc.Text = uct.product.articlenumber;
                uct.labelProductName.Text = uct.product.title;
                uct.labelProductType.Text = uct.product.producttypeid.ToString();
                uct.labelProductCost.Text = uct.product.mincostforagent.ToString();

                if (uct.product.image.StartsWith("\\"))
                {
                    uct.pictureOfProduct.ImageLocation = $"C:\\Users\\sla13\\source\\repos\\vlad_demo\\vlad_demo\\picture\\{uct.product.image}";
                }
                                                              
                else
                {
                    uct.pictureOfProduct.ImageLocation = $"C:\\Users\\sla13\\source\\repos\\vlad_demo\\vlad_demo\\picture\\paper_0.jpeg";
                }
                uct.pictureOfProduct.SizeMode = PictureBoxSizeMode.Zoom;
                flowLayoutPanelProducts.Controls.Add(uct);
            }
        }
        public void Search()
        {
            string main = "SELECT * FROM Product";
            bool where = false;
            bool and = false;
            string searchLetters = "";
            string filtrType = "";
            string sortType = "";
            string result = "";

            if (textBox1.Text.Trim(' ') != "")
            {
                searchLetters = $" title ILIKE '%{textBox1.Text}%'";
                where = true;
            }

            switch (comboBox1.SelectedIndex)
            {
                case -1:
                    filtrType = "";
                    break;
                case 0:
                    filtrType = " producttypeid = 1";
                    if (where)
                    {
                        and = true;
                    }
                    else
                    {
                        where = true;
                    }
                    break;
                case 1:
                    filtrType = " producttypeid = 2";
                    if (where)
                    {
                        and = true;
                    }
                    else
                    {
                        where = true;
                    }
                    break;
            }

            switch (comboBox2.SelectedIndex)
            {
                case -1:
                    sortType = "";
                    break;
                case 0:
                    sortType = " ORDER BY ID ASC";
                    break;
                case 1:
                    sortType = " ORDER BY ID DESC";
                    break;
            }

            if (where && and)
            {
                result = $"{main} WHERE {searchLetters} AND {filtrType} {sortType}";
            }
            else if (where)
            {
                if (searchLetters != "")
                {
                    result = $"{main} WHERE {searchLetters} {sortType}";
                }
                if (filtrType != "")
                {
                    result = $"{main} WHERE {filtrType} {sortType}";
                }
            }
            else
            {
                result = $"{main} {sortType}";
            }

            sqlCommand = result;
            productToFLP();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
    }
}
