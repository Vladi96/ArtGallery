using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArtGallery.Pages
{
    public class AddArtWorkModel : PageModel
    {
        private readonly AppDbCntext _db;

        public AddArtWorkModel(AppDbCntext db)
        {
            _db = db;
        }

        [BindProperty]
        public ArtWork ArtWork { get; set; }


        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.ArtWorks.Add(ArtWork);
            await _db.SaveChangesAsync();
            return RedirectToPage("/Index");
        }
    }
}