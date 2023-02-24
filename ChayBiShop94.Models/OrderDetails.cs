using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayBiShop94.Models
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderHeaderId { get; set; }    
        public OrderHeader OrderHeader { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int Count { get; set; }
        public string Decscripttion { get; set; }
        public double Price { get; set; }
    }
}
