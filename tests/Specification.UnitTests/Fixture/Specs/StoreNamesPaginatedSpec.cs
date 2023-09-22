using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoreNamesPaginatedSpec : Specification<Store, string?>
{
    public StoreNamesPaginatedSpec(int skip, int take)
    {
        Query.OrderBy(x => x.Id)
            .Skip(skip)
            .Take(take);

        Query.Select(x => x.Name);
    }
}
