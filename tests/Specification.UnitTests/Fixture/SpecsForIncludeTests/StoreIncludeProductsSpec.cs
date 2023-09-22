using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.SpecsForIncludeTests;

public class StoreIncludeProductsSpec : Specification<Store>
{
    public StoreIncludeProductsSpec()
    {
        Query.Include(x => x.Products);
    }
}
