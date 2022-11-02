using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace IsletımProje
{
    public partial class EkranGoruntusuAlma : Form
    {
        public EkranGoruntusuAlma()
        {
            InitializeComponent();
        }

        Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        private void button1_Click(object sender, EventArgs e)
        {
           
            EkranGoruntusuAlma.ActiveForm.Opacity = 0;
            Graphics gs = Graphics.FromImage(bitmap as Image);
            gs.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
            pictureBox1.Image = bitmap;
            EkranGoruntusuAlma.ActiveForm.Opacity = 100;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            bitmap.Save(saveFileDialog1.FileName.ToString());
        }

        public  Image img;
        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.image;//Kütüphaneden ilk resmi çektik.
            img = Properties.Resources.image;//img değişkenini değiştirip ilk resim yapıyor.
        }

        private void EkranGoruntusuAlma_Load(object sender, EventArgs e)
        {

        }
    }
}
