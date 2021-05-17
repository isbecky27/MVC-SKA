using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeepAccount.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KeepAccount.Controllers
{
    [Route("api/")] //[controller]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly List<Expenditure> _data = KeepAccountController.Data;

        // GET: api/records
        [Route("records")]
        [HttpGet]
        public JsonResult Records()
        {
            return new JsonResult(_data);
        }
    }
}
