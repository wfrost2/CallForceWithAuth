using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CallForceWithAuth.Models
{
    [Table("MessageBoard")]
    public class MessageBoard
    {
        [Key]
        public int messageID { get; set; }
        public String question { get; set; }
        public String answer { get; set; }
        public String empID { get; set; }
        public String userID { get; set; }
        public String commenter { get; set; }
       
    }
}