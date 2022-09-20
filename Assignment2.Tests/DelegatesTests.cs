namespace Assignment2.Tests;

public class DelegatesTests
{
    
    //String reverse
    Action<string> ReverseString = s => 
    {
        foreach (var n in s.Reverse().ToList())
        {
            Console.Write(n);
        }
    };
    
    //Product
    Func<int, int, int> product = (i, i1) => i * i1; 
    
    //Number and string equality
    private Func<string, int, Boolean> equal = ((s, i) => Convert.ToInt32(s)== i); 
    
    


    [Fact]
    public void Reverse_Hello_should_print_olleH()
    {
        //Arrange
        var writer = new StringWriter();
        Console.SetOut(writer);
        //Act
        ReverseString("Hello");
        //Assert
        Assert.Equal("olleH",writer.ToString());
    }
    [Fact]
    public void Reverse_Hello_should_not_print_Hello()
    {
        //Arrange
        var writer = new StringWriter();
        Console.SetOut(writer);
        //Act
        ReverseString("Hello");
        //Assert
        Assert.NotEqual("Hello",writer.ToString());
    }
    
    [Fact]
    public void two_times_32_should_return_64()
    {
        //Arrange
        //Act
        var actual = product(2, 32);
        //Assert
        actual.Should().Be(64);
    }
    
    [Fact]
    public void four_times_minus_8_should_return_minus_32()
    {
        //Arrange
        //Act
        var actual = product(4, -8);
        //Assert
        actual.Should().Be(-32);
    }
    
    [Fact]
    public void string_thirtytwo_should_be_int_thirtytwo()
    {
        //Arrange
        //Act
        var actual = equal("32", 32);
        //Assert
        actual.Should().Be(true);
    }
    
    [Fact]
    public void string_00050_should_be_int_50()
    {
        //Arrange
        //Act
        var actual = equal("00050", 50);
        //Assert
        actual.Should().Be(true);
    }
}

