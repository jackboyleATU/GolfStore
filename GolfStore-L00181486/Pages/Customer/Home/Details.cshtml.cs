using GolfStore.Models.Models;
using GolfStore.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace GolfStore_L00181486.Pages.Customer.Home
{
    [Authorize(Roles = "Customer, Admin")]
    public class DetailsModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;


        public DetailsModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [BindProperty]
        public ShoppingCart ShoppingCart { get; set; }

        public Club Club { get; set; }

        public void OnGet(int id)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            ShoppingCart = new()
            {
                ApplicationUserID = claim.Value,
                Quantity = 1,
                Club = _unitOfWork.ClubRepo.GetClubBrand(id),
                ClubId = id
            };
        }

        public IActionResult OnPost()
        {
            ShoppingCart shoppingCartFromDb = _unitOfWork.ShoppingCartRepo.IncrementItem(ShoppingCart.ApplicationUserID, ShoppingCart.ClubId);
            if(shoppingCartFromDb == null)
            {
                _unitOfWork.ShoppingCartRepo.Add(ShoppingCart);
                _unitOfWork.Save();
            }
            else
            {
                _unitOfWork.ShoppingCartRepo.IncrementQty(shoppingCartFromDb, ShoppingCart.Quantity);
            }
            return RedirectToPage("Index");
        }
    }
}
