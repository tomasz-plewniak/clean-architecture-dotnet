using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class ProductByIdAsUntrackedWithIdentityResolutionSpec : Specification<Product>, ISingleResultSpecification
{
    public ProductByIdAsUntrackedWithIdentityResolutionSpec(int id)
    {
        Query.Where(product => product.Id == id).AsNoTrackingWithIdentityResolution();
    }
}
