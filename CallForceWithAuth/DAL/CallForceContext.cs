using CallForceWithAuth.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CallForceWithAuth.DAL
{
    public class CallForceContext : DbContext
    {
        public CallForceContext() : base("CallForceContext")
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MessageBoard> MessageBoards { get; set; }

    }
}