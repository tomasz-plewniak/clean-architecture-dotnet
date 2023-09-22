using Specification.UnitTests.Fixture.Entities;
using Specification.UnitTests.Fixture.Specs;
using Specification.UnitTests.Fixture.SpecsForIncludeTests;

namespace Specification.UnitTests.BuilderTests;

public class SpecificationBuilderExtensions_IncludeString
{
    [Fact]
    public void AddsNothingToList_GivenNoIncludeStringExpression()
    {
        var spec = new StoreEmptySpec();

        spec.WhereExpressions.Should().BeEmpty();
    }

    [Fact]
    public void AddsNothingToList_GivenIncludeStringWithFalseCondition()
    {
        var spec = new CompanyByIdWithFalseConditions(1);

        spec.IncludeStrings.Should().BeEmpty();
    }

    [Fact]
    public void AddsIncludeStringToList_GivenString()
    {
        var spec = new StoreIncludeCompanyThenCountryAsStringSpec();

        var expected = $"{nameof(Company)}.{nameof(Company.Country)}";

        spec.IncludeStrings.Should().ContainSingle();
        spec.IncludeStrings.Single().Should().Be(expected);
    }
}
