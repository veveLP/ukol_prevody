using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp55
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            /*Navrhněte metodu BinToDec s jedním parametrem typu string, která převede binární
            číslo ve tvaru řetězce znaků na číslo desítkové.
            Navrhněte metodu DecToBin s jedním parametrem typu celé číslo, která převede
            desítkové číslo na číslo binární ve tvaru řetězce znaků.
            Navrhněte metodu HexToDec s jedním parametrem typu String, která převede
            šestnáctkové číslo ve tvaru řetězce znaků na číslo desítkové.
            Navrhněte metodu DecToHex s jedním parametrem typu celé číslo, která převede
            desítkové číslo na číslo šestnáctkové ve tvaru řetězce znaků.
            Navrhněte metodu HexToBin s jedním parametrem typu String, která převede
            šestnáctkové číslo ve tvaru řetězce znaků na číslo binární ve tvaru řetězce znaků.
            Navrhněte metodu BinToHex s jedním parametrem typu String, která převede binární
            číslo ve tvaru řetězce znaků na číslo šestnáctkové ve tvaru řetězce znaků.
            Vytvořte program, který bude mít 3 TextBoxy, pro zápis čísla v dané soustavě
            (2,10,16). Uživatel zapíše číslo do jednoho z TexBoxů a do ostatních TexBoxů se číslo přepočítá.
            Do každého TextBoxu umožněte zapisovat pouze přípustné znaky dané soustavy.

            Odevzdejte odkaz na GitHub repozitář.*/
            InitializeComponent();
        }

        public string BinToDec(string txt)
        {
            if(txt == "") { return ""; }
            return Convert.ToInt64(txt, 2).ToString();
        }

        public string BinToHex(string txt)
        {
            return DecToHex(BinToDec(txt));
        }

        public string DecToBin(string txt) {
            long numb;
            try
            {
                numb = Int64.Parse(txt);
            }
            catch (Exception) { return ""; }
            return Convert.ToString(numb, 2); }

        public string DecToHex(string txt) {
            long numb;
            try
            {
                numb = Int64.Parse(txt);
            }
            catch (Exception) { return ""; }
            return numb.ToString("X"); }

        public string HexToDec(string txt)
        {
            if (txt == "") { return ""; }
            return Convert.ToInt64(txt, 16).ToString();
        }

        public string HexToBin(String txt)
        {
            if (txt == "") { return ""; }
            return DecToBin(HexToDec(txt));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = BinToDec(textBox1.Text);
            textBox3.Text = BinToHex(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = DecToBin(textBox2.Text);
            textBox3.Text = DecToHex(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = HexToDec(textBox3.Text);
            textBox1.Text = HexToBin(textBox3.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !("\b01".Contains(e.KeyChar));
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !("\b0123456789".Contains(e.KeyChar));
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !("\b0123456789ABCDEF".Contains(e.KeyChar));
        }
    }
}
