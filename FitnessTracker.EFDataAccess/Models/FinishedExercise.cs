namespace FitnessTracker.EFDataAccess.Models
{
    public class FinishedExercise
    {
        public int Id { get; set; }
        public int Duration { get; set; }
        //public int Calories { get; set; }
        public LibExerciseState State { get; set; }
        public LibExercise Exercise { get; set; }
    }
}
