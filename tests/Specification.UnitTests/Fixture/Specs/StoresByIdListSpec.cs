using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoresByIdListSpec : Specification<Store>
{
    public StoresByIdListSpec(IEnumerable<int> ids)
    {
        Query.Where(x => ids.Contains(x.Id));
    }
}
