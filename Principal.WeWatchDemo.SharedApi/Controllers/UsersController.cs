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
    public class UsersController : ControllerBase
    {



        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Users> Get()
        {
            using(var context = new WeWatchDbDemoContext())
            {
                return context.Users.ToList();
            }

        }
    }
}
