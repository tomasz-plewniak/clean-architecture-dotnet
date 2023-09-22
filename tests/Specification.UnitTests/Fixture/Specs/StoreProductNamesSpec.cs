using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoreProductNamesSpec : Specification<Store, string?>
{
    public StoreProductNamesSpec()
    {
        Query.SelectMany(s => s.Products.Select(p => p.Name));
    }
}
