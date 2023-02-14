/**using MedAdvisor.Api.Controllers;
using MedAdvisor.DataAccess.MySql;
using MedAdvisor.Models;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace MedAdvisor.API.Test.ControllerTests
{
    public class AllergyTest
    {
        private MedAdvisorDbContext _dbContext;
        private AllergyController _controller;

        [SetUp]
        public void SetUp()
        {
            // Set up the test environment, e.g. create an in-memory database and populate it with test data
            var options = new DbContextOptionsBuilder<MedAdvisorDbContext>()
                .UseInMemoryDatabase(databaseName: "MedicalCard")
                .Options;
            _dbContext = new MedAdvisorDbContext(options);
            _dbContext.AddRange(new[] {
            new Allergy { AllergyId = 1, AllergyName = "Foo" },
            new Allergy { AllergyId = 2, AllergyName = "Bar" }
        });
            _dbContext.SaveChanges();

            // Set up the API controller with the test database context
            _controller = new AllergyController(_dbContext);
        }

        [Test]
        public void Get_ReturnsAllEntities()
        {
            // Arrange: No additional setup is needed

            // Act: Call the Get method of the API controller
            var result = _controller.GetAllergys();

            // Assert: Check that the result contains all the entities in the test database
            var entities = Assert.IsInstanceOf<IEnumerable<Allergy>>(result.Value);
            Assert.AreEqual(2, entities.Count());
            Assert.AreEqual("Foo", entities.ElementAt(0).Name);
            Assert.AreEqual("Bar", entities.ElementAt(1).Name);
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up the test environment, e.g. delete the in-memory database
            _dbContext.Database.EnsureDeleted();
            _dbContext.Dispose();
        }
    }
}

*/