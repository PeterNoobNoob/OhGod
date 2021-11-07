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


        // GET: api/WeWatch/getIncidentList
        [HttpGet("getIncidentList")]
        public async Task<ActionResult<IEnumerable<Incidents>>> getIncidentList()
        {
            return await _context.Incidents.ToListAsync();
        }



        // Incident Detail
        [HttpGet("getIncidentDetail/{id}")]
        public async Task<ActionResult<Incidents>> getIncidentDetail(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var incidents = _context.Incidents
                                .Include(inc => inc.Evidences)
                                .Include(inc => inc.Medias)
                                .Include(inc => inc.Reports)
                                .Where(inc => inc.Id == id)
                                .FirstOrDefault();

            if (incidents == null)
            {
                return NotFound();
            }

            return incidents;
        }

        // Malo by to byt spravne
        [HttpPost("saveIncident/{id}")]
        public async Task<ActionResult<Incidents>> saveIncident(int? id)
        {
            if (id == null || id <= 0)
            {
                Incidents incident = new Incidents();

                _context.Incidents.Add(incident);
                _context.SaveChanges();

                return incident;
            }

            var incidents = _context.Incidents
                                .Include(inc => inc.Evidences)
                                .Include(inc => inc.Medias)
                                .Include(inc => inc.Reports)
                                .Where(inc => inc.Id == id)
                                .FirstOrDefault();

            if (incidents == null)
            {
                return NotFound();
            }

            _context.SaveChanges();

            return incidents;
        }




    }
}
