using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Repository;
using Xunit; 

namespace XUnitTestProject2.RepoTests
{
    [Collection("Database collection")]
    public class NameRepoTest
    {
        NameRepository repo;
        public NameRepoTest(DatabaseFixture fixture)
        {
            repo = new NameRepository(fixture.context); 
        }

        [Fact]
        public void countTest()
        {
            Assert.Equal(2,repo.getAllNames().Count());
        }

        [Fact]
        public void insertTest()
        {
            Name n = new Name();
            n.FirstName = "BB";
            n.LastName = "MM";

            Name newName = repo.insertName(n);
            Assert.NotNull(newName);
            Assert.NotNull(newName.Id);
            Assert.Equal(3, repo.getAllNames().Count());

            // delete just created record
            repo.deleteName(2);
        }

        [Fact]
        public void deleteTest()
        {
            repo.deleteName(1);
            Assert.Equal(1, repo.getAllNames().Count()); 
        }
    }
}
