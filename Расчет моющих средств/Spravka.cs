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
            #region Автохимия
            Image img = Image.FromFile("avto/ace.jpg");
            pictureBox5.Image = img;
            img = Image.FromFile("avto/apex-10.jpg");
            pictureBox11.Image = img;
            img = Image.FromFile("avto/debug_5.jpg");
            pictureBox12.Image = img;
            img = Image.FromFile("avto/defstroy.jpg");
            pictureBox13.Image = img;
            img = Image.FromFile("avto/delicate_5.jpg");
            pictureBox14.Image = img;
            img = Image.FromFile("avto/DIY.jpg");
            pictureBox15.Image = img;
            img = Image.FromFile("avto/dozex.jpg");
            pictureBox4.Image = img;
            img = Image.FromFile("avto/guru.jpg");
            pictureBox3.Image = img;
            img = Image.FromFile("avto/hands_5.jpg");
            pictureBox31.Image = img;
            img = Image.FromFile("avto/hands_nm.jpg");
            pictureBox35.Image = img;
            img = Image.FromFile("avto/hands-shine_5.jpg");
            pictureBox36.Image = img;
            img = Image.FromFile("avto/loco.jpg");
            pictureBox37.Image = img;
            img = Image.FromFile("avto/magnat.jpg");
            pictureBox2.Image = img;
            img = Image.FromFile("avto/master.jpg");
            pictureBox1.Image = img;
            img = Image.FromFile("avto/master-tone.jpg");
            pictureBox38.Image = img;
            img = Image.FromFile("avto/mobile.jpg");
            pictureBox39.Image = img;
            img = Image.FromFile("avto/nanex.jpg");
            pictureBox40.Image = img;
            //img = Image.FromFile("");
            //pictureBox41.Image = img;
            //img = Image.FromFile("");
            //pictureBox42.Image = img;
            img = Image.FromFile("avto/novice_5.jpg");
            pictureBox43.Image = img;
            img = Image.FromFile("avto/orbis_5.jpg");
            pictureBox44.Image = img;
            img = Image.FromFile("avto/politura_5.jpg");
            pictureBox45.Image = img;
            img = Image.FromFile("avto/politura-gloss_5.jpg");
            pictureBox46.Image = img;
            img = Image.FromFile("avto/profy.jpg");
            pictureBox111.Image = img;
            img = Image.FromFile("avto/propella_5.jpg");
            pictureBox108.Image = img;
            img = Image.FromFile("avto/rotae_5.jpg");
            pictureBox109.Image = img;
            img = Image.FromFile("avto/rotaevis_5.jpg");
            pictureBox110.Image = img;
            //img = Image.FromFile("");
            //pictureBox107.Image = img;
            img = Image.FromFile("avto/senza.jpg");
            pictureBox106.Image = img;
            img = Image.FromFile("avto/silicone_5.jpg");
            pictureBox105.Image = img;
            img = Image.FromFile("avto/solo.jpg");
            pictureBox103.Image = img;
            img = Image.FromFile("avto/tantum.jpg");
            pictureBox104.Image = img;
            img = Image.FromFile("avto/tiro.jpg");
            pictureBox102.Image = img;
            img = Image.FromFile("avto/tiro-tone.jpg");
            pictureBox99.Image = img;
            img = Image.FromFile("avto/tutela_cherry.jpg");
            pictureBox100.Image = img;
            img = Image.FromFile("avto/tutela-fast_5.jpg");
            pictureBox101.Image = img;
            img = Image.FromFile("avto/tutor.jpg");
            pictureBox98.Image = img;
            img = Image.FromFile("avto/twin.jpg");
            pictureBox97.Image = img;
            img = Image.FromFile("avto/unior.jpg");
            pictureBox96.Image = img;
            img = Image.FromFile("avto/witrum_5.jpg");
            pictureBox93.Image = img;
            //img = Image.FromFile("");
            //pictureBox94.Image = img;

            #endregion
            
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
            img = Image.FromFile("apk/somatest.jpg");
            pictureBox33.Image = img;
            img = Image.FromFile("apk/violit.jpg");
            pictureBox32.Image = img;

            #endregion

            #region Пищепром

            img = Image.FromFile("pishe/CA_27.jpg");
            pictureBox74.Image = img;
            img = Image.FromFile("pishe/CAD_1415_3.jpg");
            pictureBox75.Image = img;
            img = Image.FromFile("pishe/CB_23.jpg");
            pictureBox76.Image = img;
            img = Image.FromFile("pishe/CB_46.jpg");
            pictureBox77.Image = img;
            img = Image.FromFile("pishe/CBD_2401_1.jpg");
            pictureBox78.Image = img;
            img = Image.FromFile("pishe/FA_18.jpg");
            pictureBox79.Image = img;
            img = Image.FromFile("pishe/FB_17.jpg");
            pictureBox73.Image = img;
            img = Image.FromFile("pishe/FB_36.jpg");
            pictureBox72.Image = img;
            img = Image.FromFile("pishe/FBD_0402_1.jpg");
            pictureBox80.Image = img;
            img = Image.FromFile("pishe/FBD_0803_1.jpg");
            pictureBox81.Image = img;
            img = Image.FromFile("pishe/FBD_0902_2.jpg");
            pictureBox82.Image = img;
            img = Image.FromFile("pishe/FN.jpg");
            pictureBox83.Image = img;
            img = Image.FromFile("pishe/LBD_0107_1.jpg");
            pictureBox71.Image = img;
            img = Image.FromFile("pishe/LBD_1002_2.jpg");
            pictureBox70.Image = img;

            #endregion

            #region Клининг

            img = Image.FromFile("klining/antistick_0.5 (1).jpg");
            pictureBox51.Image = img;
            img = Image.FromFile("klining/blank_1.jpg");
            pictureBox52.Image = img;
            //img = Image.FromFile("klining/breez_0.5.jpg");
            //pictureBox53.Image = img;
            img = Image.FromFile("klining/breez_0.5.jpg");
            pictureBox54.Image = img;
            img = Image.FromFile("klining/comfort_1.jpg");
            pictureBox55.Image = img;
            img = Image.FromFile("klining/comfort_extra_1.jpg");
            pictureBox56.Image = img;
            img = Image.FromFile("klining/daze_0.5.jpg");
            pictureBox50.Image = img;
            img = Image.FromFile("klining/deblank_1.jpg");
            pictureBox49.Image = img;
            img = Image.FromFile("klining/destroy_1.jpg");
            pictureBox57.Image = img;
            img = Image.FromFile("klining/draft_1.jpg");
            pictureBox58.Image = img;
            img = Image.FromFile("klining/fay_5.jpg");
            pictureBox59.Image = img;
            //img = Image.FromFile("klining/blank_1.jpg");
            //pictureBox60.Image = img;
            img = Image.FromFile("klining/fortis_1.jpg");
            pictureBox48.Image = img;
            img = Image.FromFile("klining/fumigel_1.jpg");
            pictureBox47.Image = img;
            img = Image.FromFile("klining/joy_orange_1_pet.jpg");
            pictureBox61.Image = img;
            img = Image.FromFile("klining/joy_platinum_1_pet.jpg");
            pictureBox62.Image = img;
            img = Image.FromFile("klining/joy_sept_tea_pet.jpg");
            pictureBox63.Image = img;
            img = Image.FromFile("klining/kraft05.jpg");
            pictureBox64.Image = img;
            img = Image.FromFile("klining/magic_0.5.jpg");
            pictureBox65.Image = img;
            img = Image.FromFile("klining/marvel_lemon_1_pet.jpg");
            pictureBox66.Image = img;
            img = Image.FromFile("klining/novatec_1.jpg");
            pictureBox67.Image = img;
            img = Image.FromFile("klining/novatec foam_1.jpg");
            pictureBox68.Image = img;
            img = Image.FromFile("klining/optima.jpg");
            pictureBox69.Image = img;
            img = Image.FromFile("klining/optima-gel.jpg");
            pictureBox95.Image = img;
            img = Image.FromFile("klining/twist05.jpg");
            pictureBox112.Image = img;
            img = Image.FromFile("klining/well05.jpg");
            pictureBox113.Image = img;

            #endregion
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

        #region Увеличение картинок автохимия

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox5.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox11.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox12.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox13.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox14.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox15.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox4.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox3.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox31.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox35.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox36.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox37.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox2.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox1.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox38.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox39.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox40.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox41.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox42.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox43.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox44.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox45.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox46.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox111_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox111.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox108_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox108.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox109_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox109.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox110_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox110.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox107_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox107.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox106_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox106.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox105_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox105.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox103_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox103.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox104_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox104.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox102_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox102.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox99_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox99.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox100_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox100.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox101_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox101.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox98_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox98.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox97_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox97.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox96_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox96.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox93_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox93.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox94_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox94.Image);
            imgForm.ShowDialog();
        }

        #endregion

        #region Увеличение картинок пищепром
        
        private void pictureBox74_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox74.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox75.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox76.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox77.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox78.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox79.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox73.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox72.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox80_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox80.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox81.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox82_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox82.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox83_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox83.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox71.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox70.Image);
            imgForm.ShowDialog();
        }
        #endregion

        #region Увеличение картинок клининг

        private void pictureBox51_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox51.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox52.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox53.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox54.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox55.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox56.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox50.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox49.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox57.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox58.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox59.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox60.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox48.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox47.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox61.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox62.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox63.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox64.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox65.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox66.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox67.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox68.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox69.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox95_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox95.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox112_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox112.Image);
            imgForm.ShowDialog();
        }

        private void pictureBox113_Click(object sender, EventArgs e)
        {
            Images imgForm = new Images(pictureBox113.Image);
            imgForm.ShowDialog();
        }
#endregion
    }
}
