using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szyfrowanie
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ROT13(textBox2.Text);
        }

        
        public string ROT13(string input)
        {
            StringBuilder wynik = new StringBuilder();
            Regex regex = new Regex("[A-Za-z]");
            foreach (char c in input)
            {
                if (regex.IsMatch(c.ToString()))
                {
                    int kod = ((c & 223) - 52) % 26 + (c & 32) + 65;
                    wynik.Append((char)kod);
                }
                else
                    wynik.Append(c);
            }
            return wynik.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = ROT13(textBox1.Text);
        }

       
    }
}
