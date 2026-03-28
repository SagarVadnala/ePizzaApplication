using ePizza.Application.DTO.Response;
using static ePizza.Application.DTO.Response.IteamResponce;

namespace ePizza.Application.Contracts;

public interface  IItemService
{
     Task<IEnumerable<ItemResponceDto>> FetchItems( CancellationToken token);
     Task<ItemResponceDto> FetchItems(int itemId,CancellationToken token);
}
