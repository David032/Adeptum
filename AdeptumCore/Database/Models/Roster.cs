using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptumCore.Database.Models
{
    public class Roster
    {
        public int Id { get; set; }
        public string RosterName { get; set; }
        public string PlayerName {  get; set; }
        public int CrusadeSupplyLimit {  get; set; }
        public int CrusadeSupplyUsed {  get; set; }

        public int BattleTally { get; set; }
        public int BattlesWon { get; set; }
        public int RequisitionPoints { get; set; }

        public string? Records { get; set; }

        public List<CrusadeUnit> Units { get; set; }

        public Roster(string RosterName, string PlayerName, List<CrusadeUnit> units, 
            int startingSupply = 1000)
        {
            this.RosterName = RosterName;
            this.PlayerName = PlayerName;
            this.Units = units;
            this.CrusadeSupplyLimit = startingSupply;
        }
    }
}
