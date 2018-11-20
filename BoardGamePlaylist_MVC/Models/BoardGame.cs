using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BoardGamePlaylist_MVC.Models
{
    public class BoardGame
    {
        [Key]
        public int BoardGameID { get; set; }
        public int PlayOrder { get; set; }
        public string Name { get; set; }
        public string MainMechanism { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; }
        public float Rating { get; set; }
    }

    public class BoardGameDBContext : DbContext
    {
        public DbSet<BoardGame> BoardGames { get; set; }
    }
}