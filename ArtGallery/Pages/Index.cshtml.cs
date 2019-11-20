using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ArtGallery.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbCntext _db;

        public IndexModel(AppDbCntext db)
        {
            _db = db;
        }

        public IList<ArtWork> ArtWorks { get; private set; }
        public async Task OnGetAsync()
        {
            ArtWorks = await _db.ArtWorks.AsNoTracking().ToListAsync();
        }
    }
}
