using SampleDotnet.Domain.Entities;

namespace SampleDotnet.Domain.Interfaces.Repositories
{
    public interface ICountryRepository
    {
        Task<IList<Country>?> GetAllAsync(CancellationToken cancellationToken);
    }
}
