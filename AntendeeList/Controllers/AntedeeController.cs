using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication
{
    public class AtendeeController : Controller
    {
        private readonly WorkshopContext _context;
        public AtendeeController(WorkshopContext context)
        {
            _context = context;
        }

        [HttpGet("/")]
        public Task<List<Atendee>> Get()
        {
            return _context.Atendees.ToListAsync();
        }
    }
}
