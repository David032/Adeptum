using AdeptumCore;
using AdeptumCore.Database.Models;
using Astropathia.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Astropathia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitsController : ControllerBase
    {
        UnitRepository repository;
        public UnitsController()
        {
            repository = new UnitRepository();
        }

        //Create
        [HttpPost("CreateUnit")]
        public bool CreateUnit(CrusadeCard crusadeUnit)
        {
            return repository.Create(crusadeUnit);
        }

        //Read
        [HttpGet("GetAllUnits")]
        public List<CrusadeCard> GetAll()
        {
            return repository.GetAll();
        }
        [HttpGet("GetPlayerUnits")]
        public List<CrusadeCard> GetByPlayer(string playerName)
        {
            return repository.GetByPlayer(playerName);
        }
        [HttpGet("GetUnit")]
        public CrusadeCard GetById(int id)
        {
            return repository.Get(id);
        }

        //Update
        [HttpPatch("UpdateUnit")]
        public bool UpdateUnit(CrusadeCard unit)
        {
            return repository.Update(unit);
        }

        //Delete
        [HttpDelete("DeleteUnit")]
        public bool DeleteUnit(int id)
        {
            return repository.Delete(id);
        }
    }
}
