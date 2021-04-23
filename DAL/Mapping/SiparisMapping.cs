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
    public class SiparisMapping : EntityTypeConfiguration<Siparis>
    {
        public SiparisMapping()
        {
            ToTable("SiparisMapping");
            Ignore(x => x.SeciliMenu);
            Ignore(x => x.EkstraMalzemeleri);
            Property(x => x.Boyutu).HasColumnType("varchar").IsRequired();
            Property(x => x.Adet).IsRequired();
            Property(x => x.ToplamTutar).IsRequired();
            HasKey(x => x.SiparisID);
            HasKey(x => x.MenuID);
            HasKey(x => x.EkstraID);
            HasMany(x => x.MenuSiparisler).WithRequired(x => x.Siparis);
        }
    }
}
