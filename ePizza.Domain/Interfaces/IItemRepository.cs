using ePizza.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ePizza.Domain.Interfaces;

public interface IItemRepository
{
    Task<IEnumerable<ItemDomain>> GetItems( CancellationToken token);
    Task<ItemDomain> GetItems( int id,CancellationToken token);
}
