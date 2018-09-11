using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            /* burda int tipi sayi değişkenine int.parse() fonksiyonu ile textbox1'în textini sayıya çevirerek aldık...  */

            switch (sayi)
            {
                case 0:
                    MessageBox.Show("Girdiğiniz Sayı Sıfır'dır...", "Uyarı");
                    break;
                case 1:
                    MessageBox.Show("Girdiğiniz Sayı Bir'dir...", "Uyarı");
                    break;
                case 2:
                    MessageBox.Show("Girdiğiniz Sayı İki'dir...", "Uyarı");
                    break;
                case 3:
                    MessageBox.Show("Girdiğiniz Sayı Üç'tür...", "Uyarı");
                    break;
                case 4:
                    MessageBox.Show("Girdiğiniz Sayı Dört'tür...", "Uyarı");
                    break;
                case 5:
                    MessageBox.Show("Girdiğiniz Sayı Beş'dir...", "Uyarı");
                    break;
                case 6:
                    MessageBox.Show("Girdiğiniz Sayı Altı'dır...", "Uyarı");
                    break;
                case 7:
                    MessageBox.Show("Girdiğiniz Sayı Yedi'dir...", "Uyarı");
                    break;
                case 8:
                    MessageBox.Show("Girdiğiniz Sayı Sekiz'dir...", "Uyarı");
                    break;
                case 9: 
                    MessageBox.Show("Girdiğiniz Sayı Dokuz'dir...", "Uyarı");
                    break;
                default:
                    MessageBox.Show("Girilen Değer Bir Rakam Değildir!", "Uyarı");
                    break;
            }
        }
    }
}
