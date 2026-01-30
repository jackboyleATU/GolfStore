using Microsoft.EntityFrameworkCore;
using GolfStore.Models.Models;

namespace GolfStore.DataAccess.DataAccess
{
    internal static class ModelBuilderShop
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clubtype>().HasData(
                new Clubtype{TypeId = 1, Type = "Driver", ImgUrl = "/images/driver.png" },
                new Clubtype{TypeId = 2, Type = "Fairway Wood", ImgUrl = "/images/fairwayWood.png"},
                new Clubtype{TypeId = 3, Type = "Hybrid", ImgUrl = "/images/hybrid.png"},
                new Clubtype{TypeId = 4, Type = "Iron", ImgUrl = "/images/iron.png"},
                new Clubtype{TypeId = 5, Type = "Wedge", ImgUrl = "/images/wedge.png"},
                new Clubtype{TypeId = 6, Type = "Putter", ImgUrl = "/images/putter.png"}
            );

        modelBuilder.Entity<Brand>().HasData(
                new Brand{BrandId = 1, Name = "Callaway", Abbreviation = "CAL", LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/8/89/Callaway_Golf_Company_logo.svg" },
                new Brand{BrandId = 2, Name = "TaylorMade", Abbreviation = "TAY", LogoUrl = "https://upload.wikimedia.org/wikipedia/en/1/1f/Taylormade_logo.png" },
                new Brand{BrandId = 3, Name = "Titleist", Abbreviation = "TIT", LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/d/d6/Titleist_golf_logo.png" },
                new Brand{BrandId = 4, Name = "Ping", Abbreviation = "PIN", LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/3/37/Ping-logo.png" },
                new Brand{BrandId = 5, Name = "Cobra", Abbreviation = "COB", LogoUrl = "https://www.cobragolf.com/cdn/shop/files/COBRA-logo-2022-black-shopify-checkout_1724x.png?v=1689363641" },
                new Brand{BrandId = 6, Name = "Mizuno", Abbreviation = "MIZ", LogoUrl = "https://upload.wikimedia.org/wikipedia/commons/3/34/Mizuno_logo.jpg" }
            );

        modelBuilder.Entity<Club>().HasData();
        }
    }
}
