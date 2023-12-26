using AdeptumCore;
using AdeptumCore.Database;
using Astropathia.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Astropathia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RosterController : ControllerBase
    {
        RosterRepository repository;
        public RosterController()
        {
            repository = new RosterRepository();
        }

        //Create
        [HttpPost("CreateRoster")]
        public bool CreateRoster(CrusadeRoster crusadeRoster) 
        {
            return repository.Create(crusadeRoster);
        }

        //Read
        [HttpGet("GetAllRosters")]
        public List<CrusadeRoster> GetAll() 
        {
            return repository.GetAll();
        }
        [HttpGet("GetPlayerRosters")]
        public List<CrusadeRoster> GetByPlayer(string playerName) 
        {
            return repository.GetByPlayerName(playerName);
        }
        [HttpGet("GetRoster")]
        public CrusadeRoster GetById(int id) 
        {
            return repository.Get(id);
        }
        [HttpGet("Count")]
        public int CountRosters() 
        {
            return repository.Count();
        }

        //Update
        [HttpPatch("UpdateRoster")]
        public bool UpdateRoster(CrusadeRoster roster) 
        {
            return repository.Update(roster);
        }

        //Delete
        [HttpDelete("DeleteRoster")]
        public bool DeleteRoster(int id) 
        {
            return repository.Delete(id);
        }
    }
}
