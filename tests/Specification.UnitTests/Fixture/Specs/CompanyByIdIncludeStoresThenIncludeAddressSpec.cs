using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class CompanyByIdIncludeStoresThenIncludeAddressSpec : Specification<Company>, ISingleResultSpecification
{
    public CompanyByIdIncludeStoresThenIncludeAddressSpec(int id)
    {
        Query.Where(x => x.Id == id)
            .Include(x => x.Stores)
            .ThenInclude(x => x.Address);
    }
}
