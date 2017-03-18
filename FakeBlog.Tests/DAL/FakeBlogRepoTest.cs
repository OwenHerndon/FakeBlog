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
            fake_blog_table = new List<Blog>(); //may not need to be list
            fake_context = new Mock<FakeBlogContext>();
            mock_blog_set = new Mock<DbSet<Blog>>();
            repo = new FakeBlogRepository(fake_context.Object);
        }

        public void CreateFakeDatabase()
        {
            query_blog = fake_blog_table.AsQueryable();

            mock_blog_set.As<IQueryable<Blog>>().Setup(b => b.Provider).Returns(query_blog.Provider);
            mock_blog_set.As<IQueryable<Blog>>().Setup(b => b.Expression).Returns(query_blog.Expression);
            mock_blog_set.As<IQueryable<Blog>>().Setup(b => b.ElementType).Returns(query_blog.ElementType);
            mock_blog_set.As<IQueryable<Blog>>().Setup(b => b.GetEnumerator()).Returns(() => query_blog.GetEnumerator());

            mock_blog_set.Setup(b => b.Add(It.IsAny<Blog>())).Callback((Blog blog) => fake_blog_table.Add(blog));
            mock_blog_set.Setup(b => b.Remove(It.IsAny<Blog>())).Callback((Blog blog) => fake_blog_table.Remove(blog));
            fake_context.Setup(c => c.Blog).Returns(mock_blog_set.Object);

        }

        [TestMethod]
        public void EnsureICanCreateInstanceofRep()
        {
            FakeBlogRepository repo = new FakeBlogRepository();

            Assert.IsNotNull(repo);
        }

        [TestMethod]
        public void EnsureIHaveNotNullContext()
        {
            FakeBlogRepository repo = new FakeBlogRepository();

            Assert.IsNotNull(repo.Context);
        }

        [TestMethod]
        public void EnsureICanInjectContextInstanc()
        {
            FakeBlogContext context = new FakeBlogContext();
            FakeBlogRepository repo = new FakeBlogRepository(context);

            Assert.IsNotNull(repo.Context);
        }

        [TestMethod]
        public void EnsureICanAddPost()
        {

        }
    }
}
