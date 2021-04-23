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
    public partial class Form3 : Form
    {
        //form1 deki ekstra malzemeler listesine eklenecek ve eklenme işleminden sonra ilgili kontroller temizleceke.

        ProjectContext db;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnEkstraMalzemeEkle_Click(object sender, EventArgs e)
        {
            db.Ekstralar.Add(new DATA.Ekstra
            {
                EkstraAdi = txtEkstraMalzemeAdi.Text,
                Fiyati = nmrEkstraMalzemeFiyati.Value
            });

            Metot.Temizle(Controls);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            db = new ProjectContext();
        }
    }
}
