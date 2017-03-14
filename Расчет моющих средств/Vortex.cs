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
            label1.Text = "ТМ Vortex – моющие средства для АПК. Ассортиментная линейка разработана таким образом,\n чтобы гарантировать всеобъемлющую систему управления гигиеной на молочной\n ферме от подготовки к доению до промывки доильного оборудования, молокопроводов и\n танков-охладителей.";
            label2.Text = "ТМ Complex – автохимия и все для автомойки. В линейке широкий спектр бесконтактных и\n ручных шампуней, средств специального назначения, полочных продуктов для розничной\n продажи, продуктов европейской Наномойки и зимней серии.";
            label3.Text = "ТМ Tank – моющие и дезинфицирующие средства для предприятий пищевой и\n перерабатывающей промышленности. Сфера пищевой промышленности охватывает\n первичную переработку пищевых продуктов, а также более сложные процессы производства\n полуфабрикатов и готовой к употреблению пищи. Все продукты сертифицированы, имеют\n соответствующие разрешения и рекомендации к применению. ";
            label4.Text = "ТМ CleanBox – серия профессиональных моющих средств для клининга. В линейку вошли\n самые популярные и востребованные продукты. Все средства прошли массовые испытания\n и получили высокую оценку среди профессиональных клинеров индустрии чистоты. ";
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

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
