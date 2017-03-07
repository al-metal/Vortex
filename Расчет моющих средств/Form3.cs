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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vortex vortex = new Vortex();
            vortex.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 4)
            {
                comboBox2.SelectedIndex = 5;
                comboBox2.Enabled = false;
            }
            else
            {
                comboBox2.Enabled = true;
                if (comboBox2.SelectedIndex == 5)
                    comboBox2.SelectedIndex = 0;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 5)
            {
                if (comboBox1.SelectedIndex == 4)
                    comboBox2.SelectedIndex = 5;
                else
                    comboBox2.SelectedIndex = 4;
            }

            if (comboBox2.SelectedIndex == 0)
                tbRes1.Text = (0.00008 * 4).ToString();
            else if (comboBox2.SelectedIndex == 1)
                tbRes1.Text = (0.00012 * 4).ToString();
            else if (comboBox2.SelectedIndex == 2)
                tbRes1.Text = (0.00016 * 4).ToString();
            else if (comboBox2.SelectedIndex == 3)
                tbRes1.Text = (0.00024 * 4).ToString();
            else if (comboBox2.SelectedIndex == 4)
                tbRes1.Text = (0.00032 * 4).ToString();
            else if (comboBox2.SelectedIndex == 5)
                tbRes1.Text = (0.0008 * 4).ToString();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Vortex
            if (tbRes1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "")
            {
                double rashodGolova = Convert.ToDouble(tbRes1.Text.Replace('.', ','));
                double cena = Convert.ToDouble(textBox2.Text.Replace('.', ','));
                double ves = Convert.ToDouble(textBox3.Text.Replace('.', ','));
                double kolichestvoGolov = Convert.ToDouble(textBox5.Text.Replace('.', ','));
                double periodObrabotki = Convert.ToDouble(textBox6.Text.Replace('.', ','));
                double obrabotokDen = Convert.ToDouble(textBox7.Text.Replace('.', ','));

                double res1 = cena / ves;
                double res2 = rashodGolova * kolichestvoGolov * periodObrabotki * obrabotokDen;
                double res3 = rashodGolova * res1;

                lblRes2.Text = Math.Round(res1, 2).ToString();
                lblRes3.Text = Math.Round(res2, 2).ToString();
                lblRes4.Text = Math.Round(res3, 2).ToString();
            }
            else
                MessageBox.Show("Заполните все данные!");
#endregion

            if (textBox24.Text != "" && textBox23.Text != "" && textBox22.Text != "" && textBox21.Text != "" && textBox20.Text != "" && textBox19.Text != "")
            {
                string prec = comboBox4.Text;
                double percent = Convert.ToDouble(prec.Replace('.', ','));
                double rashodGolova = Convert.ToDouble(textBox24.Text.Replace('.', ','));
                double cena = Convert.ToDouble(textBox23.Text.Replace('.', ','));
                double ves = Convert.ToDouble(textBox22.Text.Replace('.', ','));
                double kolichestvoGolov = Convert.ToDouble(textBox21.Text.Replace('.', ','));
                double periodObrabotki = Convert.ToDouble(textBox20.Text.Replace('.', ','));
                double obrabotokDen = Convert.ToDouble(textBox19.Text.Replace('.', ','));
                

                double res1 = cena / ves;
                double res2 = rashodGolova * kolichestvoGolov * periodObrabotki * obrabotokDen;
                double res3 = rashodGolova * res1;

                lblRes121.Text = Math.Round(res1, 2).ToString();
                lblRes122.Text = Math.Round(res2, 2).ToString();
                lblRes123.Text = Math.Round(res3, 2).ToString();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
                tbRes21.Text = "5.6";
            else if (comboBox3.SelectedIndex == 1)
                tbRes21.Text = "2.8";
            else if (comboBox3.SelectedIndex == 2)
                tbRes21.Text = "2.8";
            else if (comboBox3.SelectedIndex == 3)
                tbRes21.Text = "3.2";
            else if (comboBox3.SelectedIndex == 4)
                tbRes21.Text = "3.2";
            else if (comboBox3.SelectedIndex == 5)
                tbRes21.Text = "5.6";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region Vortex
            if (tbRes21.Text != "" && textBox9.Text != "" && textBox8.Text != "" && textBox10.Text != "" && textBox13.Text != "" && textBox12.Text != "")
            {
                double rashodGolova = Convert.ToDouble(tbRes21.Text.Replace('.', ','));
                double cena = Convert.ToDouble(textBox9.Text.Replace('.', ','));
                double ves = Convert.ToDouble(textBox8.Text.Replace('.', ','));
                double kolichestvoGolov = Convert.ToDouble(textBox10.Text.Replace('.', ','));
                double periodObrabotki = Convert.ToDouble(textBox13.Text.Replace('.', ','));
                double obrabotokDen = Convert.ToDouble(textBox12.Text.Replace('.', ','));

                double res1 = cena / ves;
                double res2 = (periodObrabotki * obrabotokDen) * kolichestvoGolov * (rashodGolova / 1000);
                double res3 = res1 * (rashodGolova / 1000);

                lblRes21.Text = Math.Round(res1, 2).ToString();
                lblRes22.Text = Math.Round(res2, 2).ToString();
                lblRes23.Text = Math.Round(res3, 2).ToString();
            }
            else
                MessageBox.Show("Заполните все данные!");
#endregion

            if (textBox32.Text != "" && textBox31.Text != "" && textBox30.Text != "" && textBox29.Text != "" && textBox28.Text != "" && textBox27.Text != "")
            {
                double rashodGolova = Convert.ToDouble(textBox32.Text.Replace('.', ','));
                double cena = Convert.ToDouble(textBox31.Text.Replace('.', ','));
                double ves = Convert.ToDouble(textBox30.Text.Replace('.', ','));
                double kolichestvoGolov = Convert.ToDouble(textBox29.Text.Replace('.', ','));
                double periodObrabotki = Convert.ToDouble(textBox28.Text.Replace('.', ','));
                double obrabotokDen = Convert.ToDouble(textBox27.Text.Replace('.', ','));

                double res1 = cena / ves;
                double res2 = (periodObrabotki * obrabotokDen) * kolichestvoGolov * (rashodGolova / 1000);
                double res3 = res1 * (rashodGolova / 1000);

                lblRes221.Text = Math.Round(res1, 2).ToString();
                lblRes222.Text = Math.Round(res2, 2).ToString();
                lblRes223.Text = Math.Round(res3, 2).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region Вортекс
            if (textBox4.Text != "" && textBox14.Text != "" && textBox18.Text != "")
            {
                double cena = Convert.ToDouble(textBox4.Text.Replace('.', ','));
                double ves = Convert.ToDouble(textBox14.Text.Replace('.', ','));
                double kolichestvoGolov = Convert.ToDouble(textBox18.Text.Replace('.', ','));

                double res1 = cena / ves;
                double res2 = kolichestvoGolov * 0.008;
                double res3 = 0.008 * res1 * kolichestvoGolov;
                double res4 = res3 / kolichestvoGolov;

                lblRes31.Text = Math.Round(res1, 2).ToString();
                lblRes32.Text = Math.Round(res2, 2).ToString();
                lblRes33.Text = Math.Round(res3, 2).ToString();
                lblRes34.Text = Math.Round(res4, 2).ToString();
            }
            else
                MessageBox.Show("Заполните все данные!");
            #endregion

            if(textBox16.Text != "" && textBox15.Text != "" && textBox11.Text != "")
            {
                double cena = Convert.ToDouble(textBox16.Text.Replace('.', ','));
                double ves = Convert.ToDouble(textBox15.Text.Replace('.', ','));
                double kolichestvoGolov = Convert.ToDouble(textBox11.Text.Replace('.', ','));

                double res1 = cena / ves;
                double res2 = kolichestvoGolov * 0.008;
                double res3 = 0.008 * res1 * kolichestvoGolov;
                double res4 = res3 / kolichestvoGolov;

                lblRes321.Text = Math.Round(res1, 2).ToString();
                lblRes322.Text = Math.Round(res2, 2).ToString();
                lblRes323.Text = Math.Round(res3, 2).ToString();
                lblRes324.Text = Math.Round(res4, 2).ToString();
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == 0)
                textBox24.Text = "0,00008";
            else if (comboBox4.SelectedIndex == 1)
                textBox24.Text = "0,00012";
            else if (comboBox4.SelectedIndex == 2)
                textBox24.Text = "0,00016";
            else if (comboBox4.SelectedIndex == 3)
                textBox24.Text = "0,00024";
            else if (comboBox4.SelectedIndex == 4)
                textBox24.Text = "0,00032";
            else if (comboBox4.SelectedIndex == 5)
                textBox24.Text = "0,0008";
        }

        #region Обработка ввода данных

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

        private void tbRes1_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void tbRes21_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox29_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox28_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

#endregion

    }
}
