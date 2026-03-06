using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfStore.Models.Models
{
    public class ShoppingCart
    {
        public int Id { get; set; }

        public int ClubId { get; set; }
        [ForeignKey("ClubId")]
        [ValidateNever]
        public Club Club { get; set; }
        public int Quantity { get; set; }
        public float CartTotal { get; set; }

        public string ApplicationUserID { get; set; }
        [ForeignKey("ApplicationUserID")]
        [ValidateNever]
        public ApplicationUser ApplicationUser { get; set; }
    }
}
