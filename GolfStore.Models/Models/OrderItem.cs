using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GolfStore.Models.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Club Club { get; set; }
        public int QtyOrdered { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
