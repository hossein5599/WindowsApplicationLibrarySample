using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppLibrarySample.Models;

namespace WindowsAppLibrarySample.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("name=LibraryConnection")
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
