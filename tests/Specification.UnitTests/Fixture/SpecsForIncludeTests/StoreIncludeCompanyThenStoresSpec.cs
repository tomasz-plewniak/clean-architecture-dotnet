using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.SpecsForIncludeTests;

public class StoreIncludeCompanyThenStoresSpec : Specification<Store>
{
    public StoreIncludeCompanyThenStoresSpec()
    {
        Query.Include(x => x.Company)
            .ThenInclude(x => x!.Stores)
            .ThenInclude(x => x.Products);
    }
}
