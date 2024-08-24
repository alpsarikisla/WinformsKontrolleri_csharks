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
    public partial class MaskedTextBoxKontrolu : Form
    {
        public MaskedTextBoxKontrolu()
        {
            InitializeComponent();
        }

        private void btn_Goster_Click(object sender, EventArgs e)
        {
            lbl_telefon.Text = mtb_telefon.Text;
            lbl_kimlik.Text = mtb_kimlik.Text;
            lbl_iban.Text = mtb_iban.Text;
        }
    }
}
