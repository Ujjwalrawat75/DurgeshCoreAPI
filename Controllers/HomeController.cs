using DurgeshCoreAPI.Data;
using DurgeshCoreAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DurgeshCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {

        private readonly ApplicationDbContext _db;
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }
        [Route("Get/Emplist/all")]
        [HttpGet]
        public List<Employee> ShowList()
        {
            var res = _db.Employees.ToList();
            return res;
        }

    }
}
