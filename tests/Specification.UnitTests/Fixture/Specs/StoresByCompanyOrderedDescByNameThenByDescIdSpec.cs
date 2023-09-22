using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoresByCompanyOrderedDescByNameThenByDescIdSpec : Specification<Store>
{
    public StoresByCompanyOrderedDescByNameThenByDescIdSpec(int companyId)
    {
        Query.Where(x => x.CompanyId == companyId)
             .OrderByDescending(x => x.Name)
             .ThenByDescending(x => x.Id);
    }
}
