using GolfStore.DataAccess.DataAccess;
using GolfStore.DataAccess.Repositorys;
using GolfStore.Models.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace GolfStore_L00181486.Pages.Admins.Clubs
{
    public class IndexModel : PageModel
    {
        private readonly IClubRepo _clubRepo;
        public IEnumerable<Club> Clubs { get; set; }

        public IndexModel(IClubRepo clubRepo)
        {
            _clubRepo = clubRepo;

        }

        public void OnGet()
        {
            Clubs = _clubRepo.GetAll(includeProperties: "Brand,Clubtype");
        }
    }
}
