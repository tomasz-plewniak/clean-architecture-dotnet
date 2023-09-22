using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.SpecsForIncludeTests;

public class StoreIncludeMethodOfNavigationSpec : Specification<Store>
{
    public StoreIncludeMethodOfNavigationSpec()
    {
        Query.Include(x => x.Address!.GetSomethingFromAddress());
    }
}
