namespace FirstApp.Tests;
using FirstApp;

public class IsLeapYearTest
{

[Theory]
[InlineData(1653)]
[InlineData(1654)]
[InlineData(1800)]

    public void IsLeapYear_given_non_leapYear_returns_false(int year)
    {
        //Arrange
        //Act
        var result = LeapYearCheck.IsLeapYear(year);
        
        //Assert
        result.Should().BeFalse();
    }

[Theory]
[InlineData(2000)]
[InlineData(2004)]
[InlineData(2012)]

    public void IsLeapYear_given_leapYear_returns_true(int year)
    {
        //Arrange
        //Act
        var result = LeapYearCheck.IsLeapYear(year);
        
        //Assert
        result.Should().BeTrue();
    }
}