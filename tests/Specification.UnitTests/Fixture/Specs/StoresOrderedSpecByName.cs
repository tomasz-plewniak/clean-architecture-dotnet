using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoresOrderedSpecByName : Specification<Store>
{
    public StoresOrderedSpecByName()
    {
        Query.OrderBy(x => x.Name);
    }
}
