using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CallForceWithAuth.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int empID { get; set; }
        public String userEmail { get; set; }
        public String password { get; set; }
        public String userFirst { get; set; }
        public String userLast { get; set; }
    }
}