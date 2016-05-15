using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication
{
    [Route("/api/[controller]")]
    public class AtendeesController : Controller
    {
        private readonly WorkshopContext _context;
        public AtendeesController(WorkshopContext context)
        {
            _context = context;
        }

        [HttpGet]
        public Task<List<Atendee>> Get()
        {
            return _context.Atendees.ToListAsync();
        }

        [HttpPost]
        public Task Post([FromBody]Atendee atendee)
        {
            _context.Atendees.Add(atendee);
            return _context.SaveChangesAsync();
        }
        
        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
            var atendee = new Atendee
            {
                Id = id
            };
            _context.Attach(atendee);
            _context.Remove(atendee);
            return _context.SaveChangesAsync();
        }
    }
}
