using Hamburgerci.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DATA
{
    public class Menu
    {
        //public int SiparisID { get; set; }
        public int MenuID { get; set; }
        public string MenuAdi { get; set; }
        public decimal Fiyati { get; set; }
        public override string ToString()
        {
            return MenuAdi + " Menü";
        }
        public virtual List<MenuSiparis> MenuSiparisler { get; set; }
    }
}
