using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using GolfStore.Models.Models;
using GolfStore.DataAccess.DataAccess;
using GolfStore.DataAccess.Repositorys;

namespace GolfStore_L00181486.Pages.Admins.Clubs
{
    public class CreateModel : PageModel
    {
        private readonly IClubRepo _clubRepo;
        private readonly IBrandRepo _brandRepo;
        private readonly IClubtypeRepo _clubtypeRepo;

        // Expose SelectList properties with the exact names used in the Razor page
        public SelectList brandSelect { get; set; }
        public SelectList ClubTypeList { get; set; }

        public CreateModel(IClubRepo clubRepo, IBrandRepo brandRepo, IClubtypeRepo clubtypeRepo)
        {
            _clubRepo = clubRepo;
            _brandRepo = brandRepo;
            _clubtypeRepo = clubtypeRepo;
        }

        public Club Club { get; set; }

        // Populate select lists on GET
        public void OnGet()
        {
            brandSelect = new SelectList(_brandRepo.GetAll(), "BrandId", "Name");
            ClubTypeList = new SelectList(_clubtypeRepo.GetAll(), "TypeId", "Type");
        }

        public IActionResult OnPost(Club club)
        {
            if (!ModelState.IsValid)
            {
                // Repopulate the selects before re-rendering the page
                brandSelect = new SelectList(_brandRepo.GetAll(), "BrandId", "Name");
                ClubTypeList = new SelectList(_clubtypeRepo.GetAll(), "TypeId", "Type");

                return Page();
            }

            _clubRepo.Add(club);
            _clubRepo.SaveAll();

            return RedirectToPage("Index");
        }
    }
}