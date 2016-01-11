using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Data.Infrastructure;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Data.Repositories
{
   public class GouvernoratRepository : RepositoryBase<Gouvernorat>, IGouvernoratRepository
    {
        public GouvernoratRepository(DatabaseFactory dbFactory) : base(dbFactory) { }
        public void UpdateGouvernoratDetached(Gouvernorat e)
        {
            Gouvernorat existing = FindFourByID(e.idGouvernorat);
            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);
            this.DataContext.Entry(e).State = EntityState.Modified;
        }
        public Gouvernorat FindFourByID(int id)
        {

            var pers = (from p in DataContext.Gouvernorat
                        where p.idGouvernorat == id
                        select p);
            return pers.FirstOrDefault();
        }

    }

   

    public interface IGouvernoratRepository : IRepository<Gouvernorat>
    {
        Gouvernorat FindFourByID(int id);
        void UpdateGouvernoratDetached(Gouvernorat e);



    }

}


