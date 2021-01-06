using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace XUnitTestProject2.Utils
{
    public static class SeedTestData
    {
        public static void loadNames(BookContext context)
        {
            NameRepository repo = new NameRepository(context);
            repo.insertName(new Name()
            {
                FirstName = "Mahesh",
                LastName = "Mahadeva"
            });
            repo.insertName(new Name()
            {
                FirstName = "BB",
                LastName = "MM"
            }); 
        }

        public static void loadAuthors(BookContext context)
        {
            
        }

        internal static void loadBooks(BookContext context)
        {
            
        }
    }
}
