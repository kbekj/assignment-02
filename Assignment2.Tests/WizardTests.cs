namespace Assignment2.Tests;

public class WizardTests
{
    [Fact]
    public void WizardCollection_contains_10_wizards()
    {
        var wizards = WizardCollection.Create();

        Assert.Equal(10, wizards.Count());
    }

    [Theory]
    [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
    [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
    public void Spot_check_wizards(string name, string medium, int year, string creator)
    {
        var wizards = WizardCollection.Create();

        Assert.Contains(wizards, w => w == new Wizard(name, medium, year, creator));
    }

    [Fact]
    public void findRowlingWizards1(){
        var wizards = WizardCollection.Create();
        var result = Queries.Rowling1(wizards);

        Assert.Equal(new[] {"Harry Potter", "Severus Snape"}, result);
    }

    [Fact]
    public void findRowlingWizards2(){
        var wizards = WizardCollection.Create();
        var result = Queries.Rowling2(wizards);

        Assert.Equal(new[] {"Harry Potter", "Severus Snape"}, result);
    }

    [Fact]
    public void findFirstSithLordsYear1(){
        var wizards = WizardCollection.Create();
        var result = Queries.Sith1(wizards);

        result.Should().Be(1977);
    }

     [Fact]
    public void findFirstSithLordsYear2(){
        var wizards = WizardCollection.Create();
        var result = Queries.Sith2(wizards);

        result.Should().Be(1977);
    }
}

