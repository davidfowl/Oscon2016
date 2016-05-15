using System;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication
{
    public class WorkshopContext : DbContext
    {
        public WorkshopContext(DbContextOptions<WorkshopContext> options) : base(options) { }
        public DbSet<Atendee> Atendees { get; set; }
    }
}
