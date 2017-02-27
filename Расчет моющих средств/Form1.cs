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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double plotBiotekM = 1.2;
        double plotBiotekC = 1.22;
        double plotBiotek = 1.25;
        double plotBiotekSuper = 1.23;
        double plotKsilanM = 1.16;
        double plotKsilanK = 1.2;
        double plotKsilan = 1.22;
        double plotKsilanSuper = 1.28;
        string rubL = " руб/л";
        string rubKG = " руб/кг";

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            if(label46.Text.Length > 22)
                label46.Text = label46.Text.Insert(22, Environment.NewLine);
            if (label48.Text.Length > 22)
                label48.Text = label48.Text.Insert(22, Environment.NewLine);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kooficent = 0;
            
            double tb1 = Convert.ToDouble(textBox1.Text.Replace('.', ',')); // количество коров
            double tb2 = Convert.ToDouble(textBox2.Text.Replace('.', ',')); // количество доек
            double tb3 = Convert.ToDouble(textBox3.Text.Replace('.', ',')); //концентрат щелочи
            double tb4 = Convert.ToDouble(textBox23.Text.Replace('.', ',')); //концентрат кислоты
            double tb5 = Convert.ToDouble(textBox4.Text.Replace('.', ',')); // количество щелочных моек
            double tb6 = Convert.ToDouble(textBox5.Text.Replace('.', ',')); //количество кислотных моек
            double tb7 = Convert.ToDouble(textBox6.Text.Replace('.', ',')); // объем ванны
            double tb8 = Convert.ToDouble(textBox7.Text.Replace('.', ',')); //количество дней

            if (0 < tb1 && tb1 <= 200)
                kooficent = 1;
            else if (200 < tb1 && tb1 <= 400)
                kooficent = 2;
            else if (400 < tb1 && tb1 <= 600)
                kooficent = 3;
            else if (600 < tb1 && tb1 <= 800)
                kooficent = 4;
            else if (800 < tb1 && tb1 <= 1000)
                kooficent = 5;
            else if (1000 < tb1 && tb1 <= 1200)
                kooficent = 6;

            double res1 = ((tb1 / 200) * ((tb6 * tb3)/100)) * tb2 * tb7; 
            double res2 = (res1 / (tb4 + tb5)) * tb4;
            double res3 = (res1 / (tb4 + tb5)) * tb5;

            res2 = ((tb7 * tb3)/100) * 1.22 * ((tb8 * tb2) / (tb5 + tb6)) * tb5 * kooficent;
            res3 = ((tb7 * tb4)/100) * 1.22 * ((tb8 * tb2) / (tb5 + tb6)) * tb6 * kooficent;
            res1 = res2 + res3;

            lblonv1.Text = res1.ToString();
            lblonv2.Text = res2.ToString();
            lblonv3.Text = res3.ToString();

        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Column == 0)
                using (SolidBrush brush = new SolidBrush(Color .DeepSkyBlue))
                    e.Graphics.FillRectangle(brush, e.CellBounds);
            else
                using (SolidBrush brush = new SolidBrush(Color.Tomato))
                    e.Graphics.FillRectangle(brush, e.CellBounds);
        }

        #region 1 вкладка

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if(textBox8.Text != "")
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    double voda = Convert.ToDouble(textBox8.Text.Replace('.', ','));
                    label14.Text = (voda * 0.36).ToString();
                    label11.Text = "°DH";
                }
                if (comboBox1.SelectedIndex == 0)
                {
                    double voda = Convert.ToDouble(textBox8.Text.Replace('.', ','));
                    label14.Text = voda.ToString();
                    label11.Text = "°Ж";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    double voda = Convert.ToDouble(textBox8.Text.Replace('.', ','));
                    label14.Text = voda.ToString();
                    label11.Text = "мг - экв/л";
                }
                ReturnVoda();
            }
        }

        private void ReturnVoda()
        {
            double vod = Convert.ToDouble(label14.Text);
            if (0 <= vod && vod < 1.5)
            {
                lblVoda.Text = "очень мягкая";
            }
            else if (1.5 <= vod && vod < 3)
            {
                lblVoda.Text = "мягкая";
            }
            else if (3 <= vod && vod < 6)
            {
                lblVoda.Text = "умеренной жесткости";
            }
            else if (6 <= vod && vod <= 12)
            {
                lblVoda.Text = "жесткая";
            }
            else if (vod > 12)
            {
                lblVoda.Text = "очень жесткая";
            }
            else
            {
                lblVoda.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    double voda = Convert.ToDouble(textBox8.Text.Replace('.', ','));
                    label14.Text = (voda * 0.36).ToString();
                    label11.Text = "°DH";
                }
                if (comboBox1.SelectedIndex == 0)
                {
                    double voda = Convert.ToDouble(textBox8.Text.Replace('.', ','));
                    label14.Text = voda.ToString();
                    label11.Text = "°Ж";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    double voda = Convert.ToDouble(textBox8.Text.Replace('.', ','));
                    label14.Text = voda.ToString();
                    label11.Text = "мг - экв/л";
                }
                ReturnVoda();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double voda = Convert.ToDouble(label14.Text.Replace('.', ','));
            string biotekC = "";
            string ksilanK = "";
            string biotek = "";
            string ksilan = "";
            string biotekM = "";
            string ksilanM = "";
            string biotekSuper = "";
            string ksilanSuper = "";

            #region 1 str
            if (voda <= 5)
            {
                biotekC = "Biotec C, 0,3%";
                ksilanK = "Ksilan K, 0,3%";
            }
            else if (voda <= 6.5)
            {
                biotekC = "Biotec C, 0,5%";
                ksilanK = "Ksilan K, 0,5%";
            }
            else if (voda <= 8)
            {
                biotekC = "Biotec C, 1%";
                ksilanK = "Ksilan K, 1%";
            }
            else
            {
                biotekC = "Biotec C не используется";
                ksilanK = "Ksilan K не используется";
            }
            #endregion

            #region 2 str
            if (voda <= 5)
            {
                biotek = "Biotec, 0,3%";
                ksilan = "Ksilan, 0,3%";
            }
            else if (voda <= 6.5)
            {
                biotek = "Biotec, 0,5%";
                ksilan = "Ksilan, 0,5%";
            }
            else if (voda <= 8)
            {
                biotek = "Biotec, 0,7%";
                ksilan = "Ksilan, 0,7%";
            }
            else
            {
                biotek = "Biotec не используется";
                ksilan = "Ksilan не используется";
            }
            #endregion

            #region 3 str
            if (voda <= 10)
            {
                biotekSuper = "Biotec Super, 0,3%";
                ksilanSuper = "Ksilan Super, 0,3%";
            }
            else if (voda <= 12)
            {
                biotekSuper = "Biotec Super, 0,4%";
                ksilanSuper = "Ksilan Super, 0,4%";
            }
            else
            {
                biotekSuper = "Biotec Super не используется";
                ksilanSuper = "Ksilan Super не используется";
            }
            #endregion

            #region 4 str
            if (voda <= 1)
            {
                biotekM = "Biotec M, 0,4%";
                ksilanM = "Ksilan M, 0,4%";
            }
            else if (voda <= 2)
            {
                biotekM = "Biotec M, 0,5%";
                ksilanM = "Ksilan M, 0,5%";
            }
            else if (voda <= 3)
            {
                biotekM = "Biotec M, 0,7%";
                ksilanM = "Ksilan M, 0,7%";
            }
            else if (voda <= 4)
            {
                biotekM = "Biotec M, 1%";
                ksilanM = "Ksilan M, 1%";
            }
            else
            {
                biotekM = "Biotec M не используется";
                ksilanM = "Ksilan M не используется";
            }
            #endregion
            
            label12.Text = biotekC;
            label13.Text = ksilanK;
            label49.Text = biotek;
            label50.Text = ksilan;
            label51.Text = biotekM;
            label52.Text = ksilanM;
            label53.Text = biotekSuper;
            label54.Text = ksilanSuper;
        }
        #endregion

        private void button2_Click_1(object sender, EventArgs e)
        {
            //label24.Font = new Font(label24.Font.Name, label24.Font.Size);
            //label32.Font = new Font(label32.Font.Name, label32.Font.Size);
            #region проверка заполнения
            if (label21.Text == "" || textBox9.Text == "" || textBox10.Text == "" || textBox19.Text == "" || textBox20.Text == "")
            {
                MessageBox.Show("Заполните пожалуйста все данные");
                return;
            }
                
            #endregion

            #region вортекс
            double plotnost = Convert.ToDouble(label21.Text.ToString().Replace('.', ','));
            double stoimost = Convert.ToDouble(textBox9.Text.Replace('.', ','));
            double ves = Convert.ToDouble(textBox10.Text.Replace('.', ','));
            double koncentrac = Convert.ToDouble(textBox19.Text.Replace('.', ','));
            double obyem = Convert.ToDouble(textBox20.Text.Replace('.', ','));

            double resStoimostKG = stoimost / ves;
            double resStoimostLitr = resStoimostKG * plotnost;
            double resStoimostPromyv = (resStoimostLitr * koncentrac * obyem) / 100;
            double resStoimostLitrSredstv = resStoimostPromyv / obyem;


            label24.Text = Math.Round(resStoimostKG, 2) + rubKG;
            label30.Text = Math.Round(resStoimostLitr, 2) + rubL;
            label37.Text = Math.Round(resStoimostPromyv, 2).ToString();
            label45.Text = Math.Round(resStoimostLitrSredstv, 2).ToString();
            #endregion

            #region сравнение
            if(textBox17.Text != "" && textBox18.Text != "" && textBox22.Text != "" && textBox21.Text != "")
            {
                if (textBox14.Text == "")
                    textBox14.Text = 1.2.ToString();

                double plotnost2 = Convert.ToDouble(textBox14.Text.ToString().Replace('.', ','));
                double stoimost2 = Convert.ToDouble(textBox17.Text.Replace('.', ','));
                double ves2 = Convert.ToDouble(textBox18.Text.Replace('.', ','));
                double koncentrac2 = Convert.ToDouble(textBox22.Text.Replace('.', ','));
                double obyem2 = Convert.ToDouble(textBox21.Text.Replace('.', ','));

                double resStoimostKG2 = stoimost2 / ves2;
                double resStoimostLitr2 = resStoimostKG2 * plotnost2;
                double resStoimostPromyv2 = (resStoimostLitr2 * koncentrac2 * obyem2) / 100;
                double resStoimostLitrSredstv2 = resStoimostPromyv2 / obyem2;


                label32.Text = Math.Round(resStoimostKG2, 2) + rubKG;
                label31.Text = Math.Round(resStoimostLitr2, 2) + rubL;
                label36.Text = Math.Round(resStoimostPromyv2, 2).ToString();
                label47.Text = Math.Round(resStoimostLitrSredstv2, 2).ToString();
            }           
            #endregion
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
                label21.Text = plotBiotekM.ToString();
            else if (comboBox2.SelectedIndex == 1)
                label21.Text = plotBiotekC.ToString();
            else if (comboBox2.SelectedIndex == 2)
                label21.Text = plotBiotek.ToString();
            else if (comboBox2.SelectedIndex == 3)
                label21.Text = plotBiotekSuper.ToString();
            else if (comboBox2.SelectedIndex == 4)
                label21.Text = plotKsilanM.ToString();
            else if (comboBox2.SelectedIndex == 5)
                label21.Text = plotKsilanK.ToString();
            else if (comboBox2.SelectedIndex == 6)
                label21.Text = plotKsilan.ToString();
            else if (comboBox2.SelectedIndex == 7)
                label21.Text = plotKsilanSuper.ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vortex vortex = new Vortex();
            vortex.Show();
        }

        #region Обработка ввода данных

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
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

        private void textBox23_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion
    }
}
