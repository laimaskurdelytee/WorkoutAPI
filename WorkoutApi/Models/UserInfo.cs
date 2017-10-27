using System;
using System.Collections.Generic;

namespace WorkoutApi.Models
{
    public class UserInfo
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public decimal Mass { get; set; }
        public decimal Height { get; set; }
        public int Age { get; set; }
        public decimal WaistSize { get; set; }
        public decimal BicepsSize { get; set; }
        public decimal ThightSize { get; set; }
        public decimal ChestSize { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<UserInfo> UserHistory { get; set; }
        public virtual ICollection<Workout> WorkoutHistory { get; set; }

    }
}