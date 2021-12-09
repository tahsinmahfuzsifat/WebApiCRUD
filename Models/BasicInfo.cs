using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCRUD.Models
{
    public class EmployeeBasicInfo
    {
        [Key]
        public int Id { get; set; }
        public string Designation { get; set; }
        public string Salary { get; set; }
        public string BankAcc { get; set; }
    }
}
