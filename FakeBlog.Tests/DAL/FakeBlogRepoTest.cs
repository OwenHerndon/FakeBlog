using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FakeBlog.DAL;
using Moq;
using FakeBlog.Models;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;

namespace FakeBlog.Tests.DAL
{
    [TestClass]
    public class FakeBlogRepoTest
    {
        public Mock<FakeBlogContext> fake_context { get; set; }
        public FakeBlogRepository repo { get; set; }

        public Mock<DbSet<Blog>> mock_blog_set { get; set; }
        public IQueryable<Blog> query_blog { get; set; }
        public List<Blog> fake_blog_table { get; set; }

        [TestInitialize]
        public void Setup()
        {
            fake_context = new Mock<FakeBlogContext>();
            repo = new FakeBlogRepository(fake_context.Object);
        }

        public void CreateFakeDatabase()
        {

        }

        [TestMethod]
        public void EnsureICanCreateInstanceofRep()
        {
            FakeBlogRepository repo = new FakeBlogRepository();

            Assert.IsNotNull(repo);
        }
    }
}
