namespace WorkoutApi.Models
{
    public class Set
    {
        public int ID { get; set; }
        public int WorkoutId { get; set; }
        public int ExcerciseId { get; set; }
        public decimal Weight { get; set; }
        public int RepetitionsCount { get; set; }
    }
}