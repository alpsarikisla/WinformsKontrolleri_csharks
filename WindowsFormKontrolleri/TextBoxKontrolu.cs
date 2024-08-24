using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormKontrolleri
{
    public partial class TextBoxKontrolu : Form
    {
    
        public TextBoxKontrolu()
        {
            InitializeComponent();
            
        }

        private void btn_sifregoster_Click(object sender, EventArgs e)
        {
            bool durum = tb_sifre.UseSystemPasswordChar;
            if (durum)
            {
                //btn_sifregoster.Text = "Gizle";
                Image img = Image.FromFile("../../Resimler/eye2.png");
                btn_sifregoster.Image = img;
                tb_sifre.UseSystemPasswordChar = false;
            }
            else
            {
                Image img = Image.FromFile("../../Resimler/noteye2.png");
                btn_sifregoster.Image = img;
                //btn_sifregoster.Text = "Göster";
                tb_sifre.UseSystemPasswordChar = true;
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int sayi = tb_olay.Text.Length;
            lbl_karaktersayi.Text = "Kalan Karakter = " + (10 - sayi);
        }
    }
}
