using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Simple_Web_App;
using Simple_Web_App.Data;

namespace Simple_Web_App.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly Simple_Web_App.Data.Simple_Web_AppContext _context;

        public IndexModel(Simple_Web_App.Data.Simple_Web_AppContext context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Game != null)
            {
                Game = await _context.Game.ToListAsync();
            }
        }
    }
}
