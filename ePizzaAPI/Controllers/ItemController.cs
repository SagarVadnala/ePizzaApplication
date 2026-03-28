using ePizza.Application.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePizzaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService itemService;

        public ItemController(IItemService itemService)
        {
            this.itemService = itemService;
        }
        [HttpGet]
        public async Task<IActionResult> Get( CancellationToken token)
        {
            var response = await itemService.FetchItems(token);
            return Ok(response);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult>  Get(int id, CancellationToken token)
        {
            var response = await itemService.FetchItems(id, token);
            return Ok(response);
        }
    }
}
