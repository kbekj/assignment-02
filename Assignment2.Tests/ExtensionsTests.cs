namespace Assignment2.Tests;

public class ExtensionsTests
{
    //-----------------------------------------------------------------------
    //one-liner tests
    [Fact]
    public void Flatten1_given_1_1_2_2_3_returns_1_2_3()
    {
        var xs = new IEnumerable<int>[1];
        xs[0] = new List<int>{1,1,2,2,3};
        var result = Extensions.Flatten1(xs);
        Console.WriteLine(Extensions.Flatten1(xs));
        result.Should().BeEquivalentTo(new List<int> {1,2,3});
    }

     [Fact]
        public void Flatten1_given_neg22_22_300_300_500returns_neg22_22_300_500()
    {
        var xs = new IEnumerable<int>[2];
        xs[0] = new List<int>{-22,22,300,300};
        xs[1] = new List<int>{500,500};
        var result = Extensions.Flatten1(xs);
        Console.WriteLine(Extensions.Flatten1(xs));
        result.Should().BeEquivalentTo(new List<int> {22,-22, 300, 500});
    }

    [Fact]
    public void Filter1_given_1_2_3_4_5_6_7_returns_null()
    {
        var ys = new int[3]{7,13,14};
        var result = Extensions.Filter1(ys);
        result.Should().BeEquivalentTo(new List<int> {});
    }

    [Fact]
    public void Filter1_given_42_48_45_70_returns_49_70()
    {
        var ys = new int[4]{42,49,45,70};
        var result = Extensions.Filter1(ys);
        result.Should().BeEquivalentTo(new List<int> {49,70});
    }

    [Fact]
    public void Filter2_given_2020_2016_2015_returns_2020_2016()
    {
        var ys = new int[3]{2020,2016,2015};
        var result = Extensions.Filter2(ys);
        result.Should().BeEquivalentTo(new List<int> {2020, 2016});
    }

    [Fact]
    public void Filter2_given_neg700_700_2024_returns_700_2024()
    {
        var ys = new int[3]{-700,2024,700};
        var result = Extensions.Filter2(ys);
        result.Should().BeEquivalentTo(new List<int> {2024, 700});
    }

    //---------------------------------------------------------------------------
    //Custom extension tests:
    
    [Fact]
        public void isSecure_given_safe_returns_true()
    {
        var link = new Uri("https://learnit.itu.dk/");
        var result = Extensions.isSecure(link);
        result.Should().Be(true);
    }

        [Fact]
        public void isSecure_given_notSafe_returns_false()
    {
        var link = new Uri("http://info.cern.ch");
        var result = Extensions.isSecure(link);
        result.Should().Be(false);
    }


    [Fact]
    public void WordCount_given_Hello_there_returns_2()
    {
        var words = "Hello, there";
        var result = Extensions.WordCount(words);
        result.Should().Be(2);
    }

    [Fact]
    public void WordCount_given_I_am_22_years_1_old_returns_4()
    {
        var words = "I am the 22 years old 1";
        var result = Extensions.WordCount(words);
        result.Should().Be(5);
    }

    [Fact]
    public void WordCount_given_numbers_returns_null()
    {
        var words = "I am the 22 years old 1";
        var result = Extensions.WordCount(words);
        result.Should().Be(5);
    }

        [Fact]
    public void WordCount_given_null_returns_null()
    {
        var words = "I am the 22 years old 1";
        var result = Extensions.WordCount(words);
        result.Should().Be(5);
    }

    


}
