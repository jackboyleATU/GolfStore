using GolfStore.DataAccess.DataAccess;
using GolfStore.DataAccess.Repositorys;
using GolfStore.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GolfStore.Services;
using System.ComponentModel;

namespace GolfStore_L00181486.Pages.Admin.Clubs
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Club Club { get; set; }
        public void OnGet(int id)
        {
            Club = _unitOfWork.ClubRepo.Get(id);
        }

        public IActionResult OnPost()
        {
            var clubFromDb = _unitOfWork.ClubRepo.Get(Club.ClubId);
            if (clubFromDb != null)
            {
                _unitOfWork.ClubRepo.Delete(clubFromDb);
                _unitOfWork.Save();
            }

            return RedirectToPage("Index");
        }
    }
}

