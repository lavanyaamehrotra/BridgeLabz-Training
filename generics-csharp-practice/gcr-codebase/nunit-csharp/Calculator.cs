using System;
using NUnit.Framework;
// Calculator class
public class Calculator{
    //ADD
    public int Add(int a, int b){
        return a + b;
    }
    //SUBTRACT
    public int Subtract(int a, int b){
        return a - b;
    }
    //MULTIPLY
    public int Multiply(int a, int b){
        return a * b;
    }
    //DIVIDE
    public int Divide(int a, int b){
        if(b == 0){
            throw new DivideByZeroException("Cannot divide by zero");
        }
        return a / b;
    }
}
// NUnit test class
[TestFixture]
public class CalculatorTests{
    Calculator calc;
    [SetUp]
    public void Setup(){
        calc = new Calculator();
    }
    [Test]
    public void Add_Test(){
        Assert.AreEqual(10, calc.Add(5, 5));
    }
    [Test]
    public void Subtract_Test(){
        Assert.AreEqual(5, calc.Subtract(10, 5));
    }
    [Test]
    public void Multiply_Test(){
        Assert.AreEqual(20, calc.Multiply(4, 5));
    }
    [Test]
    public void Divide_Test(){
        Assert.AreEqual(2, calc.Divide(10, 5));
    }
}
