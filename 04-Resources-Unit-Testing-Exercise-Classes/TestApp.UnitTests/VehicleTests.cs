using NUnit.Framework;

using System;

using TestApp.Vehicle;

namespace TestApp.UnitTests;

public class VehicleTests
{
    // TODO: write the setup method
    private Vehicles _vehicles = new Vehicles();

    // TODO: finish test
    [Test]
    public void Test_AddAndGetCatalogue_ReturnsSortedCatalogue()
    {
        // Arrange
        var input = new string[] { "Truck/Volvo/VNL/500", 
                                    "Car/Toyota/Camry/150", 
                                    "Car/Ford/Focus/120",
        }; 
        string expected = $"Cars:{Environment.NewLine}Ford: Focus - 120hp" +
                          $"{Environment.NewLine}Toyota: Camry - 150hp" +
                          $"{Environment.NewLine}Trucks:" +
                          $"{Environment.NewLine}Volvo: VNL - 500kg";

        // Act
        string result = this._vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetCatalogue_ReturnsEmptyCatalogue_WhenNoDataGiven()
    {
        // Arrange
        var input = new string[] {};
        var expected = "Cars:\nTrucks:";
 
        // Act
        string result = this._vehicles.AddAndGetCatalogue(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
