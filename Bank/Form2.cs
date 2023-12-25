using System;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form2 : Form
    {
        public int day;
        public int mounth;
        int sum;
        float[] save = new float[6];

        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "1000";
            textBox2.Text = "1";
            textBox3.Text = "0";
            day = 30;

            Timer tmr = new Timer();
            tmr.Interval = 100;
            tmr.Tick += Tick;
            tmr.Start();
        }

        private void Tick(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(textBox1.Text);
            int buff = Convert.ToInt32(textBox3.Text);
            float time = day;

            float[] percentages = { 0.08f, 5f, 0.06f };
            Label[] finalCashLabels = { finalCashText, finalCashText2, finalCashText3 };
            int[] indexes = { 0, 1, 2 };

            for (int i = 0; i < 3; i++)
            {
                float procent = percentages[i];

                float f;
                if (i == 0)
                {
                    f = ((sum * (1 + ((procent * time) / (365)))) - sum);
                }
                else if (i == 1)
                {
                    float firstCash = sum * (procent / 100) / 365 * time;
                    float nextCash = (sum + buff + firstCash) * (procent / 100) / 365 * (time);
                    f = nextCash;
                }
                else
                {
                    f = (((sum + buff) * (1 + ((procent * time) / (365)))) - (sum + buff));
                }

                if (f < 10)
                {
                    finalCashLabels[i].Text = f.ToString("0") + " Руб.";
                }
                else
                {
                    finalCashLabels[i].Text = f.ToString("0,0") + " Руб.";
                }

                save[indexes[i]] = f;

                if (i == 1)
                {
                    save[i + 3] = (sum + f + buff * (time / 30));
                }
                else
                {
                    save[i + 3] = (sum + f);
                }
            }
        }

        private void sumText1(object sender, EventArgs e)
        {

        }
        public void Day(int i)
        {

            int[] monthsToDays = { 30, 60, 90, 180, 270, 365, 730, 1095, 1460, 1825 };
            string[] monthsNames = { "1 месяц", "2 месяца", "3 месяца", "6 месяцев", "9 месяцев", "1 год", "2 года", "3 года", "4 года", "5 лет" };

            if (i >= 1 && i <= 10)
            {
                textBox2.Text = monthsNames[i - 1];
                day = monthsToDays[i - 1];
                mounth = i < 6 ? i : (i - 5) * 12;
            }
        }

        public void Cash(int i)
        {
            string[] amounts = { "0", "500000", "1000000", "2500000", "5000000" };

            if (i >= 1 && i <= 5)
            {
                textBox3.Text = amounts[i - 1];
            }
        }

        public void Sum(int i)
        {
            string[] sums = { "1000", "500000", "1000000", "5000000", "10000000" };

            if (i >= 1 && i <= 5)
            {
                textBox1.Text = sums[i - 1];
            }
        }

        private void sumTrackBar1_Scroll(object sender, EventArgs e)
        {
            Sum(sumTrackBar1.Value);
        }
        private void dayTrackBar1_Scroll(object sender, EventArgs e)
        {
            Day(dayTrackBar1.Value);
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Cash(trackBar1.Value);
        }

        private void cashScrollBar_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int sum = Math.Max(Convert.ToInt32(textBox1.Text), 2000);

            if (sum <= 249_999)
            {
                sumTrackBar1.Value = 1;
            }
            else if (sum <= 749_999)
            {
                sumTrackBar1.Value = 2;
            }
            else if (sum <= 2_499_999)
            {
                sumTrackBar1.Value = 3;
            }
            else if (sum <= 7_499_999)
            {
                sumTrackBar1.Value = 4;
            }
            else if (sum <= 10_000_000)
            {
                sumTrackBar1.Value = 5;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int sum = Math.Max(Convert.ToInt32(textBox3.Text), 0);

            if (sum <= 249_999)
            {
                trackBar1.Value = 1;
            }
            else if (sum <= 749_999)
            {
                trackBar1.Value = 2;
            }
            else if (sum <= 1_249_999)
            {
                trackBar1.Value = 3;
            }
            else if (sum <= 3_749_999)
            {
                trackBar1.Value = 4;
            }
            else if ( sum <= 4_999_999)
            {
                trackBar1.Value = 5;
            }
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
            var form = new Form1();
            form.Closed += (s, args) => this.Close();
            form.Show();
            this.Hide();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            mounth = day / 30;
            Form3 form = new Form3(save[0], save[1], save[2], save[3], save[4], save[5], mounth, sum);
            form.Show();
        }

        private void mainPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}