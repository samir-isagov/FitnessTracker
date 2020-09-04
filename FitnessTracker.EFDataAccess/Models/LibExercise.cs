using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.EFDataAccess.Models
{
    public class LibExercise
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "NVARCHAR2(50)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "NUMBER(4)")]
        public byte Calories { get; set; }

        [Required]
        [Column(TypeName = "NUMBER(4)")]
        public byte Duration { get; set; }
    }
}
