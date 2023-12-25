using System;
using System.Windows.Forms;
namespace Bank
{
    public partial class Form1 : Form
    {

        Base sql = new Base();

        public Form1()
        {
            InitializeComponent();
        }
        private void nextSlide1_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.Closed += (s, args) => this.Close();
            form.Show();
            this.Hide();
        }
        private void mainPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}