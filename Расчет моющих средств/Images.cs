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
    public partial class Images : Form
    {
        Image img;
        
        public Images(Image img)
        {
            InitializeComponent();
            this.img = img;
        }

        private void Images_Load(object sender, EventArgs e)
        {
            Size sz = img.Size;
            pictureBox1.Image = img;
            sz = new Size(sz.Width, sz.Height + 40);
            this.Size = sz;
            this.MaximumSize = sz;
            this.MinimumSize = sz;
        }
    }
}
