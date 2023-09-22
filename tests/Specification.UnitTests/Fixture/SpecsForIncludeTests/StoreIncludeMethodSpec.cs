using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.SpecsForIncludeTests;

public class StoreIncludeMethodSpec : Specification<Store>
{
    public StoreIncludeMethodSpec()
    {
        Query.Include(x => Store.GetSomethingFromStore());
    }
}
