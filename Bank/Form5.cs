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
    public partial class Form5 : Form
    {
        Base sql = new Base();

        public Form5()
        {
            InitializeComponent();
            sql.InitializeDatabase();
            errorBox.Text = "";
        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void oBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void accCreate_Click(object sender, EventArgs e)
        {
            string cheak = "";

            if (loginBox.Text != "" && passwordBox.Text != "" && fBox.Text != "" && iBox.Text != "")
            {
                sql.AddNewUser(loginBox.Text, passwordBox.Text, fBox.Text +"_"+ iBox.Text + "_");

                cheak = sql.ErrorInfo();

                if (cheak == "")
                {
                    this.Close();
                }
                else
                {
                    errorBox.Text = cheak;
                }
            }
            else
            {
                errorBox.Text = "Ошибка при заполнении данных";
            }
        }
    }
}
