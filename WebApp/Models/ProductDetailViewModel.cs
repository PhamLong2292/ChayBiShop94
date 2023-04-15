using ChayBiShop94.ViewModels.Catalog.Categories;
using ChayBiShop94.ViewModels.Catalog.ProductImages;
using ChayBiShop94.ViewModels.Catalog.Products;

namespace WebApp.Models
{
    public class ProductDetailViewModel
    {
        public CategoryVm Category { get; set; }

        public ProductVm Product { get; set; }

        public List<ProductVm> RelatedProducts { get; set; }

        public List<ProductImageViewModel> ProductImages { get; set; }
    }
}