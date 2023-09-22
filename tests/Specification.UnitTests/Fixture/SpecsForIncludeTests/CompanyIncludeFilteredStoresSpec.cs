using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.SpecsForIncludeTests;

public class CompanyIncludeFilteredStoresSpec : Specification<Company>
{
    public CompanyIncludeFilteredStoresSpec(int id)
    {
        Query.Where(x => x.Id == id)
            .Include(x => x.Stores.Where(s => s.Id == 1));
    }
}
