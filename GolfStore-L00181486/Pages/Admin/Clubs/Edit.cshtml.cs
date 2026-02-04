using GolfStore.DataAccess.DataAccess;
using GolfStore.DataAccess.Repositorys;
using GolfStore.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace GolfStore_L00181486.Pages.Admins.Clubs
{
    public class EditModel : PageModel
    {
        private readonly IClubRepo _clubRepo;
        private readonly IBrandRepo _brandRepo;
        private readonly IClubtypeRepo _clubtypeRepo;

        public SelectList brandSelect { get; set; }
        public SelectList ClubTypeList { get; set; }

        public EditModel(IClubRepo clubRepo, IBrandRepo brandRepo, IClubtypeRepo clubtypeRepo)
        {
            _clubRepo = clubRepo;
            _brandRepo = brandRepo;
            _clubtypeRepo = clubtypeRepo;
        }

        public Club Club { get; set; }
        public void OnGet(int id)
        {
            brandSelect = new SelectList(_brandRepo.GetAll(), "BrandId", "Name");
            ClubTypeList = new SelectList(_clubtypeRepo.GetAll(), "TypeId", "Type");

            Club = _clubRepo.Get(id);
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

            if (ModelState.IsValid)
            {
                _clubRepo.Update(club);
                _clubRepo.SaveAll();
            }

            return RedirectToPage("Index");
        }
    }
}

