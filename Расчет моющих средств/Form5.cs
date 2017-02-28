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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vortex vortex = new Vortex();
            vortex.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0)
            {
                textBox6.Text = "0,25";
                textBox5.Text = "20";
                textBox3.Text = "0.25";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox6.Text = "0,35";
                textBox5.Text = "30";
                textBox3.Text = "0.25";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text != "" && textBox4.Text != "" && textBox8.Text != "" && textBox7.Text != "")
            {
                double cena = Convert.ToDouble(textBox8.Text.Replace('.', ','));
                double ves = Convert.ToDouble(textBox7.Text.Replace('.', ','));
                double S = Convert.ToDouble(textBox4.Text.Replace('.', ','));
                double rashod = Convert.ToDouble(textBox6.Text.Replace('.', ','));
                double koncentrat = Convert.ToDouble(textBox3.Text.Replace('.', ','));

                double res1 = cena / ves;
                double res2 = ((S * rashod) * koncentrat) / 100;
                double res3 = res1 * res2;

                label17.Text = res1.ToString();
                label16.Text = res2.ToString();
                label15.Text = res3.ToString();
            }
            else
                MessageBox.Show("Заполните все поля");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "" && textBox10.Text != "" && textBox12.Text != "" && textBox13.Text != "" && textBox11.Text != "")
            {
                double cena = Convert.ToDouble(textBox13.Text.Replace('.', ','));
                double ves = Convert.ToDouble(textBox11.Text.Replace('.', ','));
                double S = Convert.ToDouble(textBox9.Text.Replace('.', ','));
                double rashod = Convert.ToDouble(textBox12.Text.Replace('.', ','));
                double koncentrat = Convert.ToDouble(textBox10.Text.Replace('.', ','));

                double res1 = cena / ves;
                double res2 = ((S * rashod) * koncentrat) / 100;
                double res3 = res1 * res2;

                label20.Text = res1.ToString();
                label19.Text = res2.ToString();
                label18.Text = res3.ToString();
            }
            else
                MessageBox.Show("Заполните все поля");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double visota = Convert.ToDouble(textBox14.Text.Replace('.', ','));
            double visotaKon = Convert.ToDouble(textBox15.Text.Replace('.', ','));
            double dlinna = Convert.ToDouble(textBox17.Text.Replace('.', ','));
            double shirina = Convert.ToDouble(textBox16.Text.Replace('.', ','));
            double rashod = Convert.ToDouble(textBox20.Text.Replace('.', ','));
            double kratnost = Convert.ToDouble(textBox23.Text.Replace('.', ','));

            double res1 = (dlinna * shirina * visota) + (((visotaKon - visota) * shirina) / 2) * dlinna;
            double res2 = (kratnost * rashod * res1) / 1000;

            label44.Text = res1.ToString();
            label43.Text = res2.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            double visota = Convert.ToDouble(textBox29.Text.Replace('.', ','));
            double visotaKon = Convert.ToDouble(textBox28.Text.Replace('.', ','));
            double dlinna = Convert.ToDouble(textBox27.Text.Replace('.', ','));
            double shirina = Convert.ToDouble(textBox26.Text.Replace('.', ','));
            //double rashod = Convert.ToDouble(textBox20.Text.Replace('.', ','));
            double kratnost = Convert.ToDouble(textBox19.Text.Replace('.', ','));
            double koncentraciya = Convert.ToDouble(comboBox2.Text.Replace('.', ','));

            double res1 = (dlinna * shirina * visota) + (((visotaKon - visota) * shirina) / 2) * dlinna;
            double res2 = (30 * koncentraciya) / 100;
            double res3 = (kratnost * res2 * res1) / 1000;

            label45.Text = res1.ToString();
            label70.Text = res2.ToString();
            label46.Text = res3.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            double visota = Convert.ToDouble(textBox35.Text.Replace('.', ','));
            double visotaKon = Convert.ToDouble(textBox34.Text.Replace('.', ','));
            double dlinna = Convert.ToDouble(textBox33.Text.Replace('.', ','));
            double shirina = Convert.ToDouble(textBox32.Text.Replace('.', ','));
            double kratnost = Convert.ToDouble(textBox22.Text.Replace('.', ','));
            double koncentraciya = Convert.ToDouble(textBox36.Text.Replace('.', ','));

            double res1 = (dlinna * shirina * visota) + (((visotaKon - visota) * shirina) / 2) * dlinna;
            double res2 = (5 * koncentraciya) / 100;
            double res3 = (kratnost * res2 * res1) / 1000;

            label59.Text = res1.ToString();
            label57.Text = res2.ToString();
            label60.Text = res3.ToString();
        }
    }
}
