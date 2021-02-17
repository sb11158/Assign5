using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            ProjectDBContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<ProjectDBContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Projects.Any())
            {
                context.Projects.AddRange(
                    //Professor hiltons favorite book data 
                    new Project
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        MiddleInt = "",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95
                    },
                    new Project
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris",
                        MiddleInt = "K",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58
                    }, 
                    new Project
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        MiddleInt = "",
                        AuthorLast = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54
                    },
                    new Project
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald",
                        MiddleInt = "C",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61
                    },
                    new Project
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        MiddleInt = "",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33
                    },
                    new Project
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Micheal",
                        MiddleInt = "",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95
                    },
                    new Project
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        MiddleInt = "",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99
                    },
                    new Project
                    {
                        Title = "Its Your Ship",
                        AuthorFirst = "Micheal",
                        MiddleInt = "",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-145552303",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66
                    },
                    new Project
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        MiddleInt = "",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16
                    },
                    new Project
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        MiddleInt = "",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03
                    }
                 );
                context.SaveChanges();
            }
        }
    }
}
