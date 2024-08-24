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
    public partial class TakvimKontrolleri : Form
    {
        public TakvimKontrolleri()
        {
            InitializeComponent();
        }

        private void TakvimKontrolleri_Load(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Now;
            lbl_tarih.Text = tarih.ToString();
            lbl_kisaTarih.Text = tarih.ToShortDateString() + "      Saat = " + tarih.ToShortTimeString();
            lbl_uzunTarih.Text = tarih.ToLongDateString() + "       Saat = " + tarih.ToLongTimeString();

            lbl_yil.Text = tarih.Year.ToString();
            lbl_ay.Text = tarih.Month.ToString();
            lbl_gun.Text = tarih.Day.ToString();

            lbl_saat.Text = tarih.Hour.ToString();
            lbl_dakika.Text = tarih.Minute.ToString();
            lbl_saniye.Text = tarih.Second.ToString();


            #region Datetime Özellikleri

            DateTime t1 = DateTime.Now.AddDays(3);//Tarih'e gün ekler
            DateTime t2 = DateTime.Now.AddDays(-3);//Tarih'ten gün çıkarır

            DateTime t3 = DateTime.Now.AddMonths(3);//Tarih'e ay ekler
            DateTime t4 = DateTime.Now.AddMonths(-3);//Tarih'ten ay çıkarır

            DateTime t5 = DateTime.Now.AddYears(3);//Tarih'e yıl ekler
            DateTime t6 = DateTime.Now.AddYears(-3);//Tarih'ten yıl çıkarır

            DateTime t7 = DateTime.Now.AddHours(3);//Tarih'e saat ekler
            DateTime t8 = DateTime.Now.AddHours(-3);//Tarih'ten saat çıkarır

            DateTime t9 = DateTime.Now.AddMinutes(3);//Tarih'e dakika ekler
            DateTime t10 = DateTime.Now.AddMinutes(-3);//Tarih'ten dakika çıkarır

            #endregion

            #region DateTimePicker Özellikleri

            //dtp_tarih.MaxDate = DateTime.Now.AddDays(7);
            //DateTime maksimum = Convert.ToDateTime("30/08/2024");
            //dtp_tarih.MaxDate = maksimum;
            //dtp_tarih.MinDate = DateTime.Now.AddDays(-1);

            //dtp_tarih.CalendarForeColor = Color.BlueViolet;
            //dtp_tarih.CalendarTitleBackColor = Color.Red;
            //dtp_tarih.CalendarTitleForeColor = Color.Red;

            dtp_tarih.Format = DateTimePickerFormat.Short;

            #endregion

            #region MonthCalender Özellikleri

            mc_tarih.ShowToday = true;
            mc_tarih.ShowTodayCircle = true;
            mc_tarih.ShowWeekNumbers = true;
            //mc_tarih.FirstDayOfWeek = Day.Tuesday;
            //mc_tarih.MaxDate = DateTime.Now.AddDays(4);
            //mc_tarih.MaxSelectionCount = 2;
            
            #endregion
        }

        private void btn_tarihGetir_Click(object sender, EventArgs e)
        {
            lbl_SecilenTarih.Text = dtp_tarih.Text;
        }

        private void btn_getir2_Click(object sender, EventArgs e)
        {
            //DateTime baslangic = mc_tarih.SelectionStart;
            //DateTime bitis = mc_tarih.SelectionEnd;
            //lbl_secilen2.Text = baslangic.ToShortDateString() + " - " + bitis.ToShortDateString();

            SelectionRange sr = mc_tarih.SelectionRange;
            lbl_secilen2.Text = sr.Start.ToShortDateString() + " - " + sr.End.ToShortDateString();

            //DateTime - Datetime = TimeSpan türünde veri getirir
            TimeSpan tariharaligi =  sr.End - sr.Start;
            //lbl_secilen2.Text = tariharaligi.Days.ToString();


            //DateTime vahit = Convert.ToDateTime("03/03/2004 02:00:01");
            //TimeSpan vahitdogali = DateTime.Now - vahit;
            //lbl_secilen2.Text = "Vahit Doğalı = " + vahitdogali.Hours.ToString() + " Saat Oldu";
        }

        private void btn_sec_Click(object sender, EventArgs e)
        {
            DateTime baslangic = dtp_baslangic.Value;
            DateTime bitis = dtp_bitis.Value;

            lbl_tariharalik.Text = baslangic.ToString() + " - " + bitis.ToString();


            //TimeSpan ts = bitis - baslangic;
            //lbl_kacGun.Text = ts.Days.ToString();

            lbl_kacGun.Text = ((bitis - baslangic).Days + 1).ToString(); 
        }

        private void dtp_baslangic_ValueChanged(object sender, EventArgs e)
        {
            dtp_bitis.MinDate = dtp_baslangic.Value;
        }
    }
}
