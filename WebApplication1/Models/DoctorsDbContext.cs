﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DoctorsDbContext : DbContext
    {

        public DbSet<Doctor> Doctors { get; set; }

        public DoctorsDbContext() { }

        public DoctorsDbContext(DbContextOptions options):base(options)
        {

        }
    }
}
