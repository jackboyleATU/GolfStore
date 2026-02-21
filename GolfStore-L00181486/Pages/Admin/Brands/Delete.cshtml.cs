using GolfStore.DataAccess.DataAccess;
using GolfStore.DataAccess.Repositorys;
using GolfStore.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GolfStore.Services;
using System.ComponentModel;

namespace GolfStore_L00181486.Pages.Admin.Brands
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Brand Brand { get; set; }
        public void OnGet(int id)
        {
            Brand = _unitOfWork.BrandRepo.Get(id);
        }

        public IActionResult OnPost()
        {
            var brandFromDB = _unitOfWork.BrandRepo.Get(Brand.BrandId);
            if (brandFromDB != null)
            {
                _unitOfWork.BrandRepo.Delete(brandFromDB);
                _unitOfWork.Save();
            }

            return RedirectToPage("Index");
        }
    }
}

