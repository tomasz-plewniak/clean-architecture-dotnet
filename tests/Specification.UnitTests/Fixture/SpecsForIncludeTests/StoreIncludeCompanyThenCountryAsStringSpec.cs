using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.SpecsForIncludeTests;

public class StoreIncludeCompanyThenCountryAsStringSpec : Specification<Store>
{
    public StoreIncludeCompanyThenCountryAsStringSpec()
    {
        Query.Include($"{nameof(Company)}.{nameof(Company.Country)}");
    }
}
