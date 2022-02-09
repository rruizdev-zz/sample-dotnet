using SampleDotnet.Domain.Entities;

namespace SampleDotnet.Domain.Interfaces.Repositories
{
    public interface ISiteRepository
    {
        Task<IList<Site>?> GetAllAsync(CancellationToken cancellationToken);
    }
}
