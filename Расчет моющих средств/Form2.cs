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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "" && textBox4.Text != "")
            {
                double vanna = 200;
                double d5 = 36;
                double d13 = 42;
                double stado = Convert.ToDouble(textBox1.Text.Replace('.', ','));
                double percentDesimix1 = Convert.ToDouble(textBox2.Text.Replace('.', ','));
                double percentKuporos1 = Convert.ToDouble(textBox3.Text.Replace('.', ','));
                double percentDesimix2 = Convert.ToDouble(textBox5.Text.Replace('.', ','));
                double percentKuporos2 = Convert.ToDouble(textBox4.Text.Replace('.', ','));

                double res1 = (vanna * percentDesimix1) / 100;
                double res2 = (vanna * percentKuporos1) / 100;
                double res3 = (stado * d5) / 500;
                double res4 = res1 * res3;
                double res5 = res2 * res3;

                label6.Text = res1.ToString();
                label7.Text = res2.ToString();
                label9.Text = res3.ToString();
                label11.Text = res4.ToString();
                label13.Text = res5.ToString();



                double res6 = (vanna * percentDesimix2) / 100;
                double res7 = (vanna * percentKuporos2) / 100;
                double res8 = (stado * d13) / 500;
                double res9 = res6 * res8;
                double res10 = res7 * res8;

                label23.Text = res6.ToString();
                label21.Text = res7.ToString();
                label19.Text = res8.ToString();
                label17.Text = res9.ToString();
                label15.Text = res10.ToString();

                double res11 = res4 + res9;
                double res12 = res5 + res10;

                label26.Text = res11.ToString();
                label28.Text = res12.ToString();
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vortex vortex = new Vortex();
            vortex.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region Vortex
            double vanna = 200;
            double stado = Convert.ToDouble(textBox9.Text.Replace('.', ','));
            double day = Convert.ToDouble(textBox12.Text.Replace('.', ','));
            double percent = Convert.ToDouble(textBox13.Text.Replace('.', ','));
            double canistra = Convert.ToDouble(textBox17.Text.Replace('.', ','));
            double ves = Convert.ToDouble(textBox18.Text.Replace('.', ','));

            double res1 = (vanna * percent) / 100;
            double res2 = (day / 7) * 2;
            double res3 = (res2 * stado) / 200;
            double res4 = res1 * res3;
            double res5 = canistra / ves;
            double res6 = res4 * res5;
            double res8 = res6 / stado;
            double res7 = res8 / day;

            label60.Text = Math.Round(res1, 0).ToString();
            textBox14.Text = Math.Round(res2, 0).ToString();
            label69.Text = Math.Round(res3, 0).ToString();
            label72.Text = Math.Round(res4, 0).ToString();
            label81.Text = Math.Round(res5, 0).ToString();
            label84.Text = Math.Round(res6, 0).ToString();
            label87.Text = Math.Round(res7, 0).ToString();
            label90.Text = Math.Round(res8, 0).ToString();
            #endregion

            #region Сравнение
            if (textBox27.Text != "" && textBox26.Text != "" && textBox25.Text != "" && textBox23.Text != "" && textBox22.Text != "")
            {
                double vanna2 = 200;
                double stado2 = Convert.ToDouble(textBox27.Text.Replace('.', ','));
                double day2 = Convert.ToDouble(textBox26.Text.Replace('.', ','));
                double percent2 = Convert.ToDouble(textBox25.Text.Replace('.', ','));
                double canistra2 = Convert.ToDouble(textBox23.Text.Replace('.', ','));
                double ves2 = Convert.ToDouble(textBox22.Text.Replace('.', ','));

                double res21 = (vanna2 * percent2) / 100;
                double res22 = (day2 / 7) * 2;
                double res23 = (res22 * stado2) / 200;
                double res24 = res21 * res23;
                double res25 = canistra2 / ves2;
                double res26 = res24 * res25;
                double res28 = res26 / stado2;
                double res27 = res28 / day2;

                lblres1.Text = Math.Round(res21, 0).ToString();
                tbRes2.Text = Math.Round(res22, 0).ToString();
                lblres3.Text = Math.Round(res23, 0).ToString();
                lblres4.Text = Math.Round(res24, 0).ToString();
                lblres5.Text = Math.Round(res25, 0).ToString();
                lblres6.Text = Math.Round(res26, 0).ToString();
                lblres7.Text = Math.Round(res27, 0).ToString();
                lblres8.Text = Math.Round(res28, 0).ToString();
            }
            #endregion
        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region Vortex
            double vanna = 200;
            double stado = Convert.ToDouble(textBox21.Text.Replace('.', ','));
            double day = Convert.ToDouble(textBox20.Text.Replace('.', ','));
            double percent = Convert.ToDouble(textBox19.Text.Replace('.', ','));
            double canistra = Convert.ToDouble(textBox15.Text.Replace('.', ','));
            double ves = Convert.ToDouble(textBox6.Text.Replace('.', ','));

            double res1 = (vanna * percent) / 100;
            double res2 = (day / 7) * 10;
            double res3 = (res2 * stado) / 200;
            double res4 = res1 * res3;
            double res5 = canistra / ves;
            double res6 = res4 * res5;
            double res8 = res6 / stado;
            double res7 = res8 / day;

            label99.Text = Math.Round(res1, 0).ToString();
            textBox16.Text = Math.Round(res2, 0).ToString();
            label96.Text = Math.Round(res3, 0).ToString();
            label94.Text = Math.Round(res4, 0).ToString();
            label85.Text = Math.Round(res5, 0).ToString();
            label79.Text = Math.Round(res6, 0).ToString();
            label76.Text = Math.Round(res7, 0).ToString();
            label73.Text = Math.Round(res8, 0).ToString();
            #endregion

            if (textBox33.Text != "" && textBox32.Text != "" && textBox31.Text != "" && textBox29.Text != "" && textBox28.Text != "")
            {
                #region Сравнение
                double vanna2 = 200;
                double stado2 = Convert.ToDouble(textBox33.Text.Replace('.', ','));
                double day2 = Convert.ToDouble(textBox32.Text.Replace('.', ','));
                double percent2 = Convert.ToDouble(textBox31.Text.Replace('.', ','));
                double canistra2 = Convert.ToDouble(textBox29.Text.Replace('.', ','));
                double ves2 = Convert.ToDouble(textBox28.Text.Replace('.', ','));

                double res21 = (vanna2 * percent2) / 100;
                double res22 = (day2 / 7) * 10;
                double res23 = (res22 * stado2) / 200;
                double res24 = res21 * res23;
                double res25 = canistra2 / ves2;
                double res26 = res24 * res25;
                double res28 = res26 / stado2;
                double res27 = res28 / day2;

                lblres21.Text = Math.Round(res21, 0).ToString();
                tbres22.Text = Math.Round(res22, 0).ToString();
                lblres23.Text = Math.Round(res23, 0).ToString();
                lblres24.Text = Math.Round(res24, 0).ToString();
                lblres25.Text = Math.Round(res25, 0).ToString();
                lblres26.Text = Math.Round(res26, 0).ToString();
                lblres27.Text = Math.Round(res27, 0).ToString();
                lblres28.Text = Math.Round(res28, 0).ToString();
                #endregion
            }
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void tbRes2_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox33_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbres22_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox7.Text != "" && textBox8.Text != "" && textBox11.Text != "")
            {
                double stado = Convert.ToDouble(textBox7.Text.Replace('.', ','));
                double vanna = 200;
                double day = Convert.ToDouble(textBox8.Text.Replace('.', ','));
                double percentDesimix = Convert.ToDouble(textBox11.Text.Replace('.', ','));

                double res1 = (vanna * percentDesimix) / 100;
                double res3 = (day / 7) * 6;
                double res4 = (stado * res3) / 500;
                double res5 = res1 * res4;

                label50.Text = Math.Round(res1, 0).ToString();
                label56.Text = Math.Round(res3, 0).ToString();
                label53.Text = Math.Round(res4, 0).ToString();
                label62.Text = Math.Round(res5, 0).ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(tbCountStado.Text != "" && lblVanna.Text != "" && tbCountObrabotki.Text != "" && tbPercent.Text != "" && tbCountDay.Text != "" && tbKuporosKg.Text != "")
            {
                double countStado = Convert.ToDouble(tbCountStado.Text);
                double vanna = Convert.ToDouble(lblVanna.Text);
                double countObrabotki = Convert.ToDouble(tbCountObrabotki.Text);
                double percent = Convert.ToDouble(tbPercent.Text);
                double countDay = Convert.ToDouble(tbCountDay.Text);
                double kuporosKg = Convert.ToDouble(tbKuporosKg.Text);

                double res1 = (countStado / vanna) * ((vanna * percent) / 100) * countDay * countObrabotki;
                double res2 = res1 * kuporosKg;
                double res3 = res2 / countStado;

                lblTrebuemKuporosKg.Text = Math.Round(res1).ToString();
                lblStoimPeriod.Text = Math.Round(res2).ToString();
                lblStoimGolova.Text = Math.Round(res3).ToString();
            }
            else
            {
                MessageBox.Show("Введите все данные");
            }
        }
    }
}
