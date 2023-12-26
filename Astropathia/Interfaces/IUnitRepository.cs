using AdeptumCore;
using AdeptumCore.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astropathia.Interfaces
{
    public interface IUnitRepository
    {
        //Create
        public bool Create(CrusadeCard unit);
        //Read
        public List<CrusadeCard> GetAll();
        public CrusadeCard Get(int id);
        public List<CrusadeCard> GetByPlayer(string playerName);
        //Update
        public bool Update(CrusadeCard unit);
        //Delete
        public bool Delete(int id);
    }
}
