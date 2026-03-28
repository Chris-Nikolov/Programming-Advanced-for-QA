using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        var input = Array.Empty<string>();
        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    // TODO: finish test
    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        // Arrange
        var input = new string[] { "Gold 4", "Silver 30", "Gold 4" };
        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        // Arrange
        var input = new string[] { "Gold 4", "Silver 30", "Gold 4", "Arctic 11", "Gold 2", "Arctic 9", "Silver 10", "Tin 8" };
        // Act
        string result = Miner.Mine(input);

        // Assert
        Assert.That(result, Is.EqualTo("gold -> 10\n" +
                                       "silver -> 40\n" +
                                       "arctic -> 20\n" +
                                       "tin -> 8"));
    }
}
