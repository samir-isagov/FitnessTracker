using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.EFDataAccess.Models
{
    public class FinishedExercise
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(4)]
        public int Duration { get; set; }

        [Required]
        [MaxLength(4)]
        public int Calories { get; set; }

        public LibExerciseState State { get; set; }
        public LibExercise Exercise { get; set; }
    }
}
