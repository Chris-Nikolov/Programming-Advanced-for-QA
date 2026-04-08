using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ArticleTests
{
    // TODO: write the setup method
    protected Article _article;

    // TODO: finish test
    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        this._article = new Article();
        var input = new string[]
        {
            "Mistborn Kelsier Sanderson",
            "Steelpush Allomancy Vin",
            "Philosophy Good Ham"
        };

        // Act

        var result = _article.AddArticles(input);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Mistborn"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Allomancy"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Ham"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        this._article = new Article();
        var input = new string[]
        {
            "Z-Article Secret Mary",
            "A-Article Aliens John",
            "M-Article Mistborn Brandon"
        };
        Article articleData = _article.AddArticles(input);

        // Act
        var result = _article.GetArticleList(articleData, "title");

        // Assert
        var expected = $"A-Article - Aliens: John\n" +
                            $"M-Article - Mistborn: Brandon\n" +
                             $"Z-Article - Secret: Mary";

        Assert.That(result, Is.EqualTo(expected));
    
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        this._article = new Article();
        var input = new string[] { "Mistborn LastEmpire Brandon" };
        Article articleData = _article.AddArticles(input);

        // Act
        var result = _article.GetArticleList(articleData, "missingCriteria");

        // Assert
        Assert.That(result, Is.Empty);
    }
}
