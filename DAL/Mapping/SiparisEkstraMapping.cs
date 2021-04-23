using Hamburgerci.DATA;
using Hamburgerci.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    public class SiparisEkstraMapping : EntityTypeConfiguration<SiparisEkstra>
    {
        public SiparisEkstraMapping()
        {
            ToTable("SiparisEkstraMapping");
            HasKey(x => x.EkstraID);
            HasKey(x => x.SiparisID);
            HasRequired(x => x.Siparis).WithMany(x => x.SiparisEkstralar);
        }
    }
}
