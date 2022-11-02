using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsletımProje
{
    public partial class Zaman : Form
    {
        TimeSpan ts;
        public Zaman()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ts.Hours >= 0 && ts.Minutes >= 0  && ts.Seconds > 0)
            {
                ts = ts.Subtract(new TimeSpan(0, 0, 1));
                label5.Text = ts.Hours + " : " + ts.Minutes + " : " + ts.Seconds;

            }
            else
            {
                timer1.Enabled = false;
                aktifYap(true);
                label5.Text = ts.Hours + " : " + ts.Minutes + " : " + ts.Seconds;
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        MessageBox.Show("Bekleme");
                        System.Diagnostics.Process.Start("shutdown", "/f /h");
                        break;
                    case 1:
                        MessageBox.Show("Yeniden Başlat");
                        System.Diagnostics.Process.Start("shutdown", "/f /r");
                        break;
                    case 2:
                        MessageBox.Show("Bilgisayarı Kapat");
                        System.Diagnostics.Process.Start("shutdown", "/f /s");
                        break;

                }
                MessageBox.Show("Süreniz Tamamlandı");
                
            }
        }

    /*    private void button1_Click(object sender, EventArgs e)
        {
            ts = new TimeSpan(Convert.ToInt32(textBox1.Text),
                             Convert.ToInt32(textBox2.Text),
                             Convert.ToInt32(textBox3.Text));
            aktifYap(false);
            timer1.Enabled = true;
        }
        */
     /*   private void button2_Click(object sender, EventArgs e)
        {
            ts = new TimeSpan(0,0,0);
            label5.Text = ts.Hours + " : " + ts.Minutes + " : " + ts.Seconds;
            aktifYap(true);
            timer1.Enabled = false;
        }
        */
        private void Zaman_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
/// <summary>
/// Eğer true ise form değerleri değiştirilebilir false ise değiştirilemez.
/// ekrandakiler aktif ya da pasif olacak.
/// </summary>
/// <param name="b"></param>
        void aktifYap(bool b)
        {
            if (b == true)
            {
                textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = button1.Enabled = true;
                button2.Enabled = false;
            }
            else
            {
                textBox1.Enabled = textBox2.Enabled = textBox3.Enabled = button1.Enabled = false;
                button2.Enabled = true;

            }
        }
        #region textlere Tıklama olayı
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.SelectAll();
        }
        #endregion

        private void button1_Click_1(object sender, EventArgs e)
        {
            ts = new TimeSpan(Convert.ToInt32(textBox1.Text),
                            Convert.ToInt32(textBox2.Text),
                            Convert.ToInt32(textBox3.Text));
            aktifYap(false);
            timer1.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ts = new TimeSpan(0, 0, 0);
            label5.Text = ts.Hours + " : " + ts.Minutes + " : " + ts.Seconds;
            aktifYap(true);
            timer1.Enabled = false;
        }
    }
}
