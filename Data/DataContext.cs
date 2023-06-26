/*
    Create a database
        In Package Manager Console, use "Add-Migration InitialCreate". (Make sure there's no Migration folder existing already)
        Once build success, you need to use command "Update-Database"
            This will actually create the database.
        "dotnet run seeddata" to actually seed the data
        
 */

using Microsoft.EntityFrameworkCore;
using PetApp.Models;

namespace PetApp.Data
{
    public class DataContext : DbContext // from EntityFrameworkCore
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) // base shoves data that is going to be recieved from an outside class into our DbContext
        { 
        }

        // Tell the context what our tables are

        public DbSet<Address> Addresses { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<PetOwner> PetsOwners { get; set; }
        public DbSet<Species> Species { get; set; }
        public DbSet<Veterinarian> Veterinarians { get; set; }

        // Customize the tables without having to go into the database for many to many relationships
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tells EntityFramework that we need to link these two ID's together
            modelBuilder.Entity<PetOwner>()
                .HasKey(po => new { po.PetId, po.OwnerId });
            modelBuilder.Entity<PetOwner>()
                .HasOne(p => p.Pet)
                .WithMany(po => po.PetOwners)
                .HasForeignKey(p => p.PetId);
            modelBuilder.Entity<PetOwner>()
                .HasOne(o => o.Owner)
                .WithMany(po => po.PetOwners)
                .HasForeignKey(o => o.OwnerId);
        }
    }
}
