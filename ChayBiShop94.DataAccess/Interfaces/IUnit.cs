using ChayBiShop94.Models;
using CodesByAniz.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayBiShop94.DataAccess
{
    public interface IUnit
    {
        PaginatedList<Unit> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5); //read all
        Unit GetUnit(int id); // read particular item

        Unit Create(Unit unit);

        Unit Edit(Unit unit);

        Unit Delete(Unit unit);

        public bool IsUnitNameExists(string name);

        public bool IsUnitNameExists(string name, int Id);
    }
}
