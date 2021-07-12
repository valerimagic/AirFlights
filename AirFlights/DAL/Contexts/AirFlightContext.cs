using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DAL.Connections;
using DAL.Entities;

namespace DAL.Contexts
{
    public class AirFlightContext : DbContext
    {
        public DbSet<Airplanes> Airplaneses { get; set; }
        public DbSet<Flights> Flightses { get; set; }
        public DbSet<Passengers> Passengerses { get; set; }
        public DbSet<RegistrationDetails> RegistrationDetailses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(AirFlightConnString.DefaultConnection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
