using System.ComponentModel.DataAnnotations;

namespace GolfStore.Models.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }
        [Required]
        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public string LogoUrl { get; set; }

        public ICollection<Club> Clubs { get; set; }
    }
}
