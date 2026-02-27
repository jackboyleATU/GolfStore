using Microsoft.EntityFrameworkCore;
using GolfStore.Models.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GolfStore.DataAccess.DataAccess
{
    internal static class ModelBuilderShop
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clubtype>().HasData(
                new Clubtype { TypeId = 1, Type = "Driver", ImgUrl = "/images/driver.png" },
                new Clubtype { TypeId = 2, Type = "Fairway Wood", ImgUrl = "/images/fairwayWood.png" },
                new Clubtype { TypeId = 3, Type = "Hybrid", ImgUrl = "/images/hybrid.png" },
                new Clubtype { TypeId = 4, Type = "Iron", ImgUrl = "/images/iron.png" },
                new Clubtype { TypeId = 5, Type = "Wedge", ImgUrl = "/images/wedge.png" },
                new Clubtype { TypeId = 6, Type = "Putter", ImgUrl = "/images/putter.png" }
            );

            modelBuilder.Entity<Brand>().HasData(
                    new Brand { BrandId = 1, Name = "Callaway", Abbreviation = "CAL", LogoUrl = "/images/brands/callaway-logo.png" },
                    new Brand { BrandId = 2, Name = "TaylorMade", Abbreviation = "TAY", LogoUrl = "/images/brands/taylormade-logo.png" },
                    new Brand { BrandId = 3, Name = "Titleist", Abbreviation = "TIT", LogoUrl = "/images/brands/titleist-logo.png" },
                    new Brand { BrandId = 4, Name = "Ping", Abbreviation = "PIN", LogoUrl = "/images/brands/ping-logo.png" },
                    new Brand { BrandId = 5, Name = "Cobra", Abbreviation = "COB", LogoUrl = "/images/brands/cobra-logo.png" },
                    new Brand { BrandId = 6, Name = "Mizuno", Abbreviation = "MIZ", LogoUrl = "/images/brands/mizuno-logo.png" }
                );

            modelBuilder.Entity<Club>().HasData();

        }
    }
}
