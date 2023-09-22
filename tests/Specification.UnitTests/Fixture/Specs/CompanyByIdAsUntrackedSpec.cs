using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class CompanyByIdAsUntrackedSpec : Specification<Company>, ISingleResultSpecification
{
    public CompanyByIdAsUntrackedSpec(int id)
    {
        Query.Where(company => company.Id == id).AsNoTracking();
    }
}
