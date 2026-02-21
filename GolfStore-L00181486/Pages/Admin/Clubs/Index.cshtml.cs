using GolfStore.DataAccess.DataAccess;
using GolfStore.DataAccess.Repositorys;
using GolfStore.Models.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GolfStore.Services;


namespace GolfStore_L00181486.Pages.Admin.Clubs
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<Club> Clubs { get; set; } = Enumerable.Empty<Club>();

        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet()
        {
            Clubs = _unitOfWork.ClubRepo.GetAll(includeProperties: "Brand,Clubtype");
        }
    }
}
