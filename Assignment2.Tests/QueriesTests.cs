namespace Assignment2.Tests;

public class QueriesTests
{
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

     [Fact]
    public void HarryPotterWizards1(){
        var wizards = WizardCollection.Create();
        var result = Queries.HarryPotter1(wizards);
        result.Should().BeEquivalentTo(new [] {("Harry Potter", 1997),("Severus Snape", 1997)});
    } 

         [Fact]
    public void HarryPotterWizards2(){
        var wizards = WizardCollection.Create();
        var result = Queries.HarryPotter2(wizards);
        result.Should().BeEquivalentTo(new [] {("Harry Potter", 1997),("Severus Snape", 1997)});
    } 
    
    /////

    [Fact]
    public void Names_in_reverse_order_by_creator_then_name1(){
        var wizards = WizardCollection.Create();
        var result = Queries.reverseOrder1(wizards);

        Assert.Equal(new[] {"Jafar", "Dr. Strange", "Sauron", "Harry Potter", "Severus Snape", "Darth Maul", "Darth Vader", "The wizard Merlin", "Seth Avalon", "Jaina proudmoore"}, result);
    }
    [Fact]
    public void Names_in_reverse_order_by_creator_then_name2(){
        var wizards = WizardCollection.Create();
        var result = Queries.reverseOrder2(wizards);

        Assert.Equal(new[] {"Jafar", "Dr. Strange", "Sauron", "Harry Potter", "Severus Snape", "Darth Maul", "Darth Vader", "The wizard Merlin", "Seth Avalon", "Jaina proudmoore"}, result);
    }

}
