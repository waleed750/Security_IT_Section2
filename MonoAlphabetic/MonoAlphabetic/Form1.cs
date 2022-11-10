using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonoAlphabetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string randomAlhapet()
        {
            var chars = "abcdefghijklmnopqrstuvwxyz".ToUpper();
            //var stringChars = new char[26];
            var random = new Random();
            
            var stringChars = chars.OrderBy(x => random.Next()).ToArray();


            return new String(stringChars);
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            var newAlpha = randomAlhapet();
            textBox3.Text = newAlpha;
        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            var newAplha = textBox3.Text;
            var aplha = "abcdefghijklmnopqrstuvwxyz".ToUpper();
            var plain = plainText.Text.ToUpper();
            var encryptedText = "";

            for (int i = 0; i < plain.Length; i++)
            {
                var index = aplha.IndexOf(plain[i]);

                encryptedText += newAplha[index]; 
            }
            result.Text = encryptedText;
        }

        private void decry_Click(object sender, EventArgs e)
        {
            var newAplha = textBox3.Text;
            var aplha = "abcdefghijklmnopqrstuvwxyz".ToUpper();
            var plain = plainText.Text.ToUpper();
            var decryptedText = "";
            for (int i = 0; i < plain.Length; i++)
            {
                var index = newAplha.IndexOf(plain[i]);

                decryptedText += aplha[index];
            }
            result.Text = decryptedText;
        }
    }
}
