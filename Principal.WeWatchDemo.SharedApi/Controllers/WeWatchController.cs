using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Principal.WeWatchDemo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Principal.WeWatchDemo.SharedApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeWatchController : ControllerBase
    {


        private readonly WeWatchDbDemoContext _context;
        private readonly ILogger<WeWatchController> _logger;

        public WeWatchController(ILogger<WeWatchController> logger, WeWatchDbDemoContext context)
        {
            _logger = logger;
            _context = context;
        }


        // GET: api/Incidents
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Incidents>>> GetIncidents()
        {
            return await _context.Incidents.ToListAsync();
        }






    }
}
