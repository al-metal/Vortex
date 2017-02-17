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
    public partial class Klining : Form
    {
        #region Поверхность
        string[] kuh = new string[14]
        {
            "Посуда, противни, сковороды" ,
            "Посудомоечная машина" ,
            "Холодильник" ,
            "Вытяжка" ,
            "Плита, гриль, духовка",
            "Микроволновая печь",
            "Столовые приборы",
            "Моечная ванна" ,
            "Общая дезинфекция" ,
            "Рабочие столы и поверхности",
            "Мойка и чистка" ,
            "Трубы" ,
            "Устранение запахов" ,
            "Гигиена рук"
        };

        #endregion

        #region Проблема
        string[] kuhPosuda = new string[3]
        {
            "Для замачивания" ,
            "Против гари и копоти" ,
            "Для отбеливания и дезинфекции"
        };

        #endregion

        #region Средства
        string[] kuhPosudaZamach = new string[2]
        {
            "Marvel" ,
            "Optima Gel"
        };

        #endregion

        public Klining()
        {
            InitializeComponent();
        }

        private void Klining_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vortex vortex = new Vortex();
            vortex.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int combobox1item = 0;
            comboBox2.Enabled = true;
            if (comboBox1.SelectedIndex == 0)
            {
                ItemsAddCB2(kuh);
                combobox1item = 0;
            }
            else if (comboBox1.SelectedIndex == 1)
            {

            }
            else if (comboBox1.SelectedIndex == 2)
            {

            }
            else if (comboBox1.SelectedIndex == 3)
            {

            }
            else if (comboBox1.SelectedIndex == 4)
            {

            }
            else if (comboBox1.SelectedIndex == 5)
            {

            }
        }

        private void ItemsAddCB2(string[] array)
        {
            foreach (string str in array)
                comboBox2.Items.Add(str);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0)
            {
                ItemsAddCB3(kuhPosuda);
            }
        }

        private void ItemsAddCB3(string[] array)
        {
            foreach (string str in array)
                comboBox3.Items.Add(str);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 0 && comboBox3.SelectedIndex == 0)
            {
                ResultShow(kuhPosudaZamach);
            }
        }

        private void ResultShow(string[] array)
        {
            foreach (string str in array)
                textBox1.AppendText(str + "\n");
        }
    }
    }
