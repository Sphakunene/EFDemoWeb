using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFLibraryDataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace EFLibraryDataAccess.Data_Access
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options): base(options) { }

        public DbSet<Person> persons { get; set; }

        public DbSet<Email> emails { get; set; }

        public DbSet<Address> addresses { get; set; }


    }
}
