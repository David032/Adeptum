using AdeptumCore;
using AdeptumCore.Database;
using AdeptumCore.Database.Models;
using Astropathia.Interfaces;
using System.Numerics;

namespace Astropathia.Repositories
{
    public class UnitRepository : IUnitRepository
    {
        AdeptumDb context;

        public UnitRepository()
        {
            context = new AdeptumDb();
        }

        public bool Create(CrusadeCard unit)
        {
            context.Add(unit);
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
            var unitToDelete = context.Units.Select(x => x).Where(x => x.Id.Equals(id)).FirstOrDefault();
            if (unitToDelete != null)
            {
                context.Remove(unitToDelete);
                context.SaveChanges();
            }

            if (context.Units.Contains(unitToDelete))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public CrusadeCard Get(int id)
        {
            return context.Units.Select(x => x).Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public List<CrusadeCard> GetAll()
        {
            return [.. context.Units.ToList()];
        }

        public List<CrusadeCard> GetByPlayer(string playerName)
        {
            List<CrusadeCard> playerUnits = [];
            foreach (var roster in context.Rosters)
            {
                if (roster.PlayerName == playerName)
                {
                    foreach (var unit in roster.Units)
                    {
                        playerUnits.Add(unit);
                    }
                }
            }
            return playerUnits;
        }

        public bool Update(CrusadeCard unit)
        {
            context.Update(unit);
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
    }
}
