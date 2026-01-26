using System;
using NUnit.Framework;
public class StringUtils{
    // Reverses the given string
    public string Reverse(string str){
        if(str == null){
            return null;
        }
        char[] chars = str.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
    // Checks if the string is a palindrome
    public bool IsPalindrome(string str){
        if(string.IsNullOrEmpty(str)){
            return false;
        }
        string lower = str.ToLower();
        int left = 0;
        int right = lower.Length - 1;
        while(left < right){
            if(lower[left] != lower[right]){
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
    // Converts string to uppercase
    public string ToUpperCase(string str){
        if(str == null){
            return null;
        }
        return str.ToUpper();
    }
}
[TestFixture]
public class StringUtilsTests{
    StringUtils utils;

    // Runs before each test
    [SetUp]
    public void Setup(){
        utils = new StringUtils();
    }
    [Test]
    public void Reverse_ValidString_ReturnsReversed(){
        Assert.AreEqual("olleh", utils.Reverse("hello"));
    }
    [Test]
    public void Reverse_EmptyString_ReturnsEmpty(){
        Assert.AreEqual("", utils.Reverse(""));
    }
    [Test]
    public void IsPalindrome_ValidPalindrome_ReturnsTrue(){
        Assert.IsTrue(utils.IsPalindrome("madam"));
    }
    [Test]
    public void IsPalindrome_NotPalindrome_ReturnsFalse(){
        Assert.IsFalse(utils.IsPalindrome("hello"));
    }
    [Test]
    public void IsPalindrome_CaseInsensitive_ReturnsTrue(){
        Assert.IsTrue(utils.IsPalindrome("MadAm"));
    }
    [Test]
    public void ToUpperCase_LowercaseString_ReturnsUppercase(){
        Assert.AreEqual("HELLO", utils.ToUpperCase("hello"));
    }
    [Test]
    public void ToUpperCase_MixedCase_ReturnsUppercase(){
        Assert.AreEqual("HELLO WORLD", utils.ToUpperCase("Hello World"));
    }
}
