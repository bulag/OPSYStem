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
    public partial class KapatAc : Form
    {
        public KapatAc()
        {
            InitializeComponent();
            TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult soru;
            soru = MessageBox.Show("Bilgisayar Kapatılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "-s");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Bilgisayar Yeniden Başlatılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "-r");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("Bilgisayar Uyku Moduna Getirilsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "-h");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zaman zmn = new Zaman();
            zmn.Show();
        }
    }
}
