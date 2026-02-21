using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using GolfStore.Models.Models;
using GolfStore.DataAccess.DataAccess;
using GolfStore.DataAccess.Repositorys;
using GolfStore.Services;
using Microsoft.AspNetCore.Routing.Constraints;

namespace GolfStore_L00181486.Pages.Admin.Brands
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        // Expose SelectList properties with the exact names used in the Razor page

        public EditModel(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        [BindProperty]
        public Brand Brand { get; set; }

        // Populate select lists on GET
        public IActionResult OnGet(int id)
        {
            Brand = _unitOfWork.BrandRepo.Get(id);
            
            if (Brand == null)
            {
                return NotFound();
            }
            
            return Page();
        }

        public IActionResult OnPost(Club club)
        {
            var files = HttpContext.Request.Form.Files;
            string wwwRootFolder = _webHostEnvironment.WebRootPath;
            var prodFromDB = _unitOfWork.BrandRepo.Get(Brand.BrandId);

            if (prodFromDB == null)
            {
                return NotFound();
            }

            if (files.Count > 0)
            {
                string new_filename = Guid.NewGuid().ToString();
                var upload = Path.Combine(wwwRootFolder, @"Images\Brands");
                var extension = Path.GetExtension(files[0].FileName);
                
                // Delete old image file
                if (!string.IsNullOrEmpty(prodFromDB.LogoUrl))
                {
                    var oldFile = Path.Combine(wwwRootFolder, prodFromDB.LogoUrl.TrimStart('\\'));
                    if (System.IO.File.Exists(oldFile))
                    {
                        System.IO.File.Delete(oldFile);
                    }
                }
                
                using (var fileStream = new FileStream(Path.Combine(upload, new_filename + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                Brand.LogoUrl = @"\Images\Brands\" + new_filename + extension;
            }
            else
            {
                // Keep the existing image URL if no new file is uploaded
                Brand.LogoUrl = prodFromDB.LogoUrl;
            }
            
            if (ModelState.IsValid)
            {
                _unitOfWork.BrandRepo.Update(Brand);
                _unitOfWork.Save();
            }

            return RedirectToPage("Index");
        }
    }
}