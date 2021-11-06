using Microsoft.AspNetCore.Mvc;
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



        private readonly ILogger<UsersController> _logger;

        public WeWatchController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IEnumerable<Incidents> getIncidentList()
        {
            using (var context = new WeWatchDbDemoContext())
            {
                return context.Incidents.ToList();
            }

        }

        //[HttpGet]
        //public Incidents getIncidentDetail(int id)
        //{
        //    using (var context = new WeWatchDbDemoContext())
        //    {
        //        return context.Incidents.Where(incident => incident.Id == id).FirstOrDefault();
        //    }
        //}

        //[HttpPost]
        //public Incidents saveIncident(int? id)
        //{
        //    if(id == null)
        //    {
        //        return new Incidents();
        //    }

        //    using (var context = new WeWatchDbDemoContext())
        //    {
        //        var incident = context.Incidents.Where(incident => incident.Id == id).FirstOrDefault(); // toto este dokoncit, nie je spravne. Ulozit!
        //        context.SaveChanges();
        //        return context.Incidents.Where(incident => incident.Id == id).FirstOrDefault(); // toto este dokoncit, nie je spravne. Ulozit! 
        //    }
        //}

        //[HttpGet]
        //public IEnumerable<Evidences> getEvidencesList()
        //{
        //    using (var context = new WeWatchDbDemoContext())
        //    {
        //        return context.Evidences.ToList();
        //    }

        //}

        //[HttpGet]
        //public Evidences getEvidencesDetail(int id)
        //{
        //    using (var context = new WeWatchDbDemoContext())
        //    {
        //        return context.Evidences.Where(incident => incident.Id == id).FirstOrDefault();
        //    }
        //}


    }
}
