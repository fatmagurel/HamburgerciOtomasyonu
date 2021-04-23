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
    public partial class Form4 : Form
    {
        //siparişler form1 deki siparişler listesinden gelecek ilgili labellar doldurulacak.

        ProjectContext db;
        public Form4()
        {
            InitializeComponent();
        }
        
        public void Form4_Load(object sender, EventArgs e)
        {
            db = new ProjectContext();
            //foreach (Siparis item in Form1.mevcutSiparisler)
            //    lbxTumSiparisler.Items.Add(item);


            foreach (Siparis item in db.Siparisler)
            {
                string liste = item.MenuID.ToString();
                string boyu = item.Boyutu;
                string adet = item.Adet.ToString();


                lbxTumSiparisler.Items.Add(liste+" "+boyu+" "+adet);
            }

            //for (int i = 0; i < Form1.siparisler.Count; i++)
            //{
            //    lbxTumSiparisler.Items.Add(Form1.siparisler[i]);
            //}

            decimal ciro = 0;
            foreach (Siparis item in db.Siparisler)
            {
                ciro += item.ToplamTutar;
            }
            lblCiro.Text = ciro.ToString();

            //for (int i = 0; i < Form1.siparisler.Count; i++)
            //{
            //    ciro += Form1.siparisler[i].ToplamTutar;
            //}


            lblToplamSiparisSayisi.Text = db.Siparisler.Count().ToString();
            
            decimal ekstraGelir = 0;
            foreach (Ekstra item in db.Ekstralar)
            {
                ekstraGelir += item.Fiyati;
            }
            lblEkstraMalzemeGeliri.Text = ekstraGelir.ToString();

            //for (int i = 0; i < Form1.ekstralar.Count; i++)
            //{
            //    ekstraGelir += Form1.ekstralar[i].Fiyati;
            //}


            int toplam = 0;
            foreach (Siparis item in db.Siparisler)
            {
                toplam += item.Adet;
            }
            lblSatilanUrunAdedi.Text = toplam.ToString();

            //for (int i = 0; i < Form1.siparisler.Count; i++)
            //{
            //    toplam += Form1.siparisler[i].Adet;
            //}

        }

    }
}
