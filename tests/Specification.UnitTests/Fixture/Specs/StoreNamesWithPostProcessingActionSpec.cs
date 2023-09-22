using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoreNamesWithPostProcessingActionSpec : Specification<Store, string?>
{
    public StoreNamesWithPostProcessingActionSpec()
    {
        Query.Select(x => x.Name)
             .PostProcessingAction(x => x);
    }
}
