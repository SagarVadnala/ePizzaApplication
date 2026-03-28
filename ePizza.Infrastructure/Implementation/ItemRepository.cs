using ePizza.Domain.Interfaces;
using ePizza.Domain.Models;
using ePizza.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace ePizza.Infrastructure.Implementation
{
    public class ItemRepository : IItemRepository
    {
        private readonly EPizzaDBbContext dbContext;
        public ItemRepository(EPizzaDBbContext dbContext)
        {
            this.dbContext = dbContext;

        }
        public async Task<IEnumerable<ItemDomain>> GetItems(CancellationToken token)
        {
            var items = await dbContext.Items.Select(x => new ItemDomain()
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                UnitPrice = x.UnitPrice
            }).ToListAsync(token);


            return items;
        }

        public async Task<ItemDomain> GetItems(int id, CancellationToken token)
        {
            var items = await dbContext.Items.FindAsync(id, token);

            return new ItemDomain()
            {
                Id = items.Id,
                Name = items.Name,
                Description = items.Description,
                ImageUrl = items.ImageUrl,
                UnitPrice = items.UnitPrice
            };

        }
    }
}
