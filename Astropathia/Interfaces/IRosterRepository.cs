using AdeptumCore;
using AdeptumCore.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astropathia.Interfaces
{
    public interface IRosterRepository
    {
        //Create
        public bool Create(CrusadeRoster roster);
        //Read
        public List<CrusadeRoster> GetAll();
        public CrusadeRoster Get(int id);
        public List<CrusadeRoster> GetByPlayerName(string playerName);
        //Update
        public bool Update(CrusadeRoster roster);
        //Delete
        public bool Delete(int id);

    }
}
