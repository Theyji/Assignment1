using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using assignment1.Models;

namespace assignment1.Data
{
    public class assignment1Context : DbContext
    {
        public assignment1Context (DbContextOptions<assignment1Context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<assignment1.Models.Game> Game { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                       new Game
                       {
                           GameId = 1,
                           Title = "Gang of Lagos",
                           Developer = "Jagaban",
                           Genre = "Action",
                           ReleaseYear = 2020,
                           PurchaseDate = new DateTime(2022, 1, 15),
                           Rating = 8
                       },
                       new Game
                       {
                           GameId = 2,
                           Title = "Survival on Lagos Streets",
                           Developer = "IDAN Inc",
                           Genre = "Adventure",
                           ReleaseYear = 2019,
                           PurchaseDate = new DateTime(2021, 5, 10),
                           Rating = 7
                       },
                       new Game
                       {
                           GameId = 3,
                           Title = "Beat Lagos Traffic",
                           Developer = "Danfo Drivers",
                           Genre = "Racing",
                           ReleaseYear = 2021,
                           PurchaseDate = new DateTime(2022, 12, 5),
                           Rating = 9
                       }
                   );
        }
    }
}
