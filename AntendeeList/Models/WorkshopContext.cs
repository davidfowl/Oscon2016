using System;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication
{
    public class WorkshopContext : DbContext
    {
        public WorkshopContext(DbContextOptions<WorkshopContext> options) : base(options) { }
        public DbSet<Attendee> Attendees { get; set; }
    }
}
