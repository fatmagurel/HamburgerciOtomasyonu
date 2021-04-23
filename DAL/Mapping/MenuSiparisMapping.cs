using Hamburgerci.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    public class MenuSiparisMapping : EntityTypeConfiguration<MenuSiparis>
    {
        public MenuSiparisMapping()
        {
            ToTable("SiparisMenuMapping");
            HasKey(x => x.SiparisID);
            HasKey(x => x.MenuID);
            HasRequired(x => x.Siparis).WithMany(x => x.MenuSiparisler);
        }
    }
}
