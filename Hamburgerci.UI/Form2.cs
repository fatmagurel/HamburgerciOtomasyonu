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
    public partial class Form2 : Form
    {
        //form1 deki menüler listesine eklenecek ve eklenme işleminden sonra ilgili kontroller temizleceke.
        ProjectContext db;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMenuKaydet_Click(object sender, EventArgs e)
        {
            db.Menuler.Add(new DATA.Menu
            {
                MenuAdi = txtMenuAdi.Text,
                Fiyati=nmrFiyati.Value
            }) ;

            Metot.Temizle(Controls);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            db = new ProjectContext();
        }
    }
}
