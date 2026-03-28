using ePizza.Application.Contracts;
using ePizza.Application.DTO.Response;
using ePizza.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static ePizza.Application.DTO.Response.IteamResponce;

namespace ePizza.Application.Implemen;

public class ItemService : IItemService
{
    private readonly IItemRepository itemRepository;

    public ItemService( IItemRepository itemRepository)
    {
        this.itemRepository = itemRepository;

    }

    public async Task<IEnumerable<ItemResponceDto>> FetchItems(CancellationToken token)
    {
        List<ItemResponceDto> itemList = [];
        var items = await itemRepository.GetItems(token);
        if (items is null) return null;
        foreach (var item in items)
        {
            itemList.Add(new ItemResponceDto(
                item.Id,
                item.Name,
                item.Description,
                item.UnitPrice,
                item.ImageUrl
                ));
        }
        return itemList;
    }

    public async Task<ItemResponceDto> FetchItems(int itemId, CancellationToken token)
    {
        var item = await itemRepository.GetItems(itemId, token);

        return new ItemResponceDto(
                item.Id,
                item.Name,
                item.Description,
                item.UnitPrice,
                item.ImageUrl
            );
            
    }
}

