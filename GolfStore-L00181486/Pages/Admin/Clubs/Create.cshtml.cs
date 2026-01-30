using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using GolfStore.Models.Models;
using GolfStore.DataAccess.DataAccess;

namespace GolfStore_L00181486.Pages.Admins.Clubs
{
    public class CreateModel : PageModel
    {
        private readonly AppDBContext _dbContext;

        // Expose SelectList properties with the exact names used in the Razor page
        public SelectList brandSelect { get; set; }
        public SelectList ClubTypeList { get; set; }

        public CreateModel(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Club Club { get; set; }

        // Populate select lists on GET
        public async Task OnGetAsync()
        {
            brandSelect = new SelectList(await _dbContext.Brands.AsNoTracking().ToListAsync(), "BrandId", "Name");
            ClubTypeList = new SelectList(await _dbContext.Clubtypes.AsNoTracking().ToListAsync(), "TypeId", "Type");
        }

        public async Task<IActionResult> OnPostAsync(Club club)
        {
            if (!ModelState.IsValid)
            {
                // Repopulate the selects before re-rendering the page
                brandSelect = new SelectList(await _dbContext.Brands.AsNoTracking().ToListAsync(), "BrandId", "Name");
                ClubTypeList = new SelectList(await _dbContext.Clubtypes.AsNoTracking().ToListAsync(), "TypeId", "Type");

                return Page();
            }

            await _dbContext.Clubs.AddAsync(club);
            await _dbContext.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}