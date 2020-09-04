using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FitnessTracker.EFDataAccess.DataAccess;
using FitnessTracker.EFDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using static System.IO.File;

namespace FitnessTracker.WebAPI.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        private protected FitnessTrackerContext ctx;

        public BaseController(FitnessTrackerContext ctx)
        {
            this.ctx = ctx;
        }

        private protected async Task LoadLibDataAsync()
        {
            if (!ctx.LibExercises.Any())
            {
                List<LibExercise> exercises;

                await using (FileStream fs = OpenRead("libData.json"))
                {
                    exercises = await JsonSerializer.DeserializeAsync<List<LibExercise>>(fs);
                }

                await ctx.LibExercises.AddRangeAsync(exercises);
                await ctx.SaveChangesAsync();
            }
        }
    }
}
