using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class StudentTests
{
    private Student _student;

    [SetUp]
    public void SetUp()
    {
        this._student = new();
    }

    // TODO: finish test
    [Test]
    public void Test_AddAndGetByCity_ReturnsStudentsInCity_WhenCityExists()
    {
        // Arrange
        string[] students = { "John Doe 25 Sofia", "Jane Smith 22 Varna", "Alice Johnson 20 Sofia", "Cody Rhodes 47 Vraca" };
        string expected = $"John Doe is 25 years old.{Environment.NewLine}Alice Johnson is 20 years old.";
        var wantedTown = "Sofia";
        
        // Act
        var studentList = new Student();
        var result = studentList.AddAndGetByCity(students, wantedTown);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsEmptyString_WhenCityDoesNotExist()
    {
        // Arrange
        string[] students = { "John Doe 25 Sofia", "Jane Smith 22 Varna", "Alice Johnson 20 Sofia", "Cody Rhodes 47 Vraca" };
        var wantedTown = "London";
        
        // Act
        var studentList = new Student();
        var result = studentList.AddAndGetByCity(students, wantedTown);

        // Assert
        Assert.That(result, Is.EqualTo(String.Empty));
    }

    [Test]
    public void Test_AddAndGetByCity_ReturnsEmptyString_WhenNoStudentsGiven()
    {
         // Arrange
         string[] students = {};
        var wantedTown = "Sofia";
        
        // Act
        var studentList = new Student();
        var result = studentList.AddAndGetByCity(students, wantedTown);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }
}
