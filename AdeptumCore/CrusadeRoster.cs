using AdeptumCore.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptumCore
{
    public class CrusadeRoster
    {
        private string RosterName;
        private string playerName;
        private int id;

        private int TotalSupply;
        private int crusadeSupplyUser;

        private int battleTally;
        private int battlesWon;
        private int requisitionPoints;

        private string? records = string.Empty;

        private List<CrusadeCard> units;

        /// <summary>
        /// The crusade force's units
        /// </summary>
        public List<CrusadeCard> Units
        {
            get { return units; }
            set { units = value; }
        }
        /// <summary>
        /// Notable events, and notes
        /// </summary>
        public string RecordsOfAchievments
        {
            get { return records; }
            set { records = value; }
        }
        /// <summary>
        /// The number of available requisition points
        /// </summary>
        public int RequisitionPoints
        {
            get { return requisitionPoints; }
            set { requisitionPoints = value; }
        }
        /// <summary>
        /// The number of battles won
        /// </summary>
        public int Victories
        {
            get { return battlesWon; }
            set { battlesWon = value; }
        }
        /// <summary>
        /// The number of battles fought
        /// </summary>
        public int BattlesFought
        {
            get { return battleTally; }
            set { battleTally = value; }
        }
        /// <summary>
        /// The force's currently used supply
        /// </summary>
        public int SupplyUsed
        {
            get { return crusadeSupplyUser; }
            set { crusadeSupplyUser = value; }
        }
        /// <summary>
        /// The force's current supply limit
        /// </summary>
        public int SupplyLimit
        {
            get { return TotalSupply; }
            set { TotalSupply = value; }
        }
        /// <summary>
        /// The name of the crusade force
        /// </summary>
        public string ForceName
        {
            get { return RosterName; }
            set { RosterName = value; }
        }

        /// <summary>
        /// The name of the controlling player
        /// </summary>
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        /// <summary>
        /// The roster's id
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public CrusadeRoster()
        {

        }
    }
}
