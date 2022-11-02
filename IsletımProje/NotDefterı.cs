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
    public partial class NotDefterı : Form
    {
        public NotDefterı()
        {
            InitializeComponent();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();

        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.Font = fontDialog1.Font;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void yazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                this.Text = saveFileDialog1.FileName;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void NotDefterı_Load(object sender, EventArgs e)
        {

        }
    }
}
