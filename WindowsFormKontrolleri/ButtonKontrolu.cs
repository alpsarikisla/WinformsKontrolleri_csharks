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
    public partial class ButtonKontrolu : Form
    {
        Label lbl_yazi;
        int xlocation;
        int ylocation;
        int sayi;
        public ButtonKontrolu()
        {
            InitializeComponent();
            sayi = 0;
            Button btn_tikla = new Button();
            btn_tikla.Text = "Tıkla";
            btn_tikla.Location = new Point(10, 40);
            //Delegate Oluşturma
            //Delegate Olayın gerçekleştiği anda çalışacak olan metodu adresler
            btn_tikla.Click += murtaza_Click;
            this.Controls.Add(btn_tikla);
            lbl_yazi = new Label();
            xlocation = 10;
            ylocation = 70;
            lbl_yazi.Location = new Point(xlocation,ylocation);
            lbl_yazi.AutoSize = true;
            lbl_yazi.Text = "*";
            this.Controls.Add(lbl_yazi);
        }

        private void murtaza_Click(object sender, EventArgs e)
        {
            //int xlocation = lbl_yazi.Location.X;
            //int ylocation = lbl_yazi.Location.Y;
            xlocation += 10;
            lbl_yazi.Location = new Point(xlocation, ylocation);
            //lbl_yazi.Text = "Merhaba buton ile label degistirildi";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void btn_kurabiye_Click(object sender, EventArgs e)
        {
            sayi++;
            //lbl_sayac.Text = Convert.ToString(sayi);
            lbl_sayac.Text = sayi.ToString();
        }
    }
}
