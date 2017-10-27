namespace WorkoutApi.Models
{
    public class Exercise
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string MuscleGroup { get; set; }
        public string Description { get; set; }
    }
}