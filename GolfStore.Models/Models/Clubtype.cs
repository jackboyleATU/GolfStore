using System.ComponentModel.DataAnnotations;

namespace GolfStore.Models.Models
{
    public class Clubtype
    {
        [Key]
        public int TypeId { get; set; }

        [Required]
        public string Type { get; set; }

        public string ImgUrl { get; set; }

        public ICollection<Club> Clubs { get; set; }
    }
}
