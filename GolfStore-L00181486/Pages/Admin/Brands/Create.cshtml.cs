using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using GolfStore.Models.Models;
using GolfStore.DataAccess.DataAccess;
using GolfStore.DataAccess.Repositorys;
using RP1.Services;
using Microsoft.AspNetCore.Routing.Constraints;

namespace GolfStore_L00181486.Pages.Admin.Brands
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        // Expose SelectList properties with the exact names used in the Razor page

        public CreateModel(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        [BindProperty]
        public Brand Brand { get; set; }

        // Populate select lists on GET
        public void OnGet()
        {
 
        }

        public IActionResult OnPost(Brand brand)
        {
            var files = HttpContext.Request.Form.Files;

            string wwwRootFolder = _webHostEnvironment.WebRootPath;
            string new_filename = Guid.NewGuid().ToString();

            var upload = Path.Combine(wwwRootFolder, @"Images\Clubs");

            var extension = Path.GetExtension(files[0].FileName);
            using (var fileStream = new FileStream(Path.Combine(upload, new_filename + extension), FileMode.Create))
            {
                files[0].CopyTo(fileStream);
            }

            Brand.LogoUrl = @"\Images\Brands\" + new_filename + extension;

            if (ModelState.IsValid)
            {
                _unitOfWork.BrandRepo.Add(Brand);
                _unitOfWork.Save();
            }

            return RedirectToPage("Index");
        }
    }
}