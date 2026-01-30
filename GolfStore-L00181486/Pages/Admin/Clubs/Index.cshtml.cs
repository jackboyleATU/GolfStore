using GolfStore.DataAccess.DataAccess;
using GolfStore.Models.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace GolfStore_L00181486.Pages.Admins.Clubs
{
    public class IndexModel : PageModel
    {
        private readonly AppDBContext _dbContext;
        public IEnumerable<Club> Clubs { get; set; }

        public IndexModel(AppDBContext dbContext)
        {
            _dbContext = dbContext;

        }

        public void OnGet()
        {
            Clubs = _dbContext.Clubs
                .Include(c => c.Brand)
                .Include(c => c.Clubtype)
                .ToList();
        }
    }
}
