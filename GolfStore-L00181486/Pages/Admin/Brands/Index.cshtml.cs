using GolfStore.DataAccess.DataAccess;
using GolfStore.DataAccess.Repositorys;
using GolfStore.Models.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RP1.Services;


namespace GolfStore_L00181486.Pages.Admin.Brands
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IEnumerable<Brand> Brands { get; set; } = Enumerable.Empty<Brand>();

        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void OnGet()
        {
            Brands = _unitOfWork.BrandRepo.GetAll();
        }
    }
}
