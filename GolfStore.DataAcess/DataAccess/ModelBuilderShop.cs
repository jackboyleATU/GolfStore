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

            modelBuilder.Entity<Club>().HasData(
                new Club
                {
                    ClubId = 1,
                    Name = "Elyte",
                    BrandId = 1,          
                    TypeId = 1,           
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/elyte.png"
                },
                new Club
                {
                    ClubId = 2,
                    Name = "Elyte X",
                    BrandId = 1,          
                    TypeId = 1,           
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/elyte-x.png"
                },
                new Club
                {
                    ClubId = 3,
                    Name = "Elyte Triple Diamond",
                    BrandId = 1,          
                    TypeId = 1,         
                    Forgiveness = Club.ForgivenessLevel.Low,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/elyte-triple-diamond.png"
                },
                new Club
                {
                    ClubId = 4,
                    Name = "Elyte",
                    BrandId = 1,       
                    TypeId = 1,         
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/elyte.png"
                },
                new Club
                {
                    ClubId = 5,
                    Name = "Qi4D",
                    BrandId = 2,       
                    TypeId = 1,    
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Qi4D.png"
                },
                new Club
                {
                    ClubId = 6,
                    Name = "Qi4D Max",
                    BrandId = 2,          
                    TypeId = 1,           
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Qi4D-Max.png"
                },
                new Club
                {
                    ClubId = 7,
                    Name = "Qi4D LS",
                    BrandId = 2,         
                    TypeId = 1,          
                    Forgiveness = Club.ForgivenessLevel.Low,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Qi4D-LS.png"
                },
                new Club
                {
                    ClubId = 8,
                    Name = "GT1",
                    BrandId = 3,       
                    TypeId = 1,          
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/GT1.png"
                },
                new Club
                {
                    ClubId = 9,
                    Name = "GT4",
                    BrandId = 3,
                    TypeId = 1,
                    Forgiveness = Club.ForgivenessLevel.Low,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/GT4.png"
                },
                new Club
                {
                    ClubId = 10,
                    Name = "GT3",
                    BrandId = 3,
                    TypeId = 1,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/GT3.png"
                },
                new Club
                {
                    ClubId =11,
                    Name = "G440 K",
                    BrandId = 4,
                    TypeId = 1,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/G440-K.png"
                },
                new Club
                {
                    ClubId = 12,
                    Name = "G440 Max",
                    BrandId = 4,
                    TypeId = 1,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/G440-Max.png"
                },
                new Club
                {
                    ClubId = 13,
                    Name = "G440 LST",
                    BrandId = 4,
                    TypeId = 1,
                    Forgiveness = Club.ForgivenessLevel.Low,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/G440-LST.png"
                },
                new Club
                {
                    ClubId = 14,
                    Name = "OPTM X",
                    BrandId = 5,
                    TypeId = 1,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/OPTM-X.png"
                },
                new Club
                {
                    ClubId = 15,
                    Name = "OPTM Max-K",
                    BrandId = 5,
                    TypeId = 1,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/OPTM-Max-K.png"
                },
                new Club
                {
                    ClubId = 16,
                    Name = "OPTM LS",
                    BrandId = 5,
                    TypeId = 1,
                    Forgiveness = Club.ForgivenessLevel.Low,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/OPTM-LS.png"
                },
                new Club
                {
                    ClubId = 17,
                    Name = "JPX ONE",
                    BrandId = 6,
                    TypeId = 1,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/JPX-ONE.png"
                },
                new Club
                {
                    ClubId = 18,
                    Name = "JPX ONE Select",
                    BrandId = 6,
                    TypeId = 1,
                    Forgiveness = Club.ForgivenessLevel.Low,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/JPX-ONE-Select.png"
                },
                new Club
                {
                    ClubId = 19,
                    Name = "X Forged Max",
                    BrandId = 1,
                    TypeId = 4,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 1300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/X-Forged-Max.png"
                },
                new Club
                {
                    ClubId = 20,
                    Name = "X Forged",
                    BrandId = 1,
                    TypeId = 4,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 1300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/X-Forged.png"
                },
                new Club
                {
                    ClubId = 21,
                    Name = "P790",
                    BrandId = 2,
                    TypeId = 4,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 1300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/P790.png"
                },
                new Club
                {
                    ClubId = 22,
                    Name = "P770",
                    BrandId = 2,
                    TypeId = 4,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 1300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/P770.png"
                },
                new Club
                {
                    ClubId = 23,
                    Name = "P7MB",
                    BrandId = 2,
                    TypeId = 4,
                    Forgiveness = Club.ForgivenessLevel.Low,
                    Price = 1300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/P7MB.png"
                },
                new Club
                {
                    ClubId = 24,
                    Name = "T100",
                    BrandId = 3,
                    TypeId = 4,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 1300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/T100.png"
                },
                new Club
                {
                    ClubId = 25,
                    Name = "T250",
                    BrandId = 3,
                    TypeId = 4,
                    Forgiveness = Club.ForgivenessLevel.Low,
                    Price = 1300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/T250.png"
                },
                new Club
                {
                    ClubId = 26,
                    Name = "G440",
                    BrandId = 4,
                    TypeId = 4,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 1300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/G440-Irons.png"
                },
                new Club
                {
                    ClubId = 27,
                    Name = "G440 HL",
                    BrandId = 4,
                    TypeId = 4,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 1300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/G440-HL-Irons.png"
                },
                new Club
                {
                    ClubId = 28,
                    Name = "King",
                    BrandId = 5,
                    TypeId = 4,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 1300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/King-Irons.png"
                },
                new Club
                {
                    ClubId = 29,
                    Name = "King Tec",
                    BrandId = 5,
                    TypeId = 4,
                    Forgiveness = Club.ForgivenessLevel.Low,
                    Price = 1300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/King-Tec-Irons.png"
                },
                new Club
                {
                    ClubId = 30,
                    Name = "Pro M13",
                    BrandId = 6,
                    TypeId = 4,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 1300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Pro-M13.png"
                },
                new Club
                {
                    ClubId = 31,
                    Name = "Pro M15",
                    BrandId = 6,
                    TypeId = 4,
                    Forgiveness = Club.ForgivenessLevel.Low,
                    Price = 1300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Pro-M15.png"
                },
                new Club
                {
                    ClubId = 32,
                    Name = "Elyte Fairway",
                    BrandId = 1,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Elyte-Wood.png"
                },
                new Club
                {
                    ClubId = 33,
                    Name = "Elyte X Fairway",
                    BrandId = 1,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Elyte-X-Wood.png"
                },
                new Club
                {
                    ClubId = 34,
                    Name = "Elyte Triple Diamond Fairway",
                    BrandId = 1,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.Low,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Elyte-Triple-Diamond-Wood.png"
                },
                new Club
                {
                    ClubId = 35,
                    Name = "Qi4D Fairway",
                    BrandId = 2,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Qi4D-Wood.png"
                },
                new Club
                {
                    ClubId = 36,
                    Name = "Qi4D Max Fairway",
                    BrandId = 2,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Qi4D-Max-Wood.png"
                },
                new Club
                {
                    ClubId = 37,
                    Name = "Qi4D Tour Fairway",
                    BrandId = 2,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.Low,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Qi4D-Tour-Wood.png"
                },
                new Club
                {
                    ClubId = 38,
                    Name = "GT1 Fairway",
                    BrandId = 3,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/GT1-Wood.png"
                },
                new Club
                {
                    ClubId = 39,
                    Name = "GT2 Fairway",
                    BrandId = 3,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/GT2-Wood.png"
                },
                new Club
                {
                    ClubId = 40,
                    Name = "GT3 Fairway",
                    BrandId = 3,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.Low,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/GT3-Wood.png"
                },
                new Club
                {
                    ClubId = 41,
                    Name = "G440 SFT Fairway",
                    BrandId = 4,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/G440-SFT-Wood.png"
                },
                new Club
                {
                    ClubId = 42,
                    Name = "G440 Max Fairway",
                    BrandId = 4,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/G440-Max-Wood.png"
                },
                new Club
                {
                    ClubId = 43,
                    Name = "G440 LST Fairway",
                    BrandId = 4,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.Low,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/G440-LST-Wood.png"
                },
                new Club
                {
                    ClubId = 44,
                    Name = "OPTM X Fairway",
                    BrandId = 5,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/OPTM-X-Wood.png"
                },
                new Club
                {
                    ClubId = 45,
                    Name = "OPTM Max Fairway",
                    BrandId = 5,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/OPTM-Max-Wood.png"
                },
                new Club
                {
                    ClubId = 46,
                    Name = "OPTM LS Fairway",
                    BrandId = 5,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.Low,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/OPTM-LS-Wood.png"
                },
                new Club
                {
                    ClubId = 47,
                    Name = "JPX ONE Fairway",
                    BrandId = 6,
                    TypeId = 2,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/JPX-ONE-Wood.png"
                },
                new Club
                {
                    ClubId = 48,
                    Name = "Quantum Max Hybrid",
                    BrandId = 1,
                    TypeId = 3,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Quantum-Max-Hybrid.png"
                },
                new Club
                {
                    ClubId = 49,
                    Name = "Qi4D Rescue",
                    BrandId = 2,
                    TypeId = 3,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Qi4D-Rescue.png"
                },
                new Club
                {
                    ClubId = 50,
                    Name = "GT3 Hybrid",
                    BrandId = 3,
                    TypeId = 3,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/GT3-Hybrid.png"
                },
                new Club
                {
                    ClubId = 51,
                    Name = "G440 Hybrid",
                    BrandId = 4,
                    TypeId = 3,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/G440-Hybrid.png"
                },
                new Club
                {
                    ClubId = 52,
                    Name = "OPTM Hybrid",
                    BrandId = 5,
                    TypeId = 3,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/OPTM-Hybrid.png"
                },
                new Club
                {
                    ClubId = 53,
                    Name = "JPX ONE Hybrid",
                    BrandId = 6,
                    TypeId = 3,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/JPX-ONE-Hybrid.png"
                },
                new Club
                {
                    ClubId = 54,
                    Name = "Jaws",
                    BrandId = 1,
                    TypeId = 5,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 200,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Jaws.png"
                },
                new Club
                {
                    ClubId = 55,
                    Name = "MG5",
                    BrandId = 2,
                    TypeId = 5,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 200,
                    Stock = 12,
                    ImgUrl = "/images/clubs/MG5.png"
                },
                new Club
                {
                    ClubId = 56,
                    Name = "Vokey SM11",
                    BrandId = 3,
                    TypeId = 5,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 200,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Vokey-SM11.png"
                },
                new Club
                {
                    ClubId = 57,
                    Name = "S259",
                    BrandId = 4,
                    TypeId = 5,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 200,
                    Stock = 12,
                    ImgUrl = "/images/clubs/S259.png"
                },
                new Club
                {
                    ClubId = 58,
                    Name = "King Wedge",
                    BrandId = 5,
                    TypeId = 5,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 200,
                    Stock = 12,
                    ImgUrl = "/images/clubs/King-Wedge.png"
                },
                new Club
                {
                    ClubId = 59,
                    Name = "Pro-T3",
                    BrandId = 6,
                    TypeId = 5,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 200,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Pro-T3.png"
                },
                new Club
                {
                    ClubId = 60,
                    Name = "Odyssey AI Dual",
                    BrandId = 1,
                    TypeId = 6,
                    Forgiveness = Club.ForgivenessLevel.Medium,
                    Price = 200,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Odyssey.png"
                },
                new Club
                {
                    ClubId = 61,
                    Name = "Odyssey AI Dual",
                    BrandId = 1,
                    TypeId = 6,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Odyssey.png"
                },
                new Club
                {
                    ClubId = 62,
                    Name = "Spyder ZT",
                    BrandId = 2,
                    TypeId = 6,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Spyder.png"
                },
                new Club
                {
                    ClubId = 63,
                    Name = "Scotty Cameron Santa Fe",
                    BrandId = 3,
                    TypeId = 6,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/Scotty-Cameron.png"
                },
                new Club
                {
                    ClubId = 64,
                    Name = "PLD Anser",
                    BrandId = 4,
                    TypeId = 6,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/PLD.png"
                },
                new Club
                {
                    ClubId = 65,
                    Name = "MIM Nova",
                    BrandId = 5,
                    TypeId = 6,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 300,
                    Stock = 12,
                    ImgUrl = "/images/clubs/MIM.png"
                },
                new Club
                {
                    ClubId = 66,
                    Name = "M Craft",
                    BrandId = 6,
                    TypeId = 6,
                    Forgiveness = Club.ForgivenessLevel.High,
                    Price = 500,
                    Stock = 12,
                    ImgUrl = "/images/clubs/M-Craft.png"
                }
                );

        }
    }
}
