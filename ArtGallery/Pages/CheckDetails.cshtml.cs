using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArtGallery.Pages
{
    public class CheckDetailsModel : PageModel
    {
        private readonly AppDbCntext _db;

        public CheckDetailsModel(AppDbCntext db)
        {
            _db = db;
        }
    
        [BindProperty]
        public ArtWork ArtWork { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            ArtWork = await _db.ArtWorks.FindAsync(id);
            if (ArtWork == null)
            {
                return RedirectToPage("/Index");
            }
            return Page();
        }

    }
}