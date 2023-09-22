using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoreSearchByNameOrCitySpec : Specification<Store>
{
    public StoreSearchByNameOrCitySpec(string searchTerm)
    {
        Query.Search(x => x.Name!, "%" + searchTerm + "%")
            .Search(x => x.City!, "%" + searchTerm + "%");
    }
}
