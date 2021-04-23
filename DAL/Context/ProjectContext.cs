using DAL.Mapping;
using Hamburgerci.DATA;
using Hamburgerci.DATA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = @"Server = DESKTOP-19NARKN; Database = Hamburgerci; Uid=sa; Pwd=123;";
        }

        public DbSet<Ekstra> Ekstralar { get; set; }
        public DbSet<Menu> Menuler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<MenuSiparis> MenuSiparisler { get; set; }
        public DbSet<SiparisEkstra> SiparisEkstralar { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new MenuSiparisMapping());
            modelBuilder.Configurations.Add(new SiparisEkstraMapping());
            modelBuilder.Configurations.Add(new SiparisMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
