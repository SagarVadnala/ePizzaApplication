
using ePizza.Domain.DomainModels;
using ePizza.Domain.Interface.Repositories;
using ePizza.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Infrastructure.Repositories;

public class ItemRepository : IItemRepository
{
    private readonly ePizzaAppContext _context;

    public ItemRepository(ePizzaAppContext context)
    {
        _context = context;
    }
    public async Task<IEnumerable<ItemDomain>> GetItems()
    {
        var items = await _context.Items.ToListAsync(); // hit Db as select * from dbo.Items

        // convert infra entities to domain entities to avoid expiosing internal details of the database structure to the domain layer

        if(items.Any())
        {
            // in future we will use automapper
            return items.Select(i => new ItemDomain()
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description,
                UnitPrice = i.UnitPrice,
                ImageUrl = i.ImageUrl
            });
        }

       return Enumerable.Empty<ItemDomain>();

    }

    public async Task<ItemDomain> GetItemsById(int id)
    {

        var item = await _context.Items.FirstOrDefaultAsync(i => i.Id == id);

        if(item != null)
        {
            return new ItemDomain()
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
                UnitPrice = item.UnitPrice,
                ImageUrl = item.ImageUrl
            };
        }
        return new ItemDomain();
    }
}
