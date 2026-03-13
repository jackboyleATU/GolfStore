using GolfStore.DataAccess.DataAccess;
using GolfStore.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfStore.DataAccess.Repositorys
{
    public class ShoppingCartRepo : Repo<ShoppingCart>, IShoppingCartRepo
    {
        private readonly AppDBContext _dbContext;

        public ShoppingCartRepo(AppDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public ShoppingCart IncrementItem(string userId, int clubId)
        {
            var ShoppingCartItem = _dbContext.ShoppingCart.Where(p=>p.ClubId == clubId && p.ApplicationUserID == userId).FirstOrDefault();
            return ShoppingCartItem;
        }

        public int IncrementQty(ShoppingCart shoppingCartFromDb, int qty)
        {
            shoppingCartFromDb.Quantity += qty;
            _dbContext.SaveChanges();
            return shoppingCartFromDb.Quantity;
        }

        public IEnumerable<ShoppingCart> GetShoppingCartProduct(string userid)
        {
            var ShoppingCartItem = _dbContext.ShoppingCart.Where(u => u.ApplicationUserID == userid).Include(p => p.Club).ThenInclude(c => c.Brand);
            return ShoppingCartItem;
        }

        public void RemoveAll(IEnumerable<ShoppingCart> items)
        {
            _dbContext.RemoveRange(items);
            _dbContext.SaveChanges();
        }

        public int DecrementQty(ShoppingCart shoppingCart, int qty)
        {
            shoppingCart.Quantity -= qty;
            _dbContext.SaveChanges();
            return shoppingCart.Quantity;
        }
    }
}
