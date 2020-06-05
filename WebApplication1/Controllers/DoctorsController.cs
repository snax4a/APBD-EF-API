using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs.requests;
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
            var doctors =  _context.Doctors.Select(d => new Doctor
            {
                IdDoctor = d.IdDoctor,
                FirstName = d.FirstName,
                LastName = d.LastName,
                Email = d.Email
            }).ToList();

            return Ok(doctors);
        }

        [HttpPost]
        public IActionResult AddDoctor(AddDoctorRequest request)
        {
            Doctor doctor = new Doctor
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email
            };

            _context.Add(doctor);
            _context.SaveChanges();

            string uri = $"/api/doctors/{doctor.IdDoctor}";

            return Created(uri,doctor);
        }

        [HttpPut("{idDoctor}")]
        public IActionResult UpdateDoctor(UpdateDoctorRequest request, int idDoctor)
        {
            var doctor = new Doctor { IdDoctor = idDoctor };

            _context.Attach(doctor);

            if (request.FirstName != null)
            {
                doctor.FirstName = request.FirstName;
                _context.Entry(doctor).Property("FirstName").IsModified = true;
            }

            if (request.LastName != null)
            {
                doctor.LastName = request.LastName;
                _context.Entry(doctor).Property("LastName").IsModified = true;
            }

            if (request.Email != null)
            {
                doctor.Email = request.Email;
                _context.Entry(doctor).Property("Email").IsModified = true;
            }

            _context.SaveChanges();

            string uri = $"/api/doctors/{doctor.IdDoctor}";

            return Created(uri, doctor);
        }

        [HttpDelete("{idDoctor}")]
        public IActionResult DeleteDoctor(int idDoctor)
        {
            var doctor = new Doctor { IdDoctor = idDoctor };

            _context.Attach(doctor);
            _context.Remove(doctor);
            _context.SaveChanges();

            return Ok();
        }
    }
}