using GolfStore.DataAccess.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP1.Services
{
    public interface IUnitOfWork : IDisposable
    {
        IClubRepo ClubRepo { get; }
        IBrandRepo BrandRepo { get; }
        IClubtypeRepo ClubtypeRepo { get; }

        void Save();
    }
}
