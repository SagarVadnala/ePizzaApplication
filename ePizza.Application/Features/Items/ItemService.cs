using ePizza.Application.DTO.Response;
using ePizza.Domain.DomainModels;
using ePizza.Domain.Interface.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Application.Features.Items
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository; // in domain layer

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public async Task<ItemResponseDto> GetItemAsync(int id)
        {
            var itemDomain = await _itemRepository.GetItemsById(id);

            if (itemDomain != null)
            {
                return new ItemResponseDto()
                {
                    Description = itemDomain.Description,
                    Id = itemDomain.Id,
                    ImageUrl = itemDomain.ImageUrl,
                    Name = itemDomain.Name,
                    UnitPrice = itemDomain.UnitPrice,
                };
            }
            return new ItemResponseDto();
        }

        public async Task<IEnumerable<ItemResponseDto>> GetItemsAsync()
        {
            var itemsDomain = await _itemRepository.GetItems();

           if(itemsDomain.Any())
            {
                return (itemsDomain.Select(x => new ItemResponseDto()
                {
                    Description = x.Description,
                    Id = x.Id,
                    ImageUrl = x.ImageUrl,
                    Name = x.Name,
                    UnitPrice = x.UnitPrice,
                }));
            }
            return Enumerable.Empty<ItemResponseDto>();
        }
    }
}
