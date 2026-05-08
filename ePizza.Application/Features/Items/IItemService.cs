using ePizza.Application.DTO.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Application.Features.Items
{
    public interface IItemService
    {
        Task<IEnumerable<ItemResponseDto>> GetItemsAsync();
        Task<ItemResponseDto> GetItemAsync(int id);

    }
}
