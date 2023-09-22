using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoreWithPostProcessingActionSpec : Specification<Store>
{
    public StoreWithPostProcessingActionSpec()
    {
        Query.PostProcessingAction(x => x);
    }
}
