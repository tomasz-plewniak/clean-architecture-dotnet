using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.SpecsForIncludeTests;

public class StoreIncludeCompanyThenNameSpec : Specification<Store>
{
    public StoreIncludeCompanyThenNameSpec()
    {
        Query.Include(x => x.Company)
             .ThenInclude(x => x!.Name);
    }
}
