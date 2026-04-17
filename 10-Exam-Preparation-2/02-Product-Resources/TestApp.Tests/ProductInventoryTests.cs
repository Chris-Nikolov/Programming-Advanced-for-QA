using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        _inventory.AddProduct("Banana", 2.5, 2);

        var expected = "Product Inventory:\n" +
                       "Banana - Price: $2.50 - Quantity: 2";

        var result = this._inventory.DisplayInventory();
        
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        var expected = "Product Inventory:";
        
        var result = this._inventory.DisplayInventory();
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        _inventory.AddProduct("Banana", 2.5, 2);
        _inventory.AddProduct("Strawberry", 3.5, 10);

        var expected = "Product Inventory:\n" +
                       "Banana - Price: $2.50 - Quantity: 2\n" +
                       "Strawberry - Price: $3.50 - Quantity: 10";

        var result = this._inventory.DisplayInventory();
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        var result = this._inventory.CalculateTotalValue();
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        _inventory.AddProduct("Banana", 2.5, 2);
        _inventory.AddProduct("Strawberry", 3.5, 10);

        var expected = 40.00;
        var result = this._inventory.CalculateTotalValue();
        Assert.That(result, Is.EqualTo(expected));
    }
}
