using GolfStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfStore.DataAccess.Repositorys
{
    public interface IShoppingCartRepo : IRepo<ShoppingCart>
    {
        ShoppingCart IncrementItem(string userid, int id);

        int IncrementQty(ShoppingCart shoppingCartFromDb, int qty);
    }
}
