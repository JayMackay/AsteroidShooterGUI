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

        //SQL Scaffolding Parameters
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(
                "Data Source = localhost; " +
                "Initial Catalog = UserDatabase; " +
                "Persist Security Info = True; " +
                "User ID = SA; Password = Passw0rd2018");
                
                //Package Manager Command To Initialize New Database Instance
                //Add-Migration InitialUserDatabase
                //Update-Database
    }

    //User Table
    public class User
    {
        //User Table Attributes
        public int UserId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        //Linked User & Highscore Relationship
        public List<HighScore> HighScore { get; } = new List<HighScore>();
    }

    //Highscore Table
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
