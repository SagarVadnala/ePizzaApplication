using ePizza.Application.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePizza.API.Controllers
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
        public async Task<IActionResult> Get(CancellationToken token)
        {
            var repsonse = await itemService.FetchItems(token);

            return Ok(repsonse);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(int id,CancellationToken token)
        {
            var repsonse = await itemService.FetchItems(id,token);

            return Ok(repsonse);
        }
    }
}
