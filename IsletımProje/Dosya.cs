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
    public partial class Dosya : Form
    {
        public Dosya()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    Sıkıstırma(openFileDialog1.FileName, saveFileDialog1.FileName);

            }
        }
        void Sıkıstırma(string yol, string kaydedilecekYer)
        {
            FileStream sıkıstırılacakdosya = new FileStream(yol,FileMode.Open,FileAccess.Read);
            byte[] veriler =new byte[sıkıstırılacakdosya.Length];
            sıkıstırılacakdosya.Read(veriler,0,veriler.Length);
            sıkıstırılacakdosya.Close();
            FileStream KaydedilecekYer = new FileStream(kaydedilecekYer , FileMode.Create, FileAccess.Write);
            GZipStream sıkıstırma = new GZipStream(KaydedilecekYer,CompressionMode.Compress);
            sıkıstırma.Write(veriler, 0, veriler.Length);
            sıkıstırma.Close();
 
           

        }

        void Acma(string yol, string kaydedilecekYer)
        {
            FileStream sıkıstırılmısdosya = new FileStream(yol, FileMode.Open, FileAccess.Read);
            GZipStream acma = new GZipStream(sıkıstırılmısdosya, CompressionMode.Decompress);
            byte[] veriler = new byte[9999999];
           int uzunluk= acma.Read(veriler, 0, veriler.Length);
           acma.Close();
           byte[] yazılacak = new byte[uzunluk];
           Array.Copy(veriler,yazılacak, yazılacak.Length);
           FileStream kaydetme = new FileStream(kaydedilecekYer, FileMode.Create, FileAccess.Write);
           kaydetme.Write(yazılacak, 0, yazılacak.Length);
           kaydetme.Close();

       
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    Sıkıstırma(openFileDialog1.FileName, saveFileDialog1.FileName);

            }
        }

    }
}
