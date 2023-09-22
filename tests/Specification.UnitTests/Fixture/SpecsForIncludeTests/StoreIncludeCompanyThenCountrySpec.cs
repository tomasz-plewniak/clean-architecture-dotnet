using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.SpecsForIncludeTests;

public class StoreIncludeCompanyThenCountrySpec : Specification<Store>
{
    public StoreIncludeCompanyThenCountrySpec()
    {
        Query.Include(x => x.Company)
             .ThenInclude(x => x!.Country);
    }
}
