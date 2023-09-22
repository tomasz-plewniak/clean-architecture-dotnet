using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.SpecsForIncludeTests;

public class StoreIncludeAddressAndProductsSpec : Specification<Store>
{
    public StoreIncludeAddressAndProductsSpec()
    {
        Query.Include(x => x.Products)
             .Include(x => x!.Address);
    }
}
