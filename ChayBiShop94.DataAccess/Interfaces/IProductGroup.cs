using ChayBiShop94.Models;
using CodesByAniz.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayBiShop94.DataAccess
{
    public interface IProductGroup
    {
        PaginatedList<ProductGroup> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5); //read all
        ProductGroup GetItem(int id); // read particular item

        ProductGroup Create(ProductGroup unit);

        ProductGroup Edit(ProductGroup unit);

        ProductGroup Delete(ProductGroup unit);

        public bool IsItemExists(string name);
        public bool IsItemExists(string name, int Id);
    }
}
