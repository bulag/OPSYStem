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
    public partial class Klavye : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                    param.ExStyle |= 0x08000000;
                    return param;
            }
        }
        public Klavye()
        {
            InitializeComponent();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{1}");
        }

        private void qbtn_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("Q");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("q");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked ||checkBox5.Checked)
            {
                SendKeys.Send("W");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("w");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("E");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("e");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("R");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("r");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("T");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("t");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("Y");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("y");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("U");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("u");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("I");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("ı");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("O");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("o");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("P");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("p");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("A");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("a");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("S");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("s");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("D");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("d");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("F");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("f");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("G");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("g");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("H");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("h");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("J");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("j");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("K");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("k");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("L");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("l");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("Z");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("z");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("X");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("x");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("C");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("c");
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("V");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("v");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("B");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("b");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("N");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("n");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("M");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("m");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{{}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("[");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{}}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                SendKeys.Send("]");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{@}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{'}");
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{_}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{-}");
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{+}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{=}");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{~}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{#}");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{<}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{,}");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{>}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{.}");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{?}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{/}");
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{)}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{0}");
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{(}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{9}");
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{+}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{8}");
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{7}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{7}");
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{^}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{6}");
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{%}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{5}");
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{$}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{4}");
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{€}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{3}");
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("2");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{2}");
            }
}

        private void button55_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{!}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{1}");
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Tab}");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{Control}");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{}");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Alt}");
        }

      /*  private void button41_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{SPACE}");
        }*/

        private void button40_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Alt}");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Left}");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{CTRL}");
        }

        private void button56_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void button62_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void button61_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{END}");
        }

        private void button65_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{7}");
        }

        private void button64_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{8}");
        }

        private void button63_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{9}");
        }

        private void button69_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{4}");
        }

        private void button68_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{5}");
        }

        private void button67_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{6}");
        }

        private void button72_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{2}");
        }

        private void button71_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{3}");
        }

        private void button77_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{Insert}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{0}");
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{/}");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{*}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void button91_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PRTSC}");
        }

        private void button87_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F1}");
        }

        private void button86_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
        }

        private void button85_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F3}");
        }

        private void button84_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
        }

        private void button83_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F5}");
        }

        private void button82_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F6}");
        }

        private void button81_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F7}");
        }

        private void button80_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F8}");
        }

        private void button79_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F9}");
        }

        private void button78_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F10}");
        }

        private void button75_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F11}");
        }

        private void button74_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F12}");
        }

        private void button90_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{SCROLLLOCK}");
        }

        private void button89_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGUP}");
        }

        private void button88_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{PGDN}");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked || checkBox5.Checked)
            {
                SendKeys.Send("{|}");
                checkBox2.Checked = false;
                checkBox5.Checked = false;
            }

            else
            {
                SendKeys.Send("{U+005C}");
            }

        }

        private void button58_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DEL}");
        }

        private void button76_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DEL}");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{NumLock}");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Up}");
        }

        private void button70_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Down}");
        }

        private void button66_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{Right}");
        }
        
}
}
