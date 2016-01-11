
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
   
   public class BiensRepository : RepositoryBase<AtbDataTest> ,IBiensRepository
    {
        public BiensRepository(DatabaseFactory dbFactory) : base(dbFactory) { }
        public void UpdateBiensDetached(AtbDataTest e)
        {
            AtbDataTest existing = this.DataContext.AtbDataTest.Find(e.id);
            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);
            this.DataContext.Entry(e).State = EntityState.Modified;
        }

        public void UpdateStockDetached(Stock e)
        {
            Stock existing = DataContext.Stock.Find(e.id);
            ((IObjectContextAdapter)DataContext).ObjectContext.Detach(existing);
            this.DataContext.Entry(e).State = EntityState.Modified;
        }
    }


    public interface IBiensRepository : IRepository<AtbDataTest>
    {
        void UpdateStockDetached(Stock e);

        void UpdateBiensDetached(AtbDataTest e);

       
    }

}

