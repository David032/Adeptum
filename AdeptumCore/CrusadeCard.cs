using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptumCore
{
    public class CrusadeCard
    {
        private string? unitName = string.Empty;
        private int pointsValue;
        private int crusadePoints;
        private string? unitType = string.Empty;
        private string? subKeywords = string.Empty;
        private int exp;
        private Rank unitRank = Rank.BattleReady;
        private string? equipment = string.Empty;
        private string? unitUpgrades = string.Empty;
        private string? unitBadges = string.Empty;
        private int battlesPlayed;
        private int battlesSurvived;
        private int unitsDestroyed;
        private string? battleHonours = string.Empty;
        private string? battleScars = string.Empty;
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Scars
        {
            get { return battleScars; }
            set { battleScars = value; }
        }


        public string Honours
        {
            get { return battleHonours; }
            set { battleHonours = value; }
        }


        public int Kills
        {
            get { return unitsDestroyed; }
            set { unitsDestroyed = value; }
        }


        public int BattlesSurvived
        {
            get { return battlesSurvived; }
            set { battlesSurvived = value; }
        }


        public int BattlesFought
        {
            get { return battlesPlayed; }
            set { battlesPlayed = value; }
        }


        public string? Badges
        {
            get { return unitBadges; }
            set { unitBadges = value; }
        }


        public string? Upgrades
        {
            get { return unitUpgrades; }
            set { unitUpgrades = value; }
        }


        public string? Equipment
        {
            get { return equipment; }
            set { equipment = value; }
        }


        public Rank Rank
        {
            get { return unitRank; }
            set { unitRank = value; }
        }


        public int ExperiencePoints
        {
            get { return exp; }
            set { exp = value; }
        }


        public string SubfactionKeywords
        {
            get { return subKeywords; }
            set { subKeywords = value; }
        }

        public string Type
        {
            get { return unitType; }
            set { unitType = value; }
        }


        public int CrusadePoints
        {
            get { return crusadePoints; }
            set { crusadePoints = value; }
        }


        public int Points
        {
            get { return pointsValue; }
            set { pointsValue = value; }
        }
        public string Name
        {
            get { return unitName; }
            set { unitName = value; }
        }
        public CrusadeCard(string name, int points, string type)
        {
            Name = name;
            Points = points;
            Type = type;
        }

    }
}
