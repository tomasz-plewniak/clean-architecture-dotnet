using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoresOrderedDescendingByNameSpec : Specification<Store>
{
    public StoresOrderedDescendingByNameSpec()
    {
        Query.OrderByDescending(x => x.Name);
    }
}
