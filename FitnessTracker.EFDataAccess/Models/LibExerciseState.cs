using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.EFDataAccess.Models
{
    public class LibExerciseState
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
