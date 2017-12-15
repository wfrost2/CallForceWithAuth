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
        public int? empID { get; set; }

        [ForeignKey("User")]
        public virtual int? userID { get; set; }
        public virtual User User { get; set; }
    }
}