﻿using Specification.UnitTests.Fixture.Specs;

namespace Specification.UnitTests.BuilderTests;

public class SpecificationBuilderExtensions_SelectMany
{
    [Fact]
    public void SetsNothing_GivenNoSelectManyExpression()
    {
        var spec = new StoreProductNamesEmptySpec();

        spec.SelectorMany.Should().BeNull();
    }

    [Fact]
    public void SetsSelectorMany_GivenSelectManyExpression()
    {
        var spec = new StoreProductNamesSpec();

        spec.SelectorMany.Should().NotBeNull();
    }
}
