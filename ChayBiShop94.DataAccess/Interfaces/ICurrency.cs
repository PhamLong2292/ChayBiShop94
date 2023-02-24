using ChayBiShop94.Models;
using CodesByAniz.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChayBiShop94.DataAccess
{
    public interface ICurrency
    {
        PaginatedList<Currency> GetItems(string SortProperty, SortOrder sortOrder, string SearchText = "", int pageIndex = 1, int pageSize = 5); //read all
        Currency GetItem(int id);

        bool Create(Currency currency);

        bool Edit(Currency currency);

        bool Delete(Currency currency);

        public bool IsItemExists(string name);

        public bool IsItemExists(string name, int id);

        public bool IsCurrencyCombExists(int srcCurrencyId, int excCurrencyId);

        public string GetErrors();

    }
}
