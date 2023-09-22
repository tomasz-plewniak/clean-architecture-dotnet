using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoreByIdSpec : Specification<Store>
{
    public StoreByIdSpec(int id)
    {
        Query.Where(x => x.Id == id);
    }
}
