using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DATA.Entities
{
    public class MenuSiparis
    {
        public int MenuID { get; set; }
        public int SiparisID { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual Siparis Siparis { get; set; }

    }
}
