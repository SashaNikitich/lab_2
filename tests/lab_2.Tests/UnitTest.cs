namespace lab_2.Tests;


[TestFixture]
public class PalindromeTests
{
    [Test]
    public void FindLongestPalindrome_Multiple_ReturnsLongest()
    {
        //Arrange
        string text = "Пилип бачив радар та аніліна";
        string expected = "аніліна";

        //Act
        string result = Palindrome.FindLongestPalindrome(text);
        
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase("Радар", true)]
    [TestCase("А", false)]
    [TestCase("аніліна", true)]
    [TestCase("Програма", false)]
    
    public void IsPalindrome_DifferentInputs_ReturnsExpected(string word, bool expected)
    {
        //Act
        bool result = Palindrome.IsPalindrome(word);
        
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}