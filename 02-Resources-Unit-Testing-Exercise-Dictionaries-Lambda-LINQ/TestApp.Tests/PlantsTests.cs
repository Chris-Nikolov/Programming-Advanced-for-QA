using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        var plants = Array.Empty<string>();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    // TODO: finish test
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        var plants = new string[] { "tulip" };
        var expected = "Plants with 5 letters:\ntulip";

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        var plants = new string[] { "tulip", "lotus", "rosa", "lily" };
        var expected = "Plants with 4 letters:\nrosa\nlily\n" +
                       "Plants with 5 letters:\ntulip\nlotus";
        string result = Plants.GetFastestGrowing(plants);
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        var plants = new string[] { "tuLip", "Lotus", "rosa", "LiLy" };
        var expected = "Plants with 4 letters:\nrosa\nLiLy\n" +
                       "Plants with 5 letters:\ntuLip\nLotus";
        string result = Plants.GetFastestGrowing(plants);
        Assert.That(result, Is.EqualTo(expected));
    }
}
