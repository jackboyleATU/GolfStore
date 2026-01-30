using GolfStore.DataAccess.DataAccess;
using GolfStore.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace GolfStore_L00181486.Pages.Admins.Clubs
{
    public class DeleteModel : PageModel
    {
        private readonly AppDBContext _dbContext;

        public SelectList brandSelect { get; set; }
        public SelectList ClubTypeList { get; set; }

        public DeleteModel(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Club Club { get; set; }
        public void OnGet(int id)
        {
            brandSelect = new SelectList(_dbContext.Brands.AsNoTracking().ToList(), "BrandId", "Name");
            ClubTypeList = new SelectList(_dbContext.Clubtypes.AsNoTracking().ToList(), "TypeId", "Type");

            Club = _dbContext.Clubs.Find(id);
        }

        public async Task<IActionResult> OnPost(Club club)
        {
            if (!ModelState.IsValid)
            {
                // Repopulate the selects before re-rendering the page
                brandSelect = new SelectList(await _dbContext.Brands.AsNoTracking().ToListAsync(), "BrandId", "Name");
                ClubTypeList = new SelectList(await _dbContext.Clubtypes.AsNoTracking().ToListAsync(), "TypeId", "Type");

                return Page();
            }

            if (ModelState.IsValid)
            {
                _dbContext.Clubs.Remove(club);
                await _dbContext.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}

