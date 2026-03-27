using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        var bannedWords = new string[] {"Apple"};
        var text = "aliens are coming from orion";
        
        // Act
        var result = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        var bannedWords = new string[] { "aliens" };
        var  text = "aliens are coming from orion";
        var expected = "****** are coming from orion";
        
        // Act
        var result = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        var bannedWords = Array.Empty<string>();
        var text = "aliens are coming from orion";
        
        // Act
        var result = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(result, Is.EqualTo(text));
    }
    

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        var bannedWords = new string[] {"Michael Heiser", "Ancient Aliens"};
        var text = "Michael Heiser rejects the theory of Ancient Aliens";
        var expected = "************** rejects the theory of **************";
        
        // Act
        var result = TextFilter.Filter(bannedWords, text);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
