using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";

        // Act
        string expected = "The quick brown jumps over the lazy dog";

        // Assert
        Assert.That(expected, Is.EqualTo(Substring.RemoveOccurrences(toRemove, input)));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string toRemove = "Nothing";
        string input = "Nothing is better than Apple";

        // Act
        string expected = "is better than Apple";

        // Assert
        Assert.That(expected, Is.EqualTo(Substring.RemoveOccurrences(toRemove, input)));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string toRemove = "Orion";
        string input = "Aliens are coming from Orion";

        // Act
        string expected = "Aliens are coming from";

        // Assert
        Assert.That(expected, Is.EqualTo(Substring.RemoveOccurrences(toRemove, input)));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string toRemove = "Orion";
        string input = " Orion aliens are coming from Orion and Apple products don't come from Orion";

        // Act
        string expected = "aliens are coming from and Apple products don't come from";

        // Assert
        Assert.That(expected, Is.EqualTo(Substring.RemoveOccurrences(toRemove, input)));
    }
}
