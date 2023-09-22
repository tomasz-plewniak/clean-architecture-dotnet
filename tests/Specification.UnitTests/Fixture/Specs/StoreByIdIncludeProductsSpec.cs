using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoreByIdIncludeProductsSpec : Specification<Store>, ISingleResultSpecification
{
    public StoreByIdIncludeProductsSpec(int id)
    {
        Query.Where(x => x.Id == id)
            .Include(x => x.Products);
    }
}
