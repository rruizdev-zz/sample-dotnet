using SampleDotnet.Domain.Entities;

namespace SampleDotnet.Domain.Interfaces.Repositories
{
    public interface IItemRepository
    {
        Task<Item?> GetBySearchAsync(string value, int page, CancellationToken cancellationToken);
    }
}
