using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.EFDataAccess.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string EmailAddress { get; set; }

        [Required]
        [MinLength(3), MaxLength(8)]
        public string Password { get; set; }
        public List<FinishedExercise> FinishedExercises { get; set; }
    }
}
