using GolfStore.DataAccess.DataAccess;
using GolfStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfStore.DataAccess.Repositorys
{
    public class BrandRepo : Repo<Brand>, IBrandRepo
    {
        private readonly AppDBContext _dbContext;
        public BrandRepo(AppDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveAll()
        {
            _dbContext.SaveChanges();
        }
    }
}
