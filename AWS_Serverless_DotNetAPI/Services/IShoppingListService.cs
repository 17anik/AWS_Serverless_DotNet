using AWS_Serverless_DotNetAPI.Models;
using System.Collections.Generic;

namespace AWS_Serverless_DotNetAPI.Services
{
    public interface IShoppingListService
    {
        Dictionary<string, int> GetItems();
        void AddItem(ShoppingListModel shoppingList);
        void RemoveItem(string shoppingListName);
    }
}