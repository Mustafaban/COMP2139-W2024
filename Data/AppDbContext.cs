using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using COMP2139_Labs.Areas.ProjectManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP2139_Labs.Data
{
    // You need a connection string for any connection to the database
    public class AppDbContext : IdentityDbContext
    {
        /* March 13, 2024
         * DbContextOptions<AppDbContext> options lets you configure the behavior of the AppDbContext instance, like
         * specifying the database provider, the connection string, ...
         * 
         * base(options) properly initializes the base class (DbContext) with the configuration (options). Needed when
         * making a subclass of DbContext (in this case, AppDbContext) to make sure it's ready to interact with the database
         */
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }

        // Because we added a new model, we have to add it here
        public DbSet<ProjectTask> ProjectTasks { get; set; }

        public DbSet<ProjectComment> ProjectComments { get; set; }
    }
}
