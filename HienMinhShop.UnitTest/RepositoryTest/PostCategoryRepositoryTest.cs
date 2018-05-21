using HienMinhShop.Data.Infrastructure;
using HienMinhShop.Data.Repositories;
using HienMinhShop.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace HienMinhShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        private IDbFactory dbFactory;
        private IPostCategoryRepository objRepository;
        private IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();

            Assert.AreEqual(1, list.Count);
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test Category";
            category.Alias = "Test-category";

            var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result);
        }
    }
}