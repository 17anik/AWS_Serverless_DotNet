using AWS_Serverless_DotNetAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWS_Serverless_DotNetAPI.Services
{
    public class ShoppingListService : IShoppingListService
    {
        private readonly Dictionary<string, int> _shoppingListStorage = new Dictionary<string, int>();
        public Dictionary<string,int> GetItems()
        {
            return _shoppingListStorage;
        }

        public void AddItem(ShoppingListModel shoppingList)
        {
            _shoppingListStorage.Add(shoppingList.Name, shoppingList.Quantity);
        }

        public void RemoveItem(string shoppingListName)
        {
            _shoppingListStorage.Remove(shoppingListName);
        }
    }
}
