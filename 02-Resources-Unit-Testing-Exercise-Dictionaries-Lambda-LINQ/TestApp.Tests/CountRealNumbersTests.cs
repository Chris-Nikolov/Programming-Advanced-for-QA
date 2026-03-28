using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        var input = Array.Empty<int>();
        var expected = string.Empty;

        // Act
        var result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        var input = new int [] {1};
        var expected = "1 -> 1";

        // Act
        var result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        var input = new int [] { 1, 2, 3 };
        var expected = "1 -> 1\n" +
                             "2 -> 1\n" +
                             "3 -> 1";

        // Act
        var result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        var input = new int [] { -1, -2, -3, -1, -1 };
        var expected = "-3 -> 1\n" +
                            "-2 -> 1\n" +
                            "-1 -> 3";

        // Act
        var result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        var input = new int [] { 0, 0 };
        var expected = "0 -> 2";

        // Act
        var result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    
}
