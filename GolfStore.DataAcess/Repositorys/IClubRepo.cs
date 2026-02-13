using GolfStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfStore.DataAccess.Repositorys
{
    public interface IClubRepo : IRepo<Club>
    {
        public void Update(Club obj);
    }
}
