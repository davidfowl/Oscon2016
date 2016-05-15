using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication
{
    public class AtendeeController : Controller
    {
        [HttpGet("/")]
        public IEnumerable<Atendee> Get()
        {
            return Enumerable.Empty<Atendee>();
        }
    }
}
