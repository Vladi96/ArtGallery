using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ArtGallery.Pages
{
    public class EditModel : PageModel
    {
        private readonly AppDbCntext _db;

        public EditModel(AppDbCntext db)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Attach(ArtWork).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}