using FluentAssertions;
using Xunit;

namespace MyNugetPackage.Tests;

public class UnitTest
{
    private const string MethodOneOutput = "Output from method one.";
    private const string MethodTwoOutput = "Output from method two.";

    [Fact]
    public void TestMethodOne()
    {
        MySampleService.MethodOne().Should().Be(MethodOneOutput);
    }

    [Fact]
    public void TestMethodTwo()
    {
        MySampleService.MethodTwo().Should().Be(MethodTwoOutput);
    }
}