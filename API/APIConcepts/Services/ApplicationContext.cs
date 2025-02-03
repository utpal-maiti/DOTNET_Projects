using APIConcepts.Models;

using Microsoft.EntityFrameworkCore;

using System;

namespace APIConcepts.Services
{
    public class ApplicationContext :DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}