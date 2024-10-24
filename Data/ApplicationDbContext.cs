
using Microsoft.EntityFrameworkCore;
using aafeben.Models;

namespace aafeben.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}


        // set db relations and datasets
        public DbSet<BlogModel> Blogs { get; set; }
        public DbSet<OpportunityModel> Opportunities {get; set;}
        public DbSet<UserModel> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        // modelBuilder.Entity<Post>()
        //     .HasOne(e => e.Blog)
        //     .WithMany(e => e.Posts)
        //     .HasForeignKey(e => e.BlogId)
        //     .IsRequired();  
        }
                
    }
}

// dotnet aspnet-codegenerator controller -name OpportunityController -m OpportunityModel -dc aafeben.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlServer