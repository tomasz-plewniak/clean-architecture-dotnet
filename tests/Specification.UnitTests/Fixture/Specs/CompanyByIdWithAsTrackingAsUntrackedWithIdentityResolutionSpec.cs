using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class CompanyByIdWithAsTrackingAsUntrackedWithIdentityResolutionSpec : Specification<Company>,
  ISingleResultSpecification<Company>
{
    public CompanyByIdWithAsTrackingAsUntrackedWithIdentityResolutionSpec(int id)
    {
        Query.Where(company => company.Id == id).AsTracking().AsNoTrackingWithIdentityResolution();
    }
}
