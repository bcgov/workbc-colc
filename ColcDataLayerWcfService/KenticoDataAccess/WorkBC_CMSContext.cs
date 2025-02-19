using ColcDataLayerWcfService.KenticoDataAccess.Models;
using ColcDataLayerWcfService.KenticoDataAccess.Models.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ColcDataLayerWcfService.KenticoDataAccess
{
    public partial class WorkBC_CMSContext : DbContext
    {
        static WorkBC_CMSContext()
        {
            Database.SetInitializer<WorkBC_CMSContext>(null);
        }

        public WorkBC_CMSContext()
            : base("Name=CMSConnectionString")
        {
        }
                
        public DbSet<COLC_ExternalLinks> COLC_ExternalLinks { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new COLC_ExternalLinksMap());           
        }
    }

}