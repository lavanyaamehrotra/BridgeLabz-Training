using System;
using System.Collections.Generic;
public class ListManager{
    // Adds an element to the list
    public void AddElement(List<int> list, int element){
        if(list == null){
            throw new ArgumentNullException("list");
        }
        list.Add(element);
    }
    // Removes an element from the list
    public void RemoveElement(List<int> list, int element){
        if(list == null){
            throw new ArgumentNullException("list");
        }
        list.Remove(element);
    }
    // Returns the size of the list
    public int GetSize(List<int> list){
        if(list == null){
            throw new ArgumentNullException("list");
        }
        return list.Count;
    }
}
[TestFixture]
public class ListManagerTests{
    ListManager manager;
    List<int> numbers;
    // Runs before each test
    [SetUp]
    public void Setup(){
        manager = new ListManager();
        numbers = new List<int>();
    }
    [Test]
    public void AddElement_AddsValueToList(){
        manager.AddElement(numbers, 10);
        Assert.Contains(10, numbers);
    }
    [Test]
    public void RemoveElement_RemovesValueFromList(){
        numbers.Add(10);
        numbers.Add(20);
        manager.RemoveElement(numbers, 10);
        Assert.IsFalse(numbers.Contains(10));
    }
    [Test]
    public void GetSize_ReturnsCorrectSize(){
        numbers.Add(5);
        numbers.Add(15);
        numbers.Add(25);
        int size = manager.GetSize(numbers);
        Assert.AreEqual(3, size);
    }
}
