using GolfStore.Models.Models;
using GolfStore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Stripe.Checkout;
using System.Security.Claims;

namespace GolfStore_L00181486.Pages.Customer.Cart
{
    public class SummaryModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public Order Order { get; set; }
        public IEnumerable<ShoppingCart> ShoppingCartList { get; set; }

        public SummaryModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            Order = new Order();
        }

        public void OnGet()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userId = claim.Value;
            ShoppingCartList = _unitOfWork.ShoppingCartRepo.GetShoppingCartProduct(userId);
            foreach (var item in ShoppingCartList)
            {
                Order.TotalAmtDue += (float)(item.Club.Price * item.Quantity);
            }
            ApplicationUser applicationUser = _unitOfWork.ApplicationUserRepo.Get(claim.Value);
            Order.CustomerName = applicationUser.FirstName + " " + applicationUser.LastName;
            Order.DateOfOrder = DateTime.Now;
            Order.PhoneNumber = applicationUser.PhoneNumber;
        }

        public IActionResult OnPost()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var userId = claim.Value;
            ShoppingCartList = _unitOfWork.ShoppingCartRepo.GetShoppingCartProduct(userId);
            foreach (var item in ShoppingCartList)
            {
                Order.TotalAmtDue += (float)(item.Club.Price * item.Quantity);
            }
            ApplicationUser applicationUser = _unitOfWork.ApplicationUserRepo.Get(claim.Value);
            Order.UserId = claim.Value;
            Order.CustomerName = applicationUser.FirstName + " " + applicationUser.LastName;
            Order.DateOfOrder = DateTime.Now;
            Order.PhoneNumber = applicationUser.PhoneNumber;
            _unitOfWork.OrderRepo.Add(Order);
            _unitOfWork.Save();

            foreach (var item in ShoppingCartList)
            {
                OrderItem orderItems = new OrderItem()
                {
                    OrderId = Order.ID,
                    Club = item.Club,
                    QtyOrdered = item.Quantity
                };
                _unitOfWork.OrderItemRepo.Add(orderItems);
            }
            _unitOfWork.ShoppingCartRepo.RemoveAll(ShoppingCartList);
            _unitOfWork.Save();
            //return RedirectToPage("OrderPlaced");

            var scheme = Request.Scheme;
            var host = Request.Host.Value;
            var domain = $"{scheme}://{host}";

            var options = new SessionCreateOptions
            {
                LineItems = new List<SessionLineItemOptions>
    {
        new SessionLineItemOptions
        {
            PriceData = new SessionLineItemPriceDataOptions
            {
                UnitAmount = (long)(Order.TotalAmtDue * 100),
                Currency = "eur",
                ProductData = new SessionLineItemPriceDataProductDataOptions
                {
                    Name = "Jacks"
                }
            },
            Quantity = 1,
        },
    },
                PaymentMethodTypes = new List<string> { "card" },
                Mode = "payment",
                SuccessUrl = domain + "/Customer/Cart/OrderPlaced",
                CancelUrl = domain + "/Customer/Cart/Index",
            };
            var service = new SessionService();
            Session session = service.Create(options);

            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);


        }
    }
}
