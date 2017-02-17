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
    public partial class Vortex : Form
    {
        public Vortex()
        {
            InitializeComponent();
        }

        private void Vortex_Load(object sender, EventArgs e)
        {
            label1.Text = "Здесь небольшое описание отрасли или продуктов если конечно это необходимо\nМожно вставить картинки по желанию";
            label2.Text = "Здесь небольшое описание отрасли или продуктов если конечно это необходимо\nМожно вставить картинки по желанию";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Vortex_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void каталогПродуктовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Spravka spravka = new Spravka();
            spravka.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Klining klining = new Klining();
            klining.Show();
        }
    }
}
