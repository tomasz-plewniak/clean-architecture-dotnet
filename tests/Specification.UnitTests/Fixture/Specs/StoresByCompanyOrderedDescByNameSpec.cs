using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoresByCompanyOrderedDescByNameSpec : Specification<Store>
{
    public StoresByCompanyOrderedDescByNameSpec(int companyId)
    {
        Query.Where(x => x.CompanyId == companyId)
             .OrderByDescending(x => x.Name);
    }
}
