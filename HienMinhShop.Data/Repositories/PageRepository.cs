﻿using HienMinhShop.Data.Infrastructure;
using HienMinhShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HienMinhShop.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>{ }
    public class PageRepository : RepositoryBase<Page>, IPageRepository
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
