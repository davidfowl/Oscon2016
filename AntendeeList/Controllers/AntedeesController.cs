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
        
        [HttpDelete]
        public void Delete(Atendee atendee)
        {

        }
    }
}
