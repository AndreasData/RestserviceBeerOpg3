using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Beerlibrary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestserviceBeer.Manager;

namespace RestserviceBeer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private BeerManager manager = new BeerManager();
        // GET: api/Beer
        [HttpGet]
        public IEnumerable<Beer> Get()
        {
            return manager.GetAll();
        }

        // GET: api/Beer/5
        [HttpGet("{id}")]
        public Beer Get(int Id)
        {
            return manager.GetByID(Id);
        }

        // POST: api/Beer
        [HttpPost]
        public Beer Post([FromBody] Beer value)
        {
            return manager.Add(value);
        }

        // PUT: api/Beer/5
        [HttpPut("{Id}")]
        public Beer Put(int Id, [FromBody] Beer value)
        {
            return manager.Update(Id, value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Beer Delete(int Id)
        {
            return manager.Delete(Id);
        }
    }
}
