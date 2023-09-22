using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.SpecsForIncludeTests;

public class StoreWithFaultyIncludeSpec : Specification<Store>
{
    public StoreWithFaultyIncludeSpec()
    {
        Query.Include(x => x.Id == 1 && x.Name == "Something");
    }
}
