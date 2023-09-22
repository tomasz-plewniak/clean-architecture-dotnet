using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class CompanyByIdAsTrackedSpec : Specification<Company>, ISingleResultSpecification<Company>
{
    public CompanyByIdAsTrackedSpec(int id)
    {
        Query.Where(company => company.Id == id).AsTracking();
    }
}
