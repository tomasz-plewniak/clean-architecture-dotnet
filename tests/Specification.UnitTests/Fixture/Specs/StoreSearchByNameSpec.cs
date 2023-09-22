using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoreSearchByNameSpec : Specification<Store>
{
    public StoreSearchByNameSpec(string searchTerm)
    {
        Query.Search(x => x.Name!, "%" + searchTerm + "%");
    }
}
