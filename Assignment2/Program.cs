/*foreach (var wizard in WizardCollection.Create())
{
    Console.WriteLine(wizard);
}
*/

        var wizards = WizardCollection.Create();
        var result = Queries.reverseOrder2(wizards);
        foreach(var v in result){
        Console.WriteLine(v);
        }
        