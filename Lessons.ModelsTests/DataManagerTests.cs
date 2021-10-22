using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lessons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lessons.Models.DataProviders.SqlServer;
using Lessons.Models.DataProviders.SqlServer.Repositories;

namespace Lessons.Models.Tests
{
    [TestClass()]
    public class DataManagerTests
    {
        public TestContext TestContext { get; set; }

        [TestMethod()]
        public void DataManager_CrudSqlServer_SuccesAllOperations()
        {
            //arrange
            LessonsContext context = new LessonsContext();
            DataManager data = new DataManager(new StudentsRepos(context), new CoursesRepos(context));
            //act


            //assert
            Assert.Fail();
        }
    }
}