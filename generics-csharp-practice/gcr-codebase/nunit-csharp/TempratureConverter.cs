using NUnit.Framework;
public class TemperatureConverter{
    // Converts Celsius to Fahrenheit
    public double CelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }
    // Converts Fahrenheit to Celsius
    public double FahrenheitToCelsius(double fahrenheit){
        return (fahrenheit - 32) * 5 / 9;
    }
}
[TestFixture]
public class TemperatureConverterTests{
    TemperatureConverter converter;
    [SetUp]
    public void Setup(){
        converter = new TemperatureConverter();
    }
    [Test]
    public void CelsiusToFahrenheit_Test(){
        double result = converter.CelsiusToFahrenheit(0);
        Assert.AreEqual(32, result);
    }
    [Test]
    public void FahrenheitToCelsius_Test(){
        double result = converter.FahrenheitToCelsius(32);
        Assert.AreEqual(0, result);
    }
    [Test]
    public void CelsiusToFahrenheit_AnotherValue(){
        Assert.AreEqual(212, converter.CelsiusToFahrenheit(100));
    }
    [Test]
    public void FahrenheitToCelsius_AnotherValue(){
        Assert.AreEqual(100, converter.FahrenheitToCelsius(212));
    }
}
