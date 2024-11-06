using System.Collections.Generic;

namespace BachHoaXanh02.Models
{
    public class HomeViewModel
    {
        public List<Product> FeaturedProducts { get; set; }
        public List<Product> FlashSaleProducts { get; set; }
        public List<Banner> Banners { get; set; }
    }

    public class Banner
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string AltText { get; set; }
    }
}
