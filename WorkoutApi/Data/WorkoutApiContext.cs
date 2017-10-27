using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkoutApi.Models;

namespace WorkoutApi.Models
{
    public class WorkoutApiContext : DbContext
    {
        public WorkoutApiContext (DbContextOptions<WorkoutApiContext> options)
            : base(options)
        {
        }

        public DbSet<WorkoutApi.Models.Exercise> Exercise { get; set; }

        public DbSet<WorkoutApi.Models.Set> Set { get; set; }

        public DbSet<WorkoutApi.Models.User> User { get; set; }

        public DbSet<WorkoutApi.Models.UserInfo> UserInfo { get; set; }

        public DbSet<WorkoutApi.Models.Workout> Workout { get; set; }
    }
}
