using mas_services.Models;
using Microsoft.EntityFrameworkCore;

namespace mas_services.Entity
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options) { }
        public DbSet<MAS_position>? MAS_POSITION { get; set; }
        public DbSet<MAS_type_identification>? MAS_TYPE_IDENTIFICATION { get; set; }
        //public DbSet<MAS_type_industry>? MAS_TYPE_INDUSTRY { get; set; }
        public DbSet<MAS_person_company>? MAS_PERSON_COMPANY { get; set; }
        //public DbSet<MAS_company>? MAS_COMPANY { get; set; }
        //public DbSet<MAS_user_company>? MAS_USER_COMPANY { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MAS_person_company>()
                .HasOne(p => p.MAS_Type_Identification)
                .WithMany()
                .HasForeignKey(p => p.PER_FK_TYPE_IDENTIFICATION);
            modelBuilder.Entity<MAS_person_company>()
                .HasOne(p => p.MAS_position)
                .WithMany()
                .HasForeignKey(p => p.PER_FK_POSITION);
         
        }
    }
}
