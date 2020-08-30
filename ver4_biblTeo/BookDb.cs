using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ver4_biblTeo
{
    class BookDb : DbContext
    {
        public DbSet<Book> Books{ get; set; }
    }
}
