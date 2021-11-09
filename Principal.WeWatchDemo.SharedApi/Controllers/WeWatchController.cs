using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Principal.WeWatchDemo.Domain.ModelDtos;
using Principal.WeWatchDemo.Domain.Models;
using Principal.WeWatchDemo.Domain.Repository;
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
        private readonly ILogger<WeWatchController> _logger;
        private readonly WeWatchDemoDbContext _context;

        public WeWatchController(ILogger<WeWatchController> logger, WeWatchDemoDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        private IWeWatchRepo itemModels = new WeWatchRepo();

        //Incidents: GetAll, Getdetail, Upsert:

        // Get All Incidents
        [HttpGet("getIncidentList")]
        public ActionResult<IEnumerable<ItemModel>> getIncidentList()
        {
            return itemModels.GetAllItemModels();
        }


        // Incident Detail
        [HttpGet("getIncidentDetail/{id}")]
        public ActionResult<ItemModel> getIncidentDetail(int id) 
        {
            return itemModels.GetItemModelDetail(id);
        }

        [HttpGet("saveIncident/{id}")]
        public async Task<ActionResult<Incidents>> saveIncident(int? id)
        {
            throw new NotImplementedException(); 
        }






    }
}
