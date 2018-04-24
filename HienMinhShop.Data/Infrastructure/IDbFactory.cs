using System;

namespace HienMinhShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        HienMinhShopDbContext Init();
    }
}