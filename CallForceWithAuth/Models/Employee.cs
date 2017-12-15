using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CallForceWithAuth.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int empID { get; set; }
        public String empName { get; set; }
        public int empYrsWrked { get; set; }
        public String empDep { get; set; }
        public int empSales { get; set; }
        public int empGoal { get; set; }
        public String empImg { get; set; }
    }
}