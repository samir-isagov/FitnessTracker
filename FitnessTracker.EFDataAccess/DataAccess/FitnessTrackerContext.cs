using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.EFDataAccess.DataAccess
{
    public class FitnessTrackerContext : DbContext
    {
        public FitnessTrackerContext(DbContextOptions options) : base(options) { }
    }
}
