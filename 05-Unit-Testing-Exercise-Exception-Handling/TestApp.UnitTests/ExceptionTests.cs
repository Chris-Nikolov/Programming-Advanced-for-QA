using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
         var input = "Mistborn";
         var expected = "nrobtsiM";

        // Act
        var result = _exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;
        

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        //Arrange
        decimal totalPrice = 100;
        decimal discount = 10;
        decimal discountedPrice = 90;
        
        //Act
        var result = _exceptions.ArgumentCalculateDiscount(totalPrice, discount);
        
        //Assert
        Assert.That(result, Is.EqualTo(discountedPrice));
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100;
        decimal discount = -11;
        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    // TODO: finish test
    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        //Arrange
        var input = new int[] { 10, 20, 30, 40, 50 };
        var index = 1;
        var expected = 20;
        
        //Act
        var result = _exceptions.IndexOutOfRangeGetElement(input, index);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        var array = new int[] { 10, 20, 30, 40, 50 };
        var index = -2;
        var expected = 20;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    // TODO: finish test
    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());

        
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length + 1;

        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        var input = true;
        var expected = "User logged in.";
        
        // Act
        var result = _exceptions.InvalidOperationPerformSecureOperation(input);
        
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        var input = false;
        
        // Act & Assert
        Assert.That(() => _exceptions.InvalidOperationPerformSecureOperation(input), Throws.TypeOf<InvalidOperationException>());
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        
        var input = "6";
        var expected = 6;
        
        // Act
        
        var result = _exceptions.FormatExceptionParseInt(input);
        
        // Assert
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        // Arrange
        
        var input = "a5";
        
        // Act & Assert
        
        Assert.That(() => _exceptions.FormatExceptionParseInt(input), Throws.TypeOf<FormatException>());
        
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        // Arrange
        
        var dictionary = new Dictionary<string, int> { { "key1", 1 }, { "key2", 2 } };
        var key = "key2";
        var expected = 2;
        
        // Act
        
        var result = _exceptions.KeyNotFoundFindValueByKey(dictionary, key);
        
        // Assert
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        //Arrange 
        
        var dictionary = new Dictionary<string, int> { { "key1", 1 }, { "key2", 2 } };
        var key = "key3";
        
        // Act & Assert
        
        Assert.That(() => _exceptions.KeyNotFoundFindValueByKey(dictionary, key), Throws.TypeOf<KeyNotFoundException>());
        
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange

        var inputA = 49;
        var inputB = 26;
        var expected = 75;
        
        // Act 
        
        var result = _exceptions.OverflowAddNumbers(inputA, inputB);
        
        // Assert
        
        Assert.That(result, Is.EqualTo(expected));
        
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange

        var inputA = int.MaxValue;
        var inputB = 1;
        
        // Act & Assert
        
        Assert.That(() => _exceptions.OverflowAddNumbers(inputA, inputB), Throws.TypeOf<OverflowException>());
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        var inputA = int.MinValue;
        var inputB = -1;
        
        // Act & Assert
        
        Assert.That(() => _exceptions.OverflowAddNumbers(inputA, inputB), Throws.TypeOf<OverflowException>());
    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        
        var  inputA = 12;
        var inputB = 6;
        var expected = 2;
        
        // Act 
        
        var result = _exceptions.DivideByZeroDivideNumbers(inputA, inputB);
        
        // Assert
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        
        var  inputA = 12;
        var inputB = 0;
        
        // Act & Assert
        
        Assert.That(() => _exceptions.DivideByZeroDivideNumbers(inputA, inputB), Throws.TypeOf<DivideByZeroException>());
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange 
        
        var input = new[] { 1, 2, 3, 4, 5 };
        var index = 3;
        var expected = 15;
        
        //Act
        
        var result = _exceptions.SumCollectionElements(input, index);
        
        //Assert 
        
        Assert.That(result, Is.EqualTo(expected));
        
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        
        int[]  input = null;
        var index = 2;
        
        // Act & Assert
        
        Assert.That(() => _exceptions.SumCollectionElements(input, index), Throws.TypeOf<ArgumentNullException>());
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange 
        
        var input = new[] { 1, 2, 3, 4, 5 };
        var index = 5;
        
        // Act & Assert
        
        Assert.That(() => _exceptions.SumCollectionElements(input, index), Throws.TypeOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange
        
        var input = new Dictionary<string, string> { { "first", "1" }, { "second", "2" } };
        var key = "second";
        var expected = 2;
        
        // Act 
        
        var result = _exceptions.GetElementAsNumber(input, key);
        
        // Assert
        
        Assert.That(result, Is.EqualTo(expected));
        
        
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange
        
        var input = new Dictionary<string, string> { { "first", "1" }, { "second", "2" } };
        var key = "third";
        
        // Act & Assert
        
        Assert.That(() => _exceptions.GetElementAsNumber(input, key), Throws.TypeOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        
        var input = new Dictionary<string, string> { { "first", "1w" }, { "second", "2l" } };
        var key = "second";
        
        // Act & Assert
        
        Assert.That(() => _exceptions.GetElementAsNumber(input, key), Throws.TypeOf<FormatException>());
    }
}
