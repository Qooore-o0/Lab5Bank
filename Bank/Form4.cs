using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form4 : Form
    {
        Base _SQLBase = new Base();
        WordsGeneration _WordsGeneration = new WordsGeneration();
        public Form4(int _sum, int _date, string _procent)
        {
            InitializeComponent();
            sum = _sum;
            date = _date;
            procent = _procent;
        }

        string procent; int sum, cash, date;

        private void loginBox_TextChanged(object sender, EventArgs e)
        {
            if(loginBox.Text != null)
            {
                visOff1.Text = "";
            }
            else
            {

            }
        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordBox.Text != null)
            {
                visOff2.Text = "";
            }
        }

        private void visOff1_Click(object sender, EventArgs e)
        {

        }
        private void visOff2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void registration_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
        }

        private void autoButton_Click(object sender, EventArgs e)
        {
            _SQLBase.SearchProduct(loginBox.Text, passwordBox.Text);
            string login = _SQLBase.LoginReturn();
            string password = _SQLBase.PasswordReturn();
            string fio = _SQLBase.FIOReturn();

            if (login != "" && password != "")
            {
                _WordsGeneration.WordGeneration(fio, sum, cash, procent, date);
            }

            _SQLBase.DataClear();
        }
    }
}
