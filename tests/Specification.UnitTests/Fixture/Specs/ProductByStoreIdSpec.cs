using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class ProductByStoreIdSpec : Specification<Product>
{
    public ProductByStoreIdSpec(int storeId)
    {
        Query.Where(x => x.StoreId == storeId);
    }
}
