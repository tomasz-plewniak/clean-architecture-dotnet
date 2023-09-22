using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.SpecsForIncludeTests;

public class StoreIncludeCompanyCountryDotSeparatedSpec : Specification<Store>
{
    public StoreIncludeCompanyCountryDotSeparatedSpec()
    {
        Query.Include(x => x.Company!.Country);
    }
}
