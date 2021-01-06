using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore; 
using System;
using WebApplication1.DAL;
using WebApplication1.Repository;
using WebApplication1.Models;
using XUnitTestProject2.Utils;

namespace XUnitTestProject2
{
    public class DatabaseFixture : IDisposable
    {
        public BookContext context; 
        public DatabaseFixture()
        {
            var services = new ServiceCollection();
            services.AddDbContext<BookContext>(options =>
                options.UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()),
                ServiceLifetime.Scoped, ServiceLifetime.Scoped);

            var serviceProvider = services.BuildServiceProvider();
            context = serviceProvider.GetRequiredService<BookContext>();

            // load all tables 
            SeedTestData.loadNames(context);
            SeedTestData.loadAuthors(context);
            SeedTestData.loadBooks(context);
            context.SaveChanges(); 
        }
        public void Dispose()
        {            
        }
    }
}
