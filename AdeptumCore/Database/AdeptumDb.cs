using AdeptumCore.Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptumCore.Database
{
    public class AdeptumDb: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (Environment.GetEnvironmentVariable("environment") == "Production")
            {

            }
            if (Environment.GetEnvironmentVariable("environment") == "Staging")
            {

            }
            if (Environment.GetEnvironmentVariable("environment") == "Development") 
            {
                optionsBuilder.UseInMemoryDatabase(databaseName: "Adeptum-Dev");
            }
        }
        public DbSet<CrusadeRoster> Rosters { get; set; }
        public DbSet<CrusadeCard> Units { get; set; }

        public AdeptumDb()
        {
            if (Environment.GetEnvironmentVariable("Environment") == "Development")
            {
                List<CrusadeRoster> TestRosters =
                [
                    new CrusadeRoster 
                    { 
                        ForceName = "Strike Force Octavius", 
                        PlayerName = "Joe Bloggs",
                        Units =
                        [
                            new CrusadeCard("Captain Octavius", 100, "Captain in Terminator Armour"),
                            new CrusadeCard("Librarian Tantus", 90, "Librarian in Terminator Armour"),
                            new CrusadeCard("Squad Burny", 85, "Infernus Squad"),
                            new CrusadeCard("Squad Punchy", 160, "Terminator Squad")
                        ]
                    },
                    new CrusadeRoster
                    {
                        ForceName = "Dark Zealots",
                        PlayerName = "John Smith",
                        Units =
                        [
                            new CrusadeCard("Ghallaron teh Pious", 80, "Dark Apostle"),
                            new CrusadeCard("Grabby Bretheren", 150, "Legionaries"),
                            new CrusadeCard("Explodey Brethern", 140, "Havocs"),
                            new CrusadeCard("Smashy Boi", 200, "Helbrute")
                        ]
                    },
                    new CrusadeRoster
                    {
                        ForceName = "Onnomnomnom",
                        PlayerName = "Jane Sggolb",
                        Units =
                        [
                            new CrusadeCard("Terror of Vardenghast", 100, "Winged Tyranid Prime"),
                            new CrusadeCard("Nerd Eater", 140, "Psychophage"),
                            new CrusadeCard("Shooty Swarm", 200, "Termagants"),
                            new CrusadeCard("Scary Shooty Swarm", 100, "Barbgaunts"),
                            new CrusadeCard("Big Spookers", 150, "Von Ryan's Leapers")
                        ]
                    },
                ];

                Rosters.AddRange(TestRosters);
                this.SaveChanges();
            }

        }
    }
}
