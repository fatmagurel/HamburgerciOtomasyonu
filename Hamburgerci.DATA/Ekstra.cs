using Hamburgerci.DATA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DATA
{
    public class Ekstra
    {
        [Key]
        public int EkstraID { get; set; }
        public string EkstraAdi { get; set; }
        public decimal Fiyati { get; set; }
        public virtual List<SiparisEkstra> SiparisEkstralar { get; set; }
        public virtual List<Siparis> Siparisler { get; set; }
        public virtual List<MenuSiparis> MenuSiparisler { get; set; }

    }
}
