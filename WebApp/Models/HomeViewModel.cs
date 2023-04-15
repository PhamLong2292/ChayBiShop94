using ChayBiShop94.ViewModels.Catalog.Products;
using ChayBiShop94.ViewModels.Utilities.Slides;

namespace WebApp.Models
{
    public class HomeViewModel
    {
        public List<SlideVm> Slides { get; set; }

        public List<ProductVm> FeaturedProducts { get; set; }

        public List<ProductVm> LatestProducts { get; set; }
    }
}