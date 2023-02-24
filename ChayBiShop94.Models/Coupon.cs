using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayBiShop94.Models
{
    public class Coupon
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public double Discount { get; set; }
        public double MinimumAmount { get; set; }
        public byte[] CouponPicture { get; set; }
        public bool IsAtive { get; set; }

    }
    public enum ConuponType
    {
        Percent = 0,
        Currency = 1
    }
}
