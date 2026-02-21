using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GolfStore.Services;
using System.ComponentModel;
using GolfStore.Models.Models;

namespace GolfStore_L00181486.Pages.Customer.Home
{
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Club> listOfClubs { get; set; }

        public IEnumerable<Brand> listOfBrands { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public void OnGet()
        {
            listOfClubs = _unitOfWork.ClubRepo.GetAll();
            listOfBrands = _unitOfWork.BrandRepo.GetAll();
            if (!string.IsNullOrEmpty(SearchString))
            {
                listOfClubs = listOfClubs.Where(p => p.Name.Contains(SearchString, StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}
