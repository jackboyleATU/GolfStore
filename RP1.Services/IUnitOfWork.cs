using GolfStore.DataAccess.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfStore.Services
{
    public interface IUnitOfWork : IDisposable
    {
        IClubRepo ClubRepo { get; }
        IBrandRepo BrandRepo { get; }
        IClubtypeRepo ClubtypeRepo { get; }

        IOrderRepo OrderRepo { get; }
        IOrderItemRepo OrderItemRepo { get; }
        IApplicationUserRepo ApplicationUserRepo { get; }
        IShoppingCartRepo ShoppingCartRepo { get; }

        void Save();
    }
}
