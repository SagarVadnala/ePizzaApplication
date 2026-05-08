using ePizza.Domain.DomainModels;

namespace ePizza.Domain.Interface.Repositories
{
    public interface IItemRepository 
    {
        Task<IEnumerable<ItemDomain>> GetItems();
        Task<ItemDomain> GetItemsById(int id);
    }
}
