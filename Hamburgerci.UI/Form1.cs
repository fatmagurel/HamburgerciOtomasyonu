using DAL.Context;
using Hamburgerci.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProjectContext db;

        public static List<Siparis> siparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();//geçici liste

        //public static List<DATA.Menu> menuler = new List<DATA.Menu>()
        //{
        //    new DATA.Menu{MenuAdi = "Big King", Fiyati = 18.25M},
        //    new DATA.Menu{MenuAdi = "Double King Chicken", Fiyati = 24.50M},
        //    new DATA.Menu{MenuAdi = "Big Royal", Fiyati = 25.75M},
        //    new DATA.Menu{MenuAdi = "Whooper", Fiyati = 23.25M},
        //    new DATA.Menu{MenuAdi = "Steak House", Fiyati = 27.50M},
        //    new DATA.Menu{MenuAdi = "Double Whooper", Fiyati = 21.00M},
        //};

        //public static List<Ekstra> ekstralar = new List<Ekstra>()
        //{
        //    new Ekstra{EkstraAdi = "Ketçap", Fiyati = 0.25M},
        //    new Ekstra{EkstraAdi = "Mayonez", Fiyati = 0.25M},
        //    new Ekstra{EkstraAdi = "Ranch Sos", Fiyati = 0.50M},
        //    new Ekstra{EkstraAdi = "BBQ Sos", Fiyati = 0.50M},
        //    new Ekstra{EkstraAdi = "Hardal", Fiyati = 0.75M},
        //    new Ekstra{EkstraAdi = "Buffalo Sos", Fiyati = 1.00M},
        //};
        public void Form1_Load(object sender, EventArgs e)
        {
            db = new ProjectContext();

            foreach (DATA.Menu item in db.Menuler.ToList())
                cmbMenu.Items.Add(item);


            foreach (Ekstra item in db.Ekstralar.ToList())
                flpEkstraMalzeme.Controls.Add(new CheckBox() { Text = item.EkstraAdi, Tag = item });

            //foreach (Siparis item in db.Siparisler.ToList())
            //    lbxSiparisler.Items.Add(item);

            cmbMenu.SelectedIndex = 0;
            rdoKucuk.Checked = true;
        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
           // Siparis gelen = null;
            foreach (Siparis item in db.Siparisler)
            {
                toplamTutar += item.ToplamTutar;
            }
            //for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            //{
            //    gelen = (Siparis)lbxSiparisler.Items[i];
            //    toplamTutar += gelen.ToplamTutar;
            //}
            lblToplamTutar.Text = toplamTutar.ToString("C2");//2 HANELİ ONDALIKLI YAZILABİLİR
            return toplamTutar;
        }

        private string BoyutBul(Control.ControlCollection koleksiyon)
        {
            string boyut = "";
            foreach (Control item in koleksiyon)
            {
                if (item is RadioButton && (((RadioButton)item).Text == "Küçük")) 
                {
                    boyut = "Küçük";
                }
                else if (item is RadioButton && (((RadioButton)item).Text == "Orta"))
                {
                    boyut = "Orta";
                }
                else if (item is RadioButton && (((RadioButton)item).Text == "Büyük"))
                {
                    boyut = "Büyük";
                }
            }
            return boyut;
        }
        
        private void btnEkle_Click(object sender, EventArgs e)
        {

            Siparis yeniSiparis = new Siparis()
            {
                SeciliMenu = (DATA.Menu)cmbMenu.SelectedItem,
                Boyutu = (string)BoyutBul(Controls),
                Adet= Convert.ToInt32(nmrAdet.Value),
                ToplamTutar= TutarHesapla(),
                EkstraMalzemeleri= MalzemeleriGonder()
            };
            db.Siparisler.Add(yeniSiparis);
            db.SaveChanges();
            //yeniSiparis.SeciliMenu = (DATA.Menu)cmbMenu.SelectedItem;

            //if (rdoKucuk.Checked)//true ise
            //    yeniSiparis.Boyutu = Boyut.Kucuk;
            //else if (rdoOrta.Checked)//true ise
            //    yeniSiparis.Boyutu = Boyut.Orta;
            //else
            //    yeniSiparis.Boyutu = Boyut.Buyuk;

            //yeniSiparis.EkstraMalzemeleri = new List<Ekstra>();

            
            //foreach (CheckBox item in flpEkstraMalzeme.Controls)
            //{
            //    if (item.Checked)
            //        yeniSiparis.EkstraMalzemeleri.Add((Ekstra)item.Tag);

            //}

            //yeniSiparis.Adet = Convert.ToInt32(nmrAdet.Value);
            yeniSiparis.Hesapla();

            lbxSiparisler.Items.Add(yeniSiparis);
           // siparisler.Add(yeniSiparis);
            mevcutSiparisler.Add(yeniSiparis);

            TutarHesapla();
        }

        private List<Ekstra> MalzemeleriGonder()
        {
            string deger = "";
            List<Ekstra> malzemeler = new List<Ekstra>();
            foreach (Control item in flpEkstraMalzeme.Controls)
            {
                CheckBox chk = item as CheckBox;
                if (chk != null)
                {
                    if (chk.Checked)
                    {
                        deger = chk.Text;
                        malzemeler.Add((Ekstra)item.Tag);
                    }
                }
            }
            return malzemeler;
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı: " + TutarHesapla().ToString("C2") + "\nSatın Alma İşlemini Tamamlamak İster Misiniz?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                lbxSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla();
                MessageBox.Show("Siparişiniz Tamamlandı!");
            }
            else
            {
                MessageBox.Show("İsteğiniz üzerine işlem iptal edildi!");
            }
            rdoKucuk.Checked = true;
            DATA.Metot.Temizle(Controls);
        }
    }
}
