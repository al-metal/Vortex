using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Расчет_моющих_средств
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vortex vortex = new Vortex();
            vortex.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double res5 = 0;
            double res5s = 0;
            if (textBox27.Text != "" && textBox28.Text != "" && textBox30.Text != "" && textBox31.Text != "" && textBox34.Text != "" && textBox35.Text != "")
            {
                double priceKGVORTEX = Convert.ToDouble(textBox27.Text.Replace('.', ','));
                double plotnostVORTEX = Convert.ToDouble(textBox28.Text.Replace('.', ','));

                double koncentratVORTEX = Convert.ToDouble(textBox30.Text.Replace('.', ','));
                double obyemVORTEX = Convert.ToDouble(textBox31.Text.Replace('.', ','));

                double promyvSutkiVORTEX = Convert.ToDouble(textBox34.Text.Replace('.', ','));
                double dayVORTEX = Convert.ToDouble(textBox35.Text.Replace('.', ','));

                double res1 = priceKGVORTEX * plotnostVORTEX;
                double res2 = koncentratVORTEX * obyemVORTEX * res1 / 100;
                double res3 = koncentratVORTEX * obyemVORTEX / 100;
                double res4 = res3 * promyvSutkiVORTEX * dayVORTEX;
                res5 = res4 * res1;


                textBox29.Text = Math.Round(res1, 0).ToString();
                textBox32.Text = Math.Round(res2, 0).ToString();
                textBox33.Text = Math.Round(res3, 0).ToString();
                textBox36.Text = Math.Round(res4, 0).ToString();
                textBox37.Text = Math.Round(res5, 0).ToString();
            }



            if (textBox15.Text != "" && textBox16.Text != "" && textBox18.Text != "" && textBox19.Text != "" && textBox22.Text != "" && textBox23.Text != "")
            {
                double priceKG = Convert.ToDouble(textBox15.Text.Replace('.', ','));
                double plotnost = Convert.ToDouble(textBox16.Text.Replace('.', ','));

                double koncentrat = Convert.ToDouble(textBox18.Text.Replace('.', ','));
                double obyem = Convert.ToDouble(textBox19.Text.Replace('.', ','));

                double promyvSutki = Convert.ToDouble(textBox22.Text.Replace('.', ','));
                double day = Convert.ToDouble(textBox23.Text.Replace('.', ','));

                double res1s = priceKG * plotnost;
                double res2s = koncentrat * obyem * res1s / 100;
                double res3s = koncentrat * obyem / 100;
                double res4s = res3s * promyvSutki * day;
                res5s = res4s * res1s;


                textBox17.Text = Math.Round(res1s, 0).ToString();
                textBox20.Text = Math.Round(res2s, 0).ToString();
                textBox21.Text = Math.Round(res3s, 0).ToString();
                textBox24.Text = Math.Round(res4s, 0).ToString();
                textBox25.Text = Math.Round(res5s, 0).ToString();

            }
            if (textBox15.Text != "" && textBox16.Text != "" && textBox18.Text != "" && textBox19.Text != "" && textBox22.Text != "" && textBox23.Text != "" && textBox27.Text != "" && textBox28.Text != "" && textBox30.Text != "" && textBox31.Text != "" && textBox34.Text != "" && textBox35.Text != "")
            {
                label14.Text = Math.Round((res5s - res5), 2).ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                textBox28.Text = "1,252";
            else if (comboBox1.SelectedIndex == 1)
                textBox28.Text = "1,226";
            else if (comboBox1.SelectedIndex == 2)
                textBox28.Text = "1,230";
            else if (comboBox1.SelectedIndex == 3)
                textBox28.Text = "1,198";
            else if (comboBox1.SelectedIndex == 4)
                textBox28.Text = "1,22";
            else if (comboBox1.SelectedIndex == 5)
                textBox28.Text = "1,2";
            else if (comboBox1.SelectedIndex == 6)
                textBox28.Text = "1,28";
            else if (comboBox1.SelectedIndex == 7)
                textBox28.Text = "1,167";
            else if (comboBox1.SelectedIndex == 8)
                textBox28.Text = "1,457";
            else if (comboBox1.SelectedIndex == 9)
                textBox28.Text = "1,221";
            else if (comboBox1.SelectedIndex == 10)
                textBox28.Text = "1,157";
            else if (comboBox1.SelectedIndex == 11)
                textBox28.Text = "1,194";
            else if (comboBox1.SelectedIndex == 12)
                textBox28.Text = "1,170";
            else if (comboBox1.SelectedIndex == 13)
                textBox28.Text = "1,391";
            else if (comboBox1.SelectedIndex == 14)
                textBox28.Text = "1,173";
            else if (comboBox1.SelectedIndex == 15)
                textBox28.Text = "1,145";
            else if (comboBox1.SelectedIndex == 16)
                textBox28.Text = "1,122";//---------------------------------
            else if (comboBox1.SelectedIndex == 17)
                textBox28.Text = "1,104";
            else if (comboBox1.SelectedIndex == 18)
                textBox28.Text = "1,16";
            else if (comboBox1.SelectedIndex == 19)
                textBox28.Text = "1,025";
        }

        #region Обработка ввода данных с клавиатуры
        private void KeyPress(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (number == '.')
                number = ',';
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox35_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox34_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox31_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }
        #endregion
    }
}
