
using Data.Infrastructure;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
   
   public class SocieteMaintenanceRepository : RepositoryBase<Societe_maintenance>, ISocieteMaintenanceRepository
    {
        public SocieteMaintenanceRepository(DatabaseFactory dbFactory) : base(dbFactory) { }
        public void UpdateSoc_MaintenanceDetached(Societe_maintenance e)
        {
            Societe_maintenance existing = this.DataContext.Societe_maintenance.Find(e.Id_societe_maintenance);
            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);
            this.DataContext.Entry(e).State = EntityState.Modified;
        }

       
    }


    public interface ISocieteMaintenanceRepository : IRepository<Societe_maintenance>
    {

        void UpdateSoc_MaintenanceDetached(Societe_maintenance e);
       
    }

}

