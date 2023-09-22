using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoreDuplicateSkipSpec : Specification<Store>
{
    public StoreDuplicateSkipSpec()
    {
        Query.Skip(1)
             .Skip(2);
    }
}
