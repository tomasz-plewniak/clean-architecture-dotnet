using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoreByIdIncludeAddressSpec : Specification<Store>, ISingleResultSpecification
{
    public StoreByIdIncludeAddressSpec(int id)
    {
        Query.Where(x => x.Id == id)
            .Include(x => x.Address);
    }
}
