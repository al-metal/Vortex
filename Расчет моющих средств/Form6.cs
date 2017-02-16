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
    public partial class Form6 : Form
    {
        public Label newlabel = new Label();
        string[,] table;
        int inn = 1;
        string dH;

        #region TABLE
        string[,] peno50ligth = new string[10, 3]
     {
            {"Unior","1:60", "850" },
            {"Tiro, Tiro Tone","1:80", "625" },
            {"Master, Master Tone","1:100", "500" },
            {"Profy","1:120", "425" },
            {"Dozex","1:100", "500" },
            {"Ace","1:140", "350" },
            {"Magnat","1:110", "450" },
            {"Delicate","1:80", "625" },
            {"Solo","1:70", "725" },
            {"DIY","1:120", "425" }
     };
        string[,] peno50default = new string[13, 3]
     {
            {"Unior","1:40", "1200" },
            {"Tiro, Tiro Tone","1:60", "800" },
            {"Novice","1:80", "600" },
            {"Master, Master Tone","1:80", "600" },
            {"Tutor ","1:100", "500" },
            {"Profy","1:100", "500" },
            {"Dozex","1:90", "550" },
            {"Senza","1:120", "400" },
            {"Ace","1:120", "400" },
            {"Magnat","1:100", "500" },
            {"Delicate","1:60", "800" },
            {"Solo","1:55", "900" },
            {"DIY","1:100", "500" }
     };
        string[,] peno50hard = new string[7, 3]
     {
         {"Novice","1:50", "1000" },
         {"Tutor ","1:60", "800" },
         {"Profy","1:60", "800" },
         {"Senza","1:80", "600" },
         {"Ace","1:80", "600" },
         {"Magnat","1:60", "800" },
         {"DIY","1:60", "800" }
     };

        string[,] penokomplektligth = new string[10, 3]
     {
            {"Unior","1:4", "200" },
            {"Tiro, Tiro Tone","1:6", "150" },
            {"Master, Master Tone","1:7", "110" },
            {"Profy","1:10", "90" },
            {"Dozex","1:9", "100" },
            {"Ace","1:12", "80" },
            {"Magnat","1:9", "100" },
            {"Delicate","1:6", "150" },
            {"Solo","1:5", "170" },
            {"DIY","1:10", "90" }
     };
        string[,] penokomplektdefault = new string[13, 3]
     {
            {"Unior","1:2", "300" },
            {"Tiro, Tiro Tone","1:4", "200" },
            {"Novice","1:6", "145" },
            {"Master, Master Tone","1:6", "145" },
            {"Tutor ","1:8", "110" },
            {"Profy","1:8", "110" },
            {"Dozex","1:7", "125" },
            {"Senza","1:10", "90" },
            {"Ace","1:10", "90" },
            {"Magnat","1:8", "110" },
            {"Delicate","1:4", "200" },
            {"Solo","1:4", "200" },
            {"DIY","1:8", "110" }
     };
        string[,] ppenokomplekthard = new string[7, 3]
     {
         {"Novice","1:4", "200" },
         {"Tutor ","1:6", "145" },
         {"Profy","1:6", "145" },
         {"Senza","1:7", "125" },
         {"Ace","1:7", "125" },
         {"Magnat","1:6", "145" },
         {"DIY","1:3", "250" }
     };

        string[,] dozatronligth = new string[9, 2]
     {
            {"Unior", "2" },
            {"Tiro, Tiro Tone", "1.5" },
            {"Master, Master Tone", "1" },
            {"Profy", "1" },
            {"Dozex", "1" },
            {"Ace", "0.5" },
            {"Delicate", "1.5" },
            {"Solo", "1.5" },
            {"DIY", "1" }
     };
        string[,] dozatrondefault = new string[12, 2]
     {
            {"Unior", "3" },
            {"Tiro, Tiro Tone", "2" },
            {"Novice", "1.5" },
            {"Master, Master Tone", "1.5" },
            {"Tutor ", "1" },
            {"Profy", "1" },
            {"Dozex", "1" },
            {"Senza", "1" },
            {"Ace", "1" },
            {"Delicate", "2" },
            {"Solo", "2" },
            {"DIY", "1" }
     };
        string[,] dozatronhard = new string[6, 2]
     {
         {"Novice", "2" },
         {"Tutor ", "2" },
         {"Profy", "2" },
         {"Senza", "1.5" },
         {"Ace", "1.5" },
         {"DIY", "2" }
     };
        private object tb_KeyPress;
        private object ntb_KeyPress;
        #endregion

        public Form6(string[,] table, string dH)
        {
            InitializeComponent();
            this.table = table;
            this.dH = dH;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            int rows = table.GetUpperBound(0) + 1;

            for (int i = 0; rows > i; i++)
            {
                Size = new Size(this.Size.Width + 117, this.Size.Height);
                int X = 320;
                int Y = 45;
                int countRow = table.GetUpperBound(0) + 1;
                countRow = 2;
                string nameProduct = table[i, 0];
                AddNewGP(inn, countRow, X, Y, nameProduct, dH);
                inn = inn + 1;
            }
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int max = 0;
            label20.Text = "Лучшее средство";
            #region  Vortex заполнение и расчеты
            int i = 1;
            foreach (Control con in this.Controls)
            {
                if (con.Name == "gp" + i)
                {
                    string tb6 = "tb" + i + "6";
                    string tb10 = "tb" + i + "10";
                    string tb3 = "tb" + i + "3";
                    string tb9 = "tb" + i + "9";
                    string tb8 = "tb" + i + "8";
                    string tb11 = "tb" + i + "11";
                    string tb12 = "tb" + i + "12";

                    if (con.Controls[tb8].Text == "")
                    {
                        MessageBox.Show("Не заполнена стоимость канистры");
                        return;
                    }

                    double penaob = Convert.ToDouble(con.Controls[tb6].Text);
                    double resTb10 = penaob / 3;
                    double ob50 = Convert.ToDouble(con.Controls[tb3].Text);
                    double resTb9 = ob50 / 14;
                    double cena = Convert.ToDouble(con.Controls[tb8].Text);
                    double resTb11 = 1 * cena / 20000 * resTb9;
                    double resTb12 = 20000 / resTb9;

                    con.Controls[tb10].Text = Math.Round(resTb10, 0).ToString();
                    con.Controls[tb9].Text = Math.Round(resTb9, 0).ToString();
                    con.Controls[tb11].Text = Math.Round(resTb11, 0).ToString();
                    con.Controls[tb12].Text = Math.Round(resTb12, 0).ToString();
                    i++;

                   
                }
            }
            #endregion

            #region Лучшее средство
            List<int> countavto = new List<int>();
            i = 1;
            foreach (Control con2 in this.Controls)
            {

                if (con2.Name.Contains("gp"))
                {
                    string tb122 = "tb" + i + "12";
                    countavto.Add(Convert.ToInt32(con2.Controls[tb122].Text));
                    i++;
                }
            }
            max = countavto.Max();

            i = 1;
            foreach (Control con2 in this.Controls)
            {

                if (con2.Name.Contains("gp"))
                {
                    string tb122 = "tb" + i + "12";
                    if (con2.Controls[tb122].Text == max.ToString())
                    {
                        label20.Text = con2.Text;
                    }
                    i++;
                }
            }
            #endregion

            #region для сравнения
            if (textBox3.Text != "" && textBox6.Text != "" && textBox8.Text != "" && textBox18.Text != "")
            {
                double ob50 = Convert.ToDouble(textBox3.Text.Replace('.', ','));
                double ob1 = Convert.ToDouble(textBox6.Text.Replace('.', ','));
                double cena = Convert.ToDouble(textBox8.Text.Replace('.', ','));

                double res1 = ob50 / 14;
                double res2 = ob1 / 3;
                double res3 = 1 * cena / 20000 * res1;
                double res4 = 20000 / res1;

                textBox9.Text = Math.Round(res1, 0).ToString();
                textBox10.Text = Math.Round(res2, 0).ToString();
                textBox11.Text = Math.Round(res3, 0).ToString();
                textBox12.Text = Math.Round(Math.Round(res4), 0).ToString();

                double avtoClient = Convert.ToDouble(textBox12.Text.Replace('.', ','));
                int mashinbolshe =  max - (int)avtoClient;
                if(mashinbolshe >= 0)
                label21.Text = mashinbolshe.ToString();
                else
                    label21.Text = 0.ToString();
                double stoimostMoiki = Convert.ToDouble(textBox18.Text.Replace('.', ','));
                double pribil = stoimostMoiki * mashinbolshe;
                if(pribil >= 0)
                textBox20.Text = pribil.ToString();
                else
                    textBox20.Text = 0.ToString();
            }
            #endregion
        }

        private GroupBox AddNewGP(int inn, int countRow, int x, int y, string name, string dH)
        {
            List<string> products = ReturnProducts(name, dH);

            GroupBox gp = new GroupBox();
            gp.AutoSize = true;
            gp.Width = 115;
            gp.Height = 398;
            gp.Location = new Point((x + (gp.Width * inn)) + 6, y);
            gp.Text = name;
            gp.Name = "gp" + inn.ToString();
            this.Controls.Add(gp);

            TextBox tb = new TextBox();
            tb.AutoSize = true;
            tb.Text = products[0].ToString();
            tb.Name = "tb" + inn.ToString() + 1;
            tb.Enabled = false;
            tb.Location = new Point(6, 29);
            gp.Controls.Add(tb);
            int oldY = 29;

            for (int i = 0; 3 > i; i++)
            {
                int Y = (oldY + 20) + 6;
                TextBox ntb = new TextBox();
                ntb.AutoSize = true;
                ntb.Enabled = false;
                int ml = Convert.ToInt32(products[1].ToString());
                if (i == 0)
                {
                    ntb.Name = "tb" + inn.ToString() + 2;
                    ntb.Text = (ml / 2).ToString();
                }
                else if (i == 1)
                {
                    ntb.Name = "tb" + inn.ToString() + 3;
                    ntb.Text = ml.ToString();
                }
                else if (i == 2)
                {
                    ntb.Name = "tb" + inn.ToString() + 4;
                    ntb.Text = (ml * 2).ToString();
                }
                ntb.Location = new Point(tb.Location.X, Y);
                oldY = ntb.Location.Y;
                gp.Controls.Add(ntb);
            }

            TextBox tb2 = new TextBox();
            tb2.AutoSize = true;
            tb2.Text = products[2].ToString();
            tb2.Enabled = false;
            tb2.Name = "tb" + inn.ToString() + 5;
            tb2.Location = new Point(6, 159);
            gp.Controls.Add(tb2);
            oldY = 159;

            TextBox tb4 = new TextBox();
            tb4.AutoSize = true;
            tb4.Text = products[3].ToString();
            tb4.Enabled = false;
            tb4.Name = "tb" + inn.ToString() + 6;
            tb4.Location = new Point(6, 185);
            gp.Controls.Add(tb4);
            oldY = 185;

            TextBox tb3 = new TextBox();
            tb3.AutoSize = true;
            tb3.Location = new Point(6, 237);
            tb3.Enabled = false;
            tb3.Name = "tb" + inn.ToString() + 7;
            tb3.Text = products[4].ToString();
            gp.Controls.Add(tb3);
            oldY = 237;

            for (int i = 0; 5 > i; i++)
            {
                int Y = (oldY + 20) + 6;
                TextBox ntb = new TextBox();
                ntb.AutoSize = true;
                ntb.Enabled = false;
                if (i == 0)
                {
                    ntb.Name = "tb" + inn.ToString() + 8;
                    ntb.Enabled = true;
                    ntb.KeyPress += textBox3_KeyPress;
                }
                else if (i == 1)
                    ntb.Name = "tb" + inn.ToString() + 9;
                else if (i == 2)
                    ntb.Name = "tb" + inn.ToString() + 10;
                else if (i == 3)
                    ntb.Name = "tb" + inn.ToString() + 11;
                else if (i == 4)
                    ntb.Name = "tb" + inn.ToString() + 12;
                ntb.Location = new Point(tb2.Location.X, Y);
                oldY = ntb.Location.Y;
                gp.Controls.Add(ntb);
            }
            inn = inn + 1;
            return gp;
        }

        private List<string> ReturnProducts(string name, string dH)
        {
            List<string> products = new List<string>();
            string penogenchast = "";
            string penogenob = "";
            string penokomchast = "";
            string penokomob = "";
            string dozatronpercent = "";

            if (dH == "ligth")
            {
                for (int i = 0; peno50ligth.GetLength(0) > i; i++)
                {
                    if (peno50ligth[i, 0] == name)
                    {
                        penogenchast = peno50ligth[i, 1];
                        penogenob = peno50ligth[i, 2];
                        break;
                    }
                }
                for (int i = 0; penokomplektligth.GetLength(0) > i; i++)
                {
                    if (penokomplektligth[i, 0] == name)
                    {
                        penokomchast = penokomplektligth[i, 1];
                        penokomob = penokomplektligth[i, 2];
                        break;
                    }
                }
                for (int i = 0; dozatronligth.GetLength(0) > i; i++)
                {
                    if (dozatronligth[i, 0] == name)
                    {
                        dozatronpercent = dozatronligth[i, 1];
                        break;
                    }
                }
            }
            else if (dH == "default")
            {
                for (int i = 0; peno50default.GetLength(0) > i; i++)
                {
                    if (peno50default[i, 0] == name)
                    {
                        penogenchast = peno50default[i, 1];
                        penogenob = peno50default[i, 2];
                        break;
                    }
                }
                for (int i = 0; penokomplektdefault.GetLength(0) > i; i++)
                {
                    if (penokomplektdefault[i, 0] == name)
                    {
                        penokomchast = penokomplektdefault[i, 1];
                        penokomob = penokomplektdefault[i, 2];
                        break;
                    }
                }
                for (int i = 0; dozatrondefault.GetLength(0) > i; i++)
                {
                    if (dozatrondefault[i, 0] == name)
                    {
                        dozatronpercent = dozatrondefault[i, 1];
                        break;
                    }
                }
            }
            else if (dH == "hard")
            {

                for (int i = 0; peno50hard.GetLength(0) > i; i++)
                {
                    if (peno50hard[i, 0] == name)
                    {
                        penogenchast = peno50hard[i, 1];
                        penogenob = peno50hard[i, 2];
                        break;
                    }
                }
                for (int i = 0; ppenokomplekthard.GetLength(0) > i; i++)
                {
                    if (ppenokomplekthard[i, 0] == name)
                    {
                        penokomchast = ppenokomplekthard[i, 1];
                        penokomob = ppenokomplekthard[i, 2];
                        break;
                    }
                }
                for (int i = 0; dozatronhard.GetLength(0) > i; i++)
                {
                    if (dozatronhard[i, 0] == name)
                    {
                        dozatronpercent = dozatronhard[i, 1];
                        break;
                    }
                }
            }

            products.Add(penogenchast);
            products.Add(penogenob);
            products.Add(penokomchast);
            products.Add(penokomob);
            products.Add(dozatronpercent);

            return products;
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }
    }
}
