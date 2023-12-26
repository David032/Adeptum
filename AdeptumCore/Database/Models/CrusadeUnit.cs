using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptumCore.Database.Models
{
    public class CrusadeUnit
    {
        public int Id { get; set; }
        public int RosterId { get; set; }
        public string UnitName { get; set; }
        public int PointsValue { get; set; }
        public int CrusadePoints { get; set; }
        public string UnitType { get; set; }
        public string? SubKeywords { get; set; }
        public int Exp { get; set; }
        public Rank UnitRank { get; set; }
        public string? Equipment { get; set; }
        public string? UnitUpgrades { get; set; }
        public string? UnitBadges { get; set; }
        public int BattlesPlayed { get; set; }
        public int BattlesSurvived { get; set; }
        public int UnitsDestroyed { get; set; }
        public string? BattleHonours { get; set; }
        public string? BattleScars { get; set; }

        public CrusadeUnit(string unitName, int points, string unitType)
        {
            UnitName = unitName;
            PointsValue = points;
            UnitType = unitType;
        }
    }
}
