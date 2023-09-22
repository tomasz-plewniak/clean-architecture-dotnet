using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class ProductByIdSpec : Specification<Product>
{
    public ProductByIdSpec(int id)
    {
        Query.Where(x => x.Id == id);
    }
}
