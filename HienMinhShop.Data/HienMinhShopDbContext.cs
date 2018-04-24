﻿using HienMinhShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HienMinhShop.Data
{
    public class HienMinhShopDbContext : DbContext
    {
        public HienMinhShopDbContext() : base("HienMinhShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
            //Khi load bang cha, khong tu dong load bang con nua;
        }

        //Khai bao cac bang ben model vao
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SupportOnline> SupportOnlines { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics { get; set; }

        //Ghi de phuong thuc OnModelCreating trong class DbContext
        protected override void OnModelCreating(DbModelBuilder builder)
        {

        }
    }
}
