using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Mission12.Models
{
    public class GroupContext : DbContext
    {
        public GroupContext (DbContextOptions<GroupContext> options) : base (options)
        {

        }

        public DbSet<GroupContext> Responses { get; set; }
        public DbSet<Group> Groups { get; set; }
    }



}
