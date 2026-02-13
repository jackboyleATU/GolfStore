using GolfStore.DataAccess.DataAccess;
using GolfStore.DataAccess.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP1.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDBContext _dbContext;

        public IClubRepo ClubRepo { get; private set; }
        public IBrandRepo BrandRepo { get; private set; }
        public IClubtypeRepo ClubtypeRepo { get; private set; }

        public UnitOfWork(AppDBContext dbContext)
        {
            _dbContext = dbContext;
            ClubRepo = new ClubRepo(_dbContext);
            BrandRepo = new BrandRepo(_dbContext);
            ClubtypeRepo = new ClubtypeRepo(_dbContext);
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
