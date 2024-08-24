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
    public partial class LabelKontrolu : Form
    {
        public LabelKontrolu()
        {
            InitializeComponent();

            //Unutulmamalıdır ki .net içerisinde kullanılan her eleman bir sınıftır.
            Label lbl_isim = new Label();
            lbl_isim.Text = "Ben bir label'ım. Valla!!!";
            //lbl_isim.Size = new Size(200, 50);
            lbl_isim.AutoSize = true;//içindeki metine göre label'ın boyutunu ayarlar
            lbl_isim.Location = new Point(10, 10);
            this.Controls.Add(lbl_isim);

            Label lbl_soyisim = new Label();
            lbl_soyisim.Text = "Soyisim = Sarıkışla";
            lbl_soyisim.AutoSize = true;
            lbl_soyisim.Location = new Point(10, 40);
            this.Controls.Add(lbl_soyisim);

            Font fnt = new Font("Calibri", 15, FontStyle.Bold);
            lbl_kodIleFont.Font = fnt;
            lbl_kodIleFont.ForeColor = Color.White;
            lbl_kodIleFont.BackColor = Color.OrangeRed;
            

        }

       
    }
}
