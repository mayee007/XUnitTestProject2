using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1;
using Xunit; 

namespace XUnitTestProject2.IntTests
{
    public class BasicTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> factory;

        public BasicTest(WebApplicationFactory<Startup> factory)
        {
            this.factory = factory; 
        }

        [Theory]
        [InlineData("/")]
        [InlineData("/Home")]
        [InlineData("/Home/Index")]
        [InlineData("/Home/Privacy")]
        public async Task homeTest(string url)
        {
            var client = factory.CreateClient();

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode(); 

            
        }
    }
}
