using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Diagnostics;

namespace Bank
{
    public partial class Form3 : Form
    {
        int sum;
        int mounth;

        public Form3(float a, float b, float c, float a1, float b1, float c1, int _mounth, int _sum)
        {
            InitializeComponent();
            if(a < 10)
            cash1.Text = a.ToString("0") + " Руб.";
            else
                cash1.Text = a.ToString("0,0") + " Руб.";

            if (b < 10)
                cash2.Text = b.ToString("0") + " Руб.";
            else
                cash2.Text = b.ToString("0,0") + " Руб.";

            if (c < 10)
                cash3.Text = c.ToString("0") + " Руб.";
            else
                cash3.Text = c.ToString("0,0") + " Руб.";

            finalCash1.Text = a1.ToString("0,0") + " Руб.";
            finalCash2.Text = b1.ToString("0,0") + " Руб.";
            finalCash3.Text = c1.ToString("0,0") + " Руб.";

            sum = _sum;
            mounth = _mounth;
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void backButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            
            string path = AppContext.BaseDirectory + @"\jpg.jpg";
            string path2 = AppContext.BaseDirectory + @"\pdf.pdf";

            Bitmap printscreen = GetControlScreenshot(panel1);
            printscreen.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);

            Document document = new Document();
            using (var stream = new FileStream(path2, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (var imageStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    var image = iTextSharp.text.Image.GetInstance(imageStream);

                    PdfWriter writer = PdfWriter.GetInstance(document, stream);

                    document.SetPageSize(new iTextSharp.text.Rectangle(panelMain.Size.Width + document.LeftMargin + document.RightMargin, panelMain.Size.Height + document.TopMargin + document.BottomMargin));
                    document.Open();
                    document.Add(image);
                    document.Close();
                }
            }
            Process.Start(path2);
        }

        
        public Bitmap GetControlScreenshot(Control control)
        {
            Size szCurrent = control.Size;
            control.AutoSize = true;

            Bitmap bmp = new Bitmap(control.Width, control.Height);

            control.DrawToBitmap(bmp, control.ClientRectangle);

            control.AutoSize = false;
            control.Size = szCurrent;

            return bmp;
        }

        private void contrbutionButton1_Click(object sender, EventArgs e)
        {
            string procent = "8%";
            Form4 form = new Form4(sum, mounth, procent);
            form.Show();
        }

        private void contrbutionButton2_Click(object sender, EventArgs e)
        {
            string procent = "5%";
            Form4 form = new Form4(sum, mounth, procent);
            form.Show();
        }

        private void contrbutionButton3_Click(object sender, EventArgs e)
        {
            string procent = "6%";
            Form4 form = new Form4(sum, mounth, procent);
            form.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.Closed += (s, args) => this.Close();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}