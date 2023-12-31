﻿using Specification.Builder;
using Specification.UnitTests.Fixture.Entities;

namespace Specification.UnitTests.Fixture.Specs;

public class StoreByIdIncludeProductsUsingStringSpec : Specification<Store>, ISingleResultSpecification
{
    public StoreByIdIncludeProductsUsingStringSpec(int id)
    {
        Query.Where(x => x.Id == id)
            .Include(nameof(Store.Products));
    }
}
