using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class CompanyByIdWithAsTrackingAsUntrackedSpec : Specification<Company>, ISingleResultSpecification<Company>
{
    public CompanyByIdWithAsTrackingAsUntrackedSpec(int id)
    {
        Query.Where(company => company.Id == id).AsTracking().AsNoTracking();
    }
}
