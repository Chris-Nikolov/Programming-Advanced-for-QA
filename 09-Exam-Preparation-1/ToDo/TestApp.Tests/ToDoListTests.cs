using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }
    
    [Test]
    public void Test_AddTask_TaskAddedToToDoList()
    {

        _toDoList.AddTask("Task", DateTime.Now);

        var expected = "To-Do List:\n" +
                       $"[ ] Task - Due: 04/16/2026";
        
        var result = this._toDoList.DisplayTasks();
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted()
    {
        _toDoList.AddTask("Task", DateTime.Now);

        _toDoList.CompleteTask("Task");
        
        var expected = "To-Do List:\n" +
                       $"[✓] Task - Due: 04/16/2026";
        
        var result =  this._toDoList.DisplayTasks();
        
        Assert.That(result, Is.EqualTo(expected));


    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        _toDoList.AddTask("Task", DateTime.Now);
        
        var expected = Assert.Throws<ArgumentException>(() => _toDoList.CompleteTask("Task2"));
        
        Assert.That(expected.Message, Is.EqualTo("Task with given title does not exist."));
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        var expected = "To-Do List:";
        var result = this._toDoList.DisplayTasks();
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList()
    {
        _toDoList.AddTask("Task", DateTime.Now);
        _toDoList.AddTask("Task2", DateTime.Now);
        _toDoList.AddTask("Task3", DateTime.Now);
        _toDoList.AddTask("Task4", DateTime.Now);

        _toDoList.CompleteTask("Task");
        _toDoList.CompleteTask("Task3");

        var expected = "To-Do List:\n" +
                       "[✓] Task - Due: 04/16/2026\n" +
                       "[ ] Task2 - Due: 04/16/2026\n" +
                       "[✓] Task3 - Due: 04/16/2026\n" +
                       "[ ] Task4 - Due: 04/16/2026";
                       
        
        var result =  this._toDoList.DisplayTasks();
        
        Assert.That(result, Is.EqualTo(expected));
    }
}
