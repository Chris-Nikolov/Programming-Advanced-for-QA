using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        var input = Array.Empty<string>();
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        var input = new[] { "one" };
        var expected = "one";
        
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        var input = new[] { "one",  "two", "three" };
        var expected = "threetwoone";
        
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
       
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(null);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        var input = new[] { "one", " ",  "two", " ", "three" };
        var expected = "three two one";
        
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        var input = Enumerable.Range(1, 1000)
            .Select(n => n.ToString())
            .ToArray();
        var expected = string.Concat(Enumerable.Range(1, 1000).Reverse());
        
        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
