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

    public partial class Form4 : Form
    {
        int countSravnenie = 0;
        string dH = "";
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
#endregion
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vortex vortex = new Vortex();
            vortex.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox1.Visible = true;
                textBox1.Visible = false;
                groupBox3.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
            }
            else
            {
                comboBox1.Visible = false;
                textBox1.Visible = true;
                groupBox3.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Height = 58;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView2.Height = 58;
            dataGridView2.Visible = false;
            button1.Visible = false;
            label4.Visible = false;
            #region Пеногенератор 50
            if (comboBox2.SelectedIndex == 0)
            {
                dataGridView1.Columns[1].HeaderText = "Разбавление";
                dataGridView1.Columns[2].HeaderText = "Кол-во шампуня, мл";
                if (dH == "ligth")
                {
                    int countRow = peno50ligth.GetUpperBound(0) + 1;
                    int countCell = peno50ligth.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = peno50ligth[i, j];
                }
                else if (dH == "default")
                {
                    int countRow = peno50default.GetUpperBound(0) + 1;
                    int countCell = peno50default.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = peno50default[i, j];
                }
                else if (dH == "hard")
                {
                    int countRow = peno50hard.GetUpperBound(0) + 1;
                    int countCell = peno50hard.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = peno50hard[i, j];
                }
            }
            #endregion

            #region Пенокомплект
            if (comboBox2.SelectedIndex == 1)
            {
                dataGridView1.Columns[1].HeaderText = "Разбавление";
                dataGridView1.Columns[2].HeaderText = "Кол-во шампуня, мл";
                if (dH == "ligth")
                {
                    int countRow = penokomplektligth.GetUpperBound(0) + 1;
                    int countCell = penokomplektligth.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = penokomplektligth[i, j];
                }
                else if (dH == "default")
                {
                    int countRow = penokomplektdefault.GetUpperBound(0) + 1;
                    int countCell = penokomplektdefault.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = penokomplektdefault[i, j];
                }
                else if (dH == "hard")
                {
                    int countRow = ppenokomplekthard.GetUpperBound(0) + 1;
                    int countCell = ppenokomplekthard.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = ppenokomplekthard[i, j];
                }
            }
            #endregion

            #region Дозатрон
            if (comboBox2.SelectedIndex == 2)
            {
                dataGridView1.Columns[1].HeaderText = "Показатель концентрации, %";
                dataGridView1.Columns[2].HeaderText = "";
                if (dH == "ligth")
                {
                    int countRow = dozatronligth.GetUpperBound(0) + 1;
                    int countCell = dozatronligth.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = dozatronligth[i, j];
                }
                else if (dH == "default")
                {
                    int countRow = dozatrondefault.GetUpperBound(0) + 1;
                    int countCell = dozatrondefault.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = dozatrondefault[i, j];
                }
                else if (dH == "hard")
                {
                    int countRow = dozatronhard.GetUpperBound(0) + 1;
                    int countCell = dozatronhard.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = dozatronhard[i, j];
                }
            }
            #endregion
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Height = 58;
            dataGridView1.Rows.Clear();
            if (comboBox1.SelectedIndex == 0)
                dH = "ligth";
            else if (comboBox1.SelectedIndex == 1)
                dH = "default";
            else if (comboBox1.SelectedIndex == 2)
                dH = "hard";

            if (comboBox1.SelectedIndex == 0)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    int countRow = peno50ligth.GetUpperBound(0) + 1;
                    int countCell = peno50ligth.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = peno50ligth[i, j];
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    int countRow = penokomplektligth.GetUpperBound(0) + 1;
                    int countCell = penokomplektligth.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = penokomplektligth[i, j];
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    int countRow = peno50ligth.GetUpperBound(0) + 1;
                    int countCell = peno50ligth.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = peno50ligth[i, j];
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    int countRow = peno50default.GetUpperBound(0) + 1;
                    int countCell = peno50default.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = peno50default[i, j];
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    int countRow = penokomplektdefault.GetUpperBound(0) + 1;
                    int countCell = penokomplektdefault.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = penokomplektdefault[i, j];
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    int countRow = dozatrondefault.GetUpperBound(0) + 1;
                    int countCell = dozatrondefault.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = dozatrondefault[i, j];
                }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                
                if (comboBox2.SelectedIndex == 0)
                {
                    int countRow = peno50hard.GetUpperBound(0) + 1;
                    int countCell = peno50hard.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = peno50hard[i, j];
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    int countRow = ppenokomplekthard.GetUpperBound(0) + 1;
                    int countCell = ppenokomplekthard.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = ppenokomplekthard[i, j];
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    int countRow = dozatronhard.GetUpperBound(0) + 1;
                    int countCell = dozatronhard.GetUpperBound(1) + 1;
                    dataGridView1.RowCount = countRow;
                    dataGridView1.Height = dataGridView1.Height + (22 * countRow);

                    int i, j;
                    for (i = 0; i < countRow; ++i)
                        for (j = 0; j < countCell; ++j)
                            dataGridView1.Rows[i].Cells[j].Value = dozatronhard[i, j];
                }
            }
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPress(e);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && textBox1.Text != "")
            {
                double countVoda = Convert.ToDouble(textBox1.Text.ToString().Replace('.', ','));
                double dh = 0;
                if (radioButton3.Checked)
                    dh = countVoda;
                else if (radioButton4.Checked)
                    dh = countVoda * 0.36;
                else if (radioButton5.Checked)
                    dh = countVoda * 0.019;
                label1.Text = dh.ToString();

                if (dh <= 3.5)
                    dH = "ligth";
                else if (dh<=7)
                    dH = "default";
                else if (dh > 7)
                    dH = "hard";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            double countVoda = Convert.ToDouble(textBox1.Text.ToString().Replace('.', ','));
            if (radioButton3.Checked)
            {
                double dh = 0;
                dh = countVoda;
                radioButton4.Checked = false;
                radioButton5.Checked = false;

                if (dh <= 3.5)
                    dH = "ligth";
                else if (dh <= 7)
                    dH = "default";
                else if (dh > 7)
                    dH = "hard";
                label1.Text = dh.ToString();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            double countVoda = Convert.ToDouble(textBox1.Text.ToString().Replace('.', ','));
            if (radioButton4.Checked)
            {
                double dh = 0;
                dh = countVoda * 0.36;
                radioButton3.Checked = false;
                radioButton5.Checked = false;

                if (dh <= 3.5)
                    dH = "ligth";
                else if (dh <= 7)
                    dH = "default";
                else if (dh > 7)
                    dH = "hard";
                label1.Text = dh.ToString();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            double countVoda = Convert.ToDouble(textBox1.Text.ToString().Replace('.', ','));
            if (radioButton5.Checked)
            {
                double dh = 0;
                dh = countVoda * 0.019;
                radioButton4.Checked = false;
                radioButton3.Checked = false;

                if (dh <= 3.5)
                    dH = "ligth";
                else if (dh <= 7)
                    dH = "default";
                else if (dh > 7)
                    dH = "hard";
                label1.Text = dh.ToString();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = 0;

            dataGridView2.Rows.Add(dataGridView1.Rows[rowIndex].Cells[columnIndex].Value, dataGridView1.Rows[rowIndex].Cells[columnIndex+1].Value, dataGridView1.Rows[rowIndex].Cells[columnIndex+2].Value);
            dataGridView2.Height += 22;
            button1.Location = new Point(button1.Location.X, button1.Location.Y + 22);
        

        countSravnenie += 1;
            {
                button1.Visible = true;
                label4.Visible = true;
                dataGridView2.Visible = true;
            }
            

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string s = dataGridView2.Rows[rowIndex].Cells[0].Value.ToString();
            if (s != "")
            {
                dataGridView2.Rows.RemoveAt(rowIndex);
                dataGridView2.Height -= 22;
                button1.Location = new Point(button1.Location.X, button1.Location.Y - 22);
            }
            countSravnenie -= 1;
            if (countSravnenie == 0)
            {
                dataGridView2.Visible = false;
                button1.Visible = false;
                label4.Visible = false;
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rows = dataGridView2.RowCount;
            int column = dataGridView2.ColumnCount;
            string[,] table = new string[rows-1,3];
            for(int i = 0; rows-1 > i; i++)
            {
                table[i, 0] = dataGridView2.Rows[i].Cells[0].Value.ToString();
                table[i, 1] = dataGridView2.Rows[i].Cells[1].Value.ToString();
                if (dataGridView2.Rows[i].Cells[2].Value == null)
                    table[i, 2] = "";
                else
                    table[i, 2] = dataGridView2.Rows[i].Cells[2].Value.ToString();

            }
            Form6 f6 = new Form6(table, dH);
            f6.ShowDialog();
        }
    }
}
