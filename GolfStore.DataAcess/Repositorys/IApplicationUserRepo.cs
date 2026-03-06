using GolfStore.Models.Models;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfStore.DataAccess.Repositorys
{
    public interface IApplicationUserRepo : IRepo<ApplicationUser>
    {
        ApplicationUser Get(String s);
    }
}
