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
      
        public FakeBlogRepository repo { get; set; }
        public Mock<FakeBlogContext> fake_context { get; set; }

        [TestInitialize]
        public void Setup()
        {
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
