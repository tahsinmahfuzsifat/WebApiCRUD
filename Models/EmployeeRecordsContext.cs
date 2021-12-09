using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCRUD.Models
{
    public class EmployeeRecordsContext:DbContext
    {
        public EmployeeRecordsContext(DbContextOptions<EmployeeRecordsContext> options)
           : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; } = null!;
    }
}
