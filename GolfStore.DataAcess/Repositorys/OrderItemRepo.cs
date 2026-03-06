using GolfStore.DataAccess.DataAccess;
using GolfStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfStore.DataAccess.Repositorys
{
    public class OrderItemRepo : Repo<OrderItem>, IOrderItemRepo
    {
        private readonly AppDBContext _dbContext;

        public OrderItemRepo(AppDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
