using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class CompanyByIdAsUntrackedWithIdentityResolutionSpec : Specification<Company>, ISingleResultSpecification
{
    public CompanyByIdAsUntrackedWithIdentityResolutionSpec(int id)
    {
        Query.Where(company => company.Id == id).AsNoTrackingWithIdentityResolution();
    }
}
