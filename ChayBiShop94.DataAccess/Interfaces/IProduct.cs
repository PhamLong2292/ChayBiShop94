using ChayBiShop94.Models;
using CodesByAniz.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayBiShop94.DataAccess
{
    public interface IProduct
    {
        PaginatedList<Product> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5); //read all

        Product GetItem(string Code); // read particular item

        Product Create(Product product);

        Product Edit(Product product);

        Product Delete(Product product);

        public bool IsItemExists(string name);

        public bool IsItemExists(string name, string Code);

        public bool IsItemCodeExists(string itemCode);

        public bool IsItemCodeExists(string itemCode, string name);
    }
}
