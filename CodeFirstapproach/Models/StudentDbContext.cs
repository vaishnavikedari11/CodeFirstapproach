﻿using Microsoft.EntityFrameworkCore;

namespace CodeFirstapproach.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
