using System;
using System.Collections.Generic;

namespace WorkoutApi.Models
{
    public class Workout
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime EndTime { get; set; }
        public virtual ICollection<Set> SetsList { get; set; }
    }
}