using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GolfStore.Models.Models
{
    public class Club
    { 
        public enum ForgivenessLevel
        {
            Low,
            Medium,
            High
        }

        [Key]
        public int ClubId { get; set; }

        [Required]
        public string Name { get; set; }

        public ForgivenessLevel? Forgiveness { get; set; }

        public int? Price { get; set; }

        public int? Stock { get; set; }

        public string? ImgUrl { get; set; }

        public int? TypeId { get; set; }
        [ForeignKey("TypeId")]
        public Clubtype? Clubtype { get; set; }

        public int? BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand? Brand { get; set; }
    }
}
