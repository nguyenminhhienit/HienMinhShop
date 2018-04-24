using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HienMinhShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        HienMinhShopDbContext dbContext;
        public HienMinhShopDbContext Init()
        {
            return dbContext ?? (dbContext = new HienMinhShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext!= null)
            {
                dbContext.Dispose();
            }
        }
    }
}
