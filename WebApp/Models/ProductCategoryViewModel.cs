using ChayBiShop94.ViewModels.Catalog.Categories;
using ChayBiShop94.ViewModels.Catalog.Products;
using ChayBiShop94.ViewModels.Common;

namespace WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm Category { get; set; }

        public PagedResult<ProductVm> Products { get; set; }
    }
}