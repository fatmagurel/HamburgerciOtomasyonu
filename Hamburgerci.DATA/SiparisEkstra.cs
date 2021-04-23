using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DATA.Entities
{
    public class SiparisEkstra
    {
        public int SiparisID { get; set; }
        public int EkstraID { get; set; }

        public virtual Siparis Siparis { get; set; }
        public virtual Ekstra Ekstra { get; set; }
    }
}
