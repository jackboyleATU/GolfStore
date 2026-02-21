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
        public Club Club { get; set; }

        public IEnumerable<SelectListItem> BrandList { get; set; }
        public IEnumerable<SelectListItem> ClubTypeList { get; set; }

        // Populate select lists on GET
        public void OnGet()
        {
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
        }

        public IActionResult OnPost(Club club)
        {
            var files = HttpContext.Request.Form.Files;
            if (files.Count == 0)
            {
                ModelState.AddModelError("Club.ImgUrl", "Please upload an image.");
                OnGet();
                return Page();
            }

            string wwwRootFolder = _webHostEnvironment.WebRootPath;
            string new_filename = Guid.NewGuid().ToString();

            var upload = Path.Combine(wwwRootFolder, @"Images\Clubs");

            var extension = Path.GetExtension(files[0].FileName);
            using (var fileStream = new FileStream(Path.Combine(upload, new_filename + extension), FileMode.Create))
            {
                files[0].CopyTo(fileStream);
            }

            Club.ImgUrl = @"\Images\Clubs\" + new_filename + extension;

            if (ModelState.IsValid)
            {
                _unitOfWork.ClubRepo.Add(Club);
                _unitOfWork.Save();
            }

            return RedirectToPage("Index");
        }
    }
}