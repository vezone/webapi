using System;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class PlayersContext : DbContext 
    {
        public DbSet<Player> Players { get; set; }
    }
}