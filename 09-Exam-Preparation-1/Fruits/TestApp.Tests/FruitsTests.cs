using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        var input = new Dictionary<string, int>
        {
            { "banana", 5 },
        };
        var expected = 5;
        
        var fruitName = "banana";
        
        var result = Fruits.GetFruitQuantity(input, fruitName);
        
        Assert.That(result, Is.EqualTo(expected));
        
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        var input = new Dictionary<string, int>
        {
            { "banana", 5 },
        };
        var expected = 0;
        
        var fruitName = "strawberry";
        
        var result = Fruits.GetFruitQuantity(input, fruitName);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        var input = new Dictionary<string, int>();
        
        var expected = 0;
        
        var fruitName = "strawberry";
        
        var result = Fruits.GetFruitQuantity(input, fruitName);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        var expected = 0;
        
        var fruitName = "strawberry";
        
        var result = Fruits.GetFruitQuantity(null, fruitName);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        var input = new Dictionary<string, int>
        {
            { "banana", 5 },
        };
        var expected = 0;
        
        var result = Fruits.GetFruitQuantity(input, null);
        
        Assert.That(result, Is.EqualTo(expected));
    }
}
