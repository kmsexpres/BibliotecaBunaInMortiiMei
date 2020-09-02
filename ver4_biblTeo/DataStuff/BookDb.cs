using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ver4_biblTeo
{
    public class BookDb : DbContext
    {
        DbSet<Book> Books { get; set; }
    }
}
