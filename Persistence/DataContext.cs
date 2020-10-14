using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // builder.Entity<Movie>().HasData(
            //     new Movie{ Title = "Harry Potter and the Sorcerer's Stone", ReleaseDate =  new System.DateTime(2001, 11, 16), Synopsis = "An orphaned boy enrolls in a school of wizardry, where he learns the truth about himself, his family and the terrible evil that haunts the magical world." },
            //     new Movie{ Title = "Harry Potter and the Chamber of Secrets", ReleaseDate =  new System.DateTime(2002, 11, 15), Synopsis = "An ancient prophecy seems to be coming true when a mysterious presence begins stalking the corridors of a school of magic and leaving its victims paralyzed." },
            //     new Movie{ Title = "Harry Potter and the Prisoner of Azkaban", ReleaseDate =  new System.DateTime(2004, 6, 4), Synopsis = "Harry Potter, Ron and Hermione return to Hogwarts School of Witchcraft and Wizardry for their third year of study, where they delve into the mystery surrounding an escaped prisoner who poses a dangerous threat to the young wizard." }
            // );
        }
    }
}