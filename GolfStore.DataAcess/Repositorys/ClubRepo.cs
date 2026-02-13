using GolfStore.DataAccess.DataAccess;
using GolfStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfStore.DataAccess.Repositorys
{
    public class ClubRepo : Repo<Club>, IClubRepo
    {
        private readonly AppDBContext _dbContext;
        public ClubRepo(AppDBContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public void SaveAll()
        {
            _dbContext.SaveChanges();
        }

        public void Update(Club club)
        {
            var prodFromDB = _dbContext.Clubs.
                FirstOrDefault(prodFromDB => prodFromDB.ClubId == club.ClubId);
            prodFromDB.Name = club.Name;
            prodFromDB.BrandId = club.BrandId;
            prodFromDB.TypeId = club.TypeId;

            if (club.ImgUrl != null)
            {
                prodFromDB.ImgUrl = club.ImgUrl;
            }
        }
    }
}
