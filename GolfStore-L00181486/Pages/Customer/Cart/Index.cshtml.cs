using GolfStore.Models.Models;
using GolfStore.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace GolfStore_L00181486.Pages.Customer.Cart
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public IEnumerable<ShoppingCart> ShoppingCartList { get; set; }
        private readonly IUnitOfWork _unitOfWork;
        public double CartTotal { get; set; }

        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            CartTotal = 0;
        }

        public void OnGet()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            if (claim != null)
            {
                ShoppingCartList = _unitOfWork.ShoppingCartRepo.GetShoppingCartProduct(claim.Value);
                foreach (var item in ShoppingCartList)
                {
                    CartTotal += (double)(item.Quantity * item.Club.Price);
                }
            }
        }

        public IActionResult OnPostPlus(int CartID)
        {
            var cart = _unitOfWork.ShoppingCartRepo.Get(CartID);
            if (cart == null) return RedirectToPage("./Index");

            _unitOfWork.ShoppingCartRepo.IncrementQty(cart, 1);
            return RedirectToPage("./Index");
        }

        public IActionResult OnPostMinus(int CartID)
        {
            var cart = _unitOfWork.ShoppingCartRepo.Get(CartID);
            if (cart == null) return RedirectToPage("./Index");

            if (cart.Quantity == 1)
            {
                _unitOfWork.ShoppingCartRepo.Delete(cart);
                _unitOfWork.Save();
            }
            else
            {
                _unitOfWork.ShoppingCartRepo.DecrementQty(cart, 1);
            }

            return RedirectToPage("./Index");
        }

        public IActionResult OnPostRemove(int CartID)
        {
            var cart = _unitOfWork.ShoppingCartRepo.Get(CartID);
            if (cart == null) return RedirectToPage("./Index");

            _unitOfWork.ShoppingCartRepo.Delete(cart);
            _unitOfWork.Save();
            return RedirectToPage("./Index");
        }
    }
}
