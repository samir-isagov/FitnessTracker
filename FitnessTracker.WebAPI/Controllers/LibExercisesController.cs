using System.Collections.Generic;
using System.Threading.Tasks;
using FitnessTracker.EFDataAccess.DataAccess;
using FitnessTracker.EFDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitnessTracker.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibExercisesController : BaseController
    {
        public LibExercisesController(FitnessTrackerContext ctx) : base(ctx) { }

        // GET: api/<LibExercisesController>

        [HttpGet]
        public async Task<IEnumerable<LibExercise>> Get()
        {
            await LoadLibDataAsync();
            return await ctx.LibExercises.ToListAsync();
        }

        // GET api/<LibExercisesController>/5

        [HttpGet("{id}")]
        public async Task<LibExercise> Get(int id)
        {
            return await ctx.LibExercises.FirstOrDefaultAsync(x => x.Id == id);
        }

        // POST api/<LibExercisesController>

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LibExercisesController>/5

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LibExercisesController>/5

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
