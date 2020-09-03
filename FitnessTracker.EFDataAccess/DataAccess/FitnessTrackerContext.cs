using FitnessTracker.EFDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.EFDataAccess.DataAccess
{
    public class FitnessTrackerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(@"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=192.168.78.128)(PORT=1521)))(CONNECT_DATA=(SID=orcl)));User ID=FITNESS_TRACKER;Password=123");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<LibExerciseState> LibExerciseStates { get; set; }
        public DbSet<LibExercise> LibExercises { get; set; }
        public DbSet<FinishedExercise> FinishedExercises { get; set; }
    }
}
