using GolfStore.Models.Models;
using GolfStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GolfStore_L00181486.Pages.Customer.Home
{
    public class DetailsModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;


        public DetailsModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Club Club { get; set; }

        public void OnGet(int id)
        {
            Club = _unitOfWork.ClubRepo.Get(id);
        }
    }
}
