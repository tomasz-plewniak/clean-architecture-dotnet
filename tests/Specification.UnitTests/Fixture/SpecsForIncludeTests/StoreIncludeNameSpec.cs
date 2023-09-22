using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.SpecsForIncludeTests;

public class StoreIncludeNameSpec : Specification<Store>
{
    public StoreIncludeNameSpec()
    {
        Query.Include(x => x.Name);
    }
}
