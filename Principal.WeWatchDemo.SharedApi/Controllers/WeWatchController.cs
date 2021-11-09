using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Principal.WeWatchDemo.Domain.ModelDtos;
using Principal.WeWatchDemo.Domain.Models;
using Principal.WeWatchDemo.Domain.Repository;
using Principal.WeWatchDemo.Domain.responseModels;
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

        [HttpPost("login")]
        public Guid login(string userName, string password)
        {
            return Guid.NewGuid();
        }

        [HttpGet("getIncidentDetail/{id}")]
        public ActionResult<ItemModel> getIncidentDetail(int id, [FromBody]string token)
        {
            throw new NotImplementedException();
        }

        [HttpGet("getEvidenceDetail/{id}")]
        public ActionResult<ItemModel> getEvidenceDetail(int id, [FromBody] string token)
        {
            throw new NotImplementedException();
        }

        [HttpGet("getRequestedRows/{id}")]
        public ActionResult<List<ItemGridModel>> getRequestedRows(int id, [FromBody] string token)
        {
            throw new NotImplementedException();
        }

        [HttpGet("getIncidentList")]
        public ActionResult<List<ItemGridModel>> getIncidentList(int page, int rowCount, [FromBody] string token)
        {
            throw new NotImplementedException();
        }

        [HttpGet("getEvidenceList")]
        public ActionResult<List<ItemGridModel>> getEvidenceList(int page, int rowCount, [FromBody] string token)
        {
            throw new NotImplementedException();
        }

        [HttpPost("saveIncident")]
        public ActionResult<ItemModel> saveIncident(ItemModel itemModel, [FromBody] string token)
        {
            throw new NotImplementedException();
        }

        [HttpPost("saveEvidence")]
        public ActionResult<ItemModel> saveEvidence(ItemModel itemModel, [FromBody] string token)
        {
            throw new NotImplementedException();
        }

        [HttpPost("rejectRequest")]
        public ActionResult<List<BaseResponseModel>> rejectRequest(int id, [FromBody] string token)
        {
            throw new NotImplementedException();
        }

        [HttpPost("generateReport")]
        public ActionResult<ReportsDto> generateReport(int id, [FromBody] string token)
        {
            throw new NotImplementedException();
        }
    }
}
