using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoreNamesSpec : Specification<Store, string?>
{
    public StoreNamesSpec()
    {
        Query.Select(x => x.Name);
    }
}
