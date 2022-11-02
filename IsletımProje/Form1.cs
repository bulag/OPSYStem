using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace IsletımProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KapatAc ka = new KapatAc();
            ka.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EkranÇözünürlüğü ec = new EkranÇözünürlüğü();
            ec.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*Dosya ds = new Dosya();
            ds.Show();
            this.Hide();*/
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    Sıkıstırma(openFileDialog1.FileName, saveFileDialog1.FileName);

            }

        }
        void Sıkıstırma(string yol, string kaydedilecekYer)
        {
            FileStream sıkıstırılacakdosya = new FileStream(yol, FileMode.Open, FileAccess.Read);
            byte[] veriler = new byte[sıkıstırılacakdosya.Length];
            sıkıstırılacakdosya.Read(veriler, 0, veriler.Length);
            sıkıstırılacakdosya.Close();
            FileStream KaydedilecekYer = new FileStream(kaydedilecekYer, FileMode.Create, FileAccess.Write);
            GZipStream sıkıstırma = new GZipStream(KaydedilecekYer, CompressionMode.Compress);
            sıkıstırma.Write(veriler, 0, veriler.Length);
            sıkıstırma.Close();



        }

        private void button8_Click(object sender, EventArgs e)
        {
            EkranGoruntusuAlma eal = new EkranGoruntusuAlma();
            eal.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NotDefterı nd = new NotDefterı();
            nd.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Klavye kl = new Klavye();
            kl.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
