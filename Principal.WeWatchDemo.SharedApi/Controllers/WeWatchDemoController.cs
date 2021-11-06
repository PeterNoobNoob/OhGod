using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Principal.WeWatchDemo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Principal.WeWatchDemo.SharedApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeWatchDemoController : ControllerBase
    {



        private readonly ILogger<UsersController> _logger;

        public WeWatchDemoController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IEnumerable<Incidents> getIncidentList()
        {
            using(var context = new WeWatchDbDemoContext())
            {
                return context.Incidents.ToList();
            }

        }

        //[HttpGet]
        //public IEnumerable<Evidences> getEvidenceList()
        //{
        //    using (var context = new WeWatchDbDemoContext())
        //    {
        //        return context.Evidences.ToList();
        //    }

        //}
    }
}
