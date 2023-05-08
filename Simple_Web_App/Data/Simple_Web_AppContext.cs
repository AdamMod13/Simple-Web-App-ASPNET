using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Simple_Web_App;

namespace Simple_Web_App.Data
{
    public class Simple_Web_AppContext : DbContext
    {
        public Simple_Web_AppContext (DbContextOptions<Simple_Web_AppContext> options)
            : base(options)
        {
        }

        public DbSet<Simple_Web_App.Game> Game { get; set; } = default!;
    }
}
