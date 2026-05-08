using ePizza.Application.Features.Items;

using Microsoft.AspNetCore.Mvc;

namespace ePizza.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get()
        {
            // Logic to retrieve items from the database

            var items = await _itemService.GetItemsAsync();
            return Ok( items);
        }
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            // Logic to retrieve items from the database

            var items = await _itemService.GetItemAsync(id);
            return Ok(items);
        }
    }
}
