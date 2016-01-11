
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
   
   public class SocieteAssuranceRepository : RepositoryBase<Societe_assurance>, ISocieteAssuranceRepository
    {
        public SocieteAssuranceRepository(DatabaseFactory dbFactory) : base(dbFactory) { }
        public void UpdateSoc_AssuranceDetached(Societe_assurance e)
        {
            Societe_assurance existing = this.DataContext.Societe_assurance.Find(e.Id_societe_assurance);
            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);
            this.DataContext.Entry(e).State = EntityState.Modified;
        }

       
    }


    public interface ISocieteAssuranceRepository : IRepository<Societe_assurance>
    {

        void UpdateSoc_AssuranceDetached(Societe_assurance e);
       
    }

}

