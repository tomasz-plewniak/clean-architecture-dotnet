using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.SpecsForIncludeTests;

public class StoreIncludeAddressSpec : Specification<Store>
{
    public StoreIncludeAddressSpec()
    {
        Query.Include(x => x.Address);
    }
}
