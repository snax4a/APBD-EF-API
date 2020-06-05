using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly DoctorsDbContext _context;
        public DoctorsController(DoctorsDbContext context)
        {
            _context = context;
        }

        public IActionResult GetDoctors()
        {
            return Ok(_context.Doctors.ToList());
        }
    }
}