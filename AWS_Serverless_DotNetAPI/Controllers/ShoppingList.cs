using AWS_Serverless_DotNetAPI.Models;
using AWS_Serverless_DotNetAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWS_Serverless_DotNetAPI.Controllers
{   
    [Route("api/shoppingList")]
    [ApiController]
    public class ShoppingList : ControllerBase
    {
        private readonly IShoppingListService _shoppingListService;

        public ShoppingList(IShoppingListService shoppingListService)
        {
            _shoppingListService = shoppingListService;
        }

        [HttpGet]
        public IActionResult GetShoppingList()
        {
            var result = _shoppingListService.GetItems();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult AddItemToShoppingList([FromBody] ShoppingListModel shoppingList)
        {
            _shoppingListService.AddItem(shoppingList);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteItemFromShoppinglist([FromBody] ShoppingListModel shoppingList)
        {
            _shoppingListService.RemoveItem(shoppingList.Name);
            return Ok();
        }
    }
}
