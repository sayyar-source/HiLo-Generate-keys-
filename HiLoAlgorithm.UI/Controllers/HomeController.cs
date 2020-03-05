using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HiLoAlgorithm.Model.Models;
using HiLoAlgorithm.Service.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace HiLoAlgorithm.UI.Controllers
{
    [Route("api/[Controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRepository _repository;
        public HomeController(ILogger<HomeController> logger, IUserRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("adduser")]
        public IActionResult AddUser(User user)
        {
           var result= _repository.AddUser(user);
            return Ok(result);
        }

     
    }
}
