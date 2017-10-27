using System;
using System.ComponentModel.DataAnnotations;

namespace WorkoutApi.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int UserStatus { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Gender { get; set; }
        public int UserLevel { get; set; }
    }
}