using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using GolfStore.Models.Models;
using GolfStore.DataAccess.DataAccess;
using GolfStore.DataAccess.Repositorys;
using GolfStore.Services;
using Microsoft.AspNetCore.Routing.Constraints;

namespace GolfStore_L00181486.Pages.Admin.Clubs
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
        public Club Club { get; set; }

        public IEnumerable<SelectListItem> BrandList { get; set; }
        public IEnumerable<SelectListItem> ClubTypeList { get; set; }

        // Populate select lists on GET
        public IActionResult OnGet(int id)
        {
            Club = _unitOfWork.ClubRepo.Get(id);
            
            if (Club == null)
            {
                return NotFound();
            }

            BrandList = _unitOfWork.BrandRepo.GetAll().Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.BrandId.ToString()    
            });
            ClubTypeList = _unitOfWork.ClubtypeRepo.GetAll().Select(i => new SelectListItem()
            {
                Text = i.Type,
                Value = i.TypeId.ToString()
            });
            
            return Page();
        }

        public IActionResult OnPost(Club club)
        {
            var files = HttpContext.Request.Form.Files;
            string wwwRootFolder = _webHostEnvironment.WebRootPath;
            var prodFromDB = _unitOfWork.ClubRepo.Get(Club.ClubId);

            if (prodFromDB == null)
            {
                return NotFound();
            }

            if (files.Count > 0)
            {
                string new_filename = Guid.NewGuid().ToString();
                var upload = Path.Combine(wwwRootFolder, @"Images\Clubs");
                var extension = Path.GetExtension(files[0].FileName);
                
                // Delete old image file
                if (!string.IsNullOrEmpty(prodFromDB.ImgUrl))
                {
                    var oldFile = Path.Combine(wwwRootFolder, prodFromDB.ImgUrl.TrimStart('\\'));
                    if (System.IO.File.Exists(oldFile))
                    {
                        System.IO.File.Delete(oldFile);
                    }
                }
                
                using (var fileStream = new FileStream(Path.Combine(upload, new_filename + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }

                Club.ImgUrl = @"\Images\Clubs\" + new_filename + extension;
            }
            else
            {
                // Keep the existing image URL if no new file is uploaded
                Club.ImgUrl = prodFromDB.ImgUrl;
            }
            
            if (ModelState.IsValid)
            {
                _unitOfWork.ClubRepo.Update(Club);
                _unitOfWork.Save();
            }

            return RedirectToPage("Index");
        }
    }
}