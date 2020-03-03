using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace AsteroidShooterGUI.Database_Models
{
    class UserDatabase : DbContext
    {
        //Create User Table
        public DbSet<User> Users { get; set; }
        public DbSet<HighScore> HighScores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=UserDatabase.db");
    }

    public class User
    {
        //User Table Attribute
        public int UserId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

        //Linked User & Highscore Relationship
        public List<HighScore> HighScore { get; } = new List<HighScore>();
    }

    public class HighScore
    {
        //Highscores Table Attributes
        public int HighScoreId { get; set; }
        public int highScore { get; set; }

        //User Foreign Key Constraint
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
