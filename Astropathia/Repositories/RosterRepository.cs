using AdeptumCore;
using AdeptumCore.Database;
using AdeptumCore.Database.Models;
using Astropathia.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Astropathia.Repositories
{
    public class RosterRepository : IRosterRepository
    {
        AdeptumDb context;
        public RosterRepository()
        {
            context = new AdeptumDb();
        }

        public bool Create(CrusadeRoster roster)
        {
            context.Rosters.Add(roster);
            int results = context.SaveChanges();
            if (results != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            var rosterToDelete = context.Rosters.Select(x => x).Where(x => x.Id.Equals(id)).FirstOrDefault();
            if (rosterToDelete != null) 
            {
                context.Remove(rosterToDelete);
                context.SaveChanges();
            }

            if (context.Rosters.Contains(rosterToDelete))
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public CrusadeRoster Get(int id)
        {
            return context.Rosters.Select(x => x).Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public List<CrusadeRoster> GetAll()
        {
            return [.. context.Rosters.ToList()];
        }

        public List<CrusadeRoster> GetByPlayerName(string playerName)
        {
            return [.. context.Rosters.Select(x => x).Where(x => x.PlayerName.Equals(playerName))];

        }

        public bool Update(CrusadeRoster roster)
        {
            context.Update(roster);
            var result = context.SaveChanges();
            if (result != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Count() 
        {
            return context.Rosters.Count();
        }
    }
}
