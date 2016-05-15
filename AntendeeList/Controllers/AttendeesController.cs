using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication
{
    [Route("/api/[controller]")]
    public class AttendeesController : Controller
    {
        private readonly WorkshopContext _context;
        public AttendeesController(WorkshopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public Task<List<Attendee>> Get()
        {
            return _context.Attendees.ToListAsync();
        }
        
        [HttpGet("{id:int}")]
        public Task<Attendee> Get(int id)
        {
            return _context.Attendees.SingleOrDefaultAsync(a => a.Id == id);
        }

        [HttpPost]
        public Task Post([FromBody]Attendee atendee)
        {
            _context.Attendees.Add(atendee);
            return _context.SaveChangesAsync();
        }
        
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
            var atendee = new Attendee
            {
                Id = id
            };
            _context.Attach(atendee);
            _context.Remove(atendee);
            return _context.SaveChangesAsync();
        }
    }
}
