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

            #region Отображение картинок АПК

            img = Image.FromFile("apk/algalit.jpg");
            pictureBox10.Image = img;
            img = Image.FromFile("apk/algalit_50.jpg");
            pictureBox16.Image = img;
            img = Image.FromFile("apk/algavit_25.jpg");
            pictureBox7.Image = img;
            img = Image.FromFile("apk/algavit_50.jpg");
            pictureBox6.Image = img;
            img = Image.FromFile("apk/biotec.jpg");
            pictureBox9.Image = img;
            img = Image.FromFile("apk/biotec-m.jpg");
            pictureBox8.Image = img;
            img = Image.FromFile("apk/biotec-c.jpg");
            pictureBox18.Image = img;
            img = Image.FromFile("apk/biotec-super.jpg");
            pictureBox17.Image = img;
            img = Image.FromFile("apk/desimix.jpg");
            pictureBox20.Image = img;
            img = Image.FromFile("apk/desitub.jpg");
            pictureBox19.Image = img;
            img = Image.FromFile("apk/ecovit.jpg");
            pictureBox30.Image = img;
            img = Image.FromFile("apk/elovit.jpg");
            pictureBox29.Image = img;
            img = Image.FromFile("apk/fitolit.jpg");
            pictureBox28.Image = img;
            img = Image.FromFile("apk/forbicid.jpg");
            pictureBox27.Image = img;
            img = Image.FromFile("apk/kliovit.jpg");
            pictureBox26.Image = img;
            img = Image.FromFile("apk/ksilan.jpg");
            pictureBox25.Image = img;
            img = Image.FromFile("apk/ksilan-k.jpg");
            pictureBox24.Image = img;
            img = Image.FromFile("apk/ksilan-m.jpg");
            pictureBox23.Image = img;
            img = Image.FromFile("apk/ksilan-super.jpg");
            pictureBox22.Image = img;
            img = Image.FromFile("apk/lactovit.jpg");
            pictureBox21.Image = img;
            img = Image.FromFile("apk/priolit.jpg");
            pictureBox34.Image = img;
            img = Image.FromFile("apk/violit.jpg");
            pictureBox33.Image = img;
            img = Image.FromFile("apk/desimix.jpg");
            pictureBox32.Image = img;

            #endregion


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

        #region Увеличение картинок АПК
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox10.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox16.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox7.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox6.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox9.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox8.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox18.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox17.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox20.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox19.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox30.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox29.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox28.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox27.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox26.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox25.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox24.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox23.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox22.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox21.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox34.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox33.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox32.Image);
            imgForm.ShowDialog();
        }

        #endregion
    }
}
