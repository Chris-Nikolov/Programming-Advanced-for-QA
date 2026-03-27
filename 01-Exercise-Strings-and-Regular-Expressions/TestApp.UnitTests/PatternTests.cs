using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish the test cases
    [TestCase("Tao", 3, "tAotAotAo")]
    [TestCase("Lee", 2, "lEelEe")]
    [TestCase("tomato#", 1, "tOmAtO#")]
    
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange
        input = "Cola";
        repetitionFactor = 4;
        expected = "cOlAcOlAcOlAcOlA";
        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        var input =  string.Empty;
        var repetitionFactor = 4;
        
        
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
        
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        var input =  "haha";
        var repetitionFactor = -1;
        
        
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        var input =  "hahaha";
        var repetitionFactor = 0;
        
        
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));
    }
}
