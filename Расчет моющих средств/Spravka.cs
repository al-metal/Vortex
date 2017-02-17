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
    public partial class Spravka : Form
    {
        public Spravka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Spravka_Load(object sender, EventArgs e)
        {
            Image img = Image.FromFile("avto/ace.jpg");
            pictureBox1.Image = img;
            img = Image.FromFile("avto/apex-10.jpg");
            pictureBox2.Image = img;
            img = Image.FromFile("avto/debug_5.jpg");
            pictureBox3.Image = img;
            img = Image.FromFile("avto/delicate_5.jpg");
            pictureBox4.Image = img;
            img = Image.FromFile("avto/DIY.jpg");
            pictureBox5.Image = img;


            img = Image.FromFile("apk/algalit.jpg");
            pictureBox10.Image = img;
            img = Image.FromFile("apk/algavit_25.jpg");
            pictureBox9.Image = img;
            img = Image.FromFile("apk/biotec.jpg");
            pictureBox8.Image = img;
            img = Image.FromFile("apk/desimix.jpg");
            pictureBox7.Image = img;
            img = Image.FromFile("apk/desitub.jpg");
            pictureBox6.Image = img;


            img = Image.FromFile("klining/antistick_0.5 (1).jpg");
            pictureBox15.Image = img;
            img = Image.FromFile("klining/blank_1.jpg");
            pictureBox14.Image = img;
            img = Image.FromFile("klining/breez_0.5.jpg");
            pictureBox13.Image = img;
            img = Image.FromFile("klining/comfort_1.jpg");
            pictureBox12.Image = img;
            img = Image.FromFile("klining/daze_0.5.jpg");
            pictureBox11.Image = img;


            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 5000;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.pictureBox1, "Высококонцентрированное средство для бесконтактной мойки класс суперпремиум, для воды высокой жесткости");
            toolTip1.SetToolTip(this.pictureBox2, "Жидкость незамерзающая для стеклоомывателей");
            toolTip1.SetToolTip(this.pictureBox3, "Средство для удаления мошек, тополиных почек, смол деревьев");
            toolTip1.SetToolTip(this.pictureBox4, "Концентрированное слабощелочное средство для профессиональной деликатной мойки автотранспорта");
            toolTip1.SetToolTip(this.pictureBox5, "Высокопенное средство для бесконтактной мойки автомобиля на мойках самообслуживания");
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Высококонцентрированное средство для бесконтактной мойки класс суперпремиум, для воды высокой жесткости", "ACE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox15.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox14.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox13.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox12.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox11.Image);
            imgForm.ShowDialog();
        }

        private void Spravka_FormClosing(object sender, FormClosingEventArgs e)
        {
            Vortex vortex = new Vortex();
            vortex.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox10.Image);
            imgForm.ShowDialog();
        }
    }
}
