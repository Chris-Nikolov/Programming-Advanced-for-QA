using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        var input1 = new Dictionary<string, int>();
        var input2 = new Dictionary<string, int>();
        
        var result =DictionaryIntersection.Intersect(input1, input2);
        
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        var input1 = new Dictionary<string, int>
        {
            { "one", 1 },
            { "two", 2 }
        };
        var input2 = new Dictionary<string, int>();
        
        var result =DictionaryIntersection.Intersect(input1, input2);
        
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        var input1 = new Dictionary<string, int>
        {
            { "one", 1 },
            { "two", 2 }
        };
        var input2 = new Dictionary<string, int>
        {
            { "three", 3 },
            { "four", 4 }
        };
        
        var result =DictionaryIntersection.Intersect(input1, input2);
        
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        var input1 = new Dictionary<string, int>
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "Shadowmourne", 150 }
        };
        var input2 = new Dictionary<string, int>
        {
            { "three", 3 },
            { "four", 4 },
            { "Shadowmourne", 150 }
        };
        var expected = new Dictionary<string, int>
        {
            {"three", 3},
            {"Shadowmourne", 150},
        };
        var result =DictionaryIntersection.Intersect(input1, input2);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        var input1 = new Dictionary<string, int>
        {
            { "three", 4 },
            { "Shadowmourne", 150 }
        };
        var input2 = new Dictionary<string, int>
        {
            { "three", 3 },
            { "Shadowmourne", 120 }
        };
       
        var result = DictionaryIntersection.Intersect(input1, input2);
        
        Assert.That(result, Is.Empty);
    }
}
