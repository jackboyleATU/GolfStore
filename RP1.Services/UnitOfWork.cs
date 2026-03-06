using GolfStore.DataAccess.DataAccess;
using GolfStore.DataAccess.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfStore.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _dbContext;

        public IClubRepo ClubRepo { get; private set; }
        public IBrandRepo BrandRepo { get; private set; }
        public IClubtypeRepo ClubtypeRepo { get; private set; }

        public IApplicationUserRepo ApplicationUserRepo { get; private set; }
        public IOrderRepo OrderRepo { get; private set; }
        public IOrderItemRepo OrderItemRepo { get; private set; }
        public IShoppingCartRepo ShoppingCartRepo { get; private set; }


        public UnitOfWork(AppDBContext dbContext)
        {
            _dbContext = dbContext;
            ClubRepo = new ClubRepo(_dbContext);
            BrandRepo = new BrandRepo(_dbContext);
            ClubtypeRepo = new ClubtypeRepo(_dbContext);
            ApplicationUserRepo = new ApplicationUserRepo(_dbContext);
            OrderRepo = new OrderRepo(_dbContext);
            OrderItemRepo = new OrderItemRepo(_dbContext);
            ShoppingCartRepo = new ShoppingCartRepo(_dbContext);
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
