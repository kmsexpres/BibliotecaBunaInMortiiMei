using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ver4_biblTeo.DataStuff
{
    public class ClientDb : DbContext
    {
        DbSet<Client> Clients { get; set; }

        
    }
}
