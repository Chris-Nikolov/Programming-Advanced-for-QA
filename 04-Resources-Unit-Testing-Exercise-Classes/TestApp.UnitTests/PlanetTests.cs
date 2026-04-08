using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PlanetTests
{
    // TODO: finish test
    [Test]
    public void Test_CalculateGravity_ReturnsCorrectCalculation()
    {
        // Arrange
        var name = "Earth";
        var diameter = 12742.0;
        var distance = 149600000.0;
        var moons = 1;
        Planet earth = new(name, diameter, distance, moons);
        
        var mass = 1000.0;
        var radius = diameter / 2.0;
        var expectedGravity = mass * 6.67430e-11 / (radius * radius);

        // Act
        var result = earth.CalculateGravity(mass);

        // Assert
        Assert.That(result, Is.EqualTo(expectedGravity));
    }

    [Test]
    public void Test_GetPlanetInfo_ReturnsCorrectInfo()
    {
        // Arrange
        Planet mars = new("Mars", 6779, 227900000, 2);
        
        var expected = $"Planet: Mars\n" +
                          $"Diameter: 6779 km\n" +
                          $"Distance from the Sun: 227900000 km\n" +
                          $"Number of Moons: 2";

        // Act
        var result = mars.GetPlanetInfo();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
