using ChayBiShop94.Models;
using CodesByAniz.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayBiShop94.DataAccess
{
    public interface IBrand
    {
        PaginatedList<Brand> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5); //read all
        Brand GetItem(int id);

        Brand Create(Brand unit);

        Brand Edit(Brand unit);

        Brand Delete(Brand unit);

        public bool IsItemExists(string name);
        public bool IsItemExists(string name, int Id);
    }
}
