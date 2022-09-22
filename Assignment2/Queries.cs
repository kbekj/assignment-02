namespace Assignment2;

public class Queries
{
    public static IEnumerable<string> Rowling1(IEnumerable<Wizard> wzCol)=> 
    from wz in wzCol
    where wz.Creator.Contains("Rowling")
    select  wz.Name 
    ;

    public static IEnumerable<string> Rowling2(IEnumerable<Wizard> wzCol)=>
    wzCol.Where(x=>x.Creator.Contains("Rowling")).Select(x=>x.Name);

    public static int Sith1(IEnumerable<Wizard> wzCol)=>
    wzCol.Where(x=>x.Name.Contains("Darth")).Select(x => x.Year).Min().GetValueOrDefault()
    ;

    public static int Sith2(IEnumerable<Wizard> wzCol)=>
    (   from wz in wzCol
        where wz.Name.Contains("Darth")
        orderby wz.Year ascending
        select wz.Year).Min().GetValueOrDefault()
    ;

    public static IEnumerable<(string,int?)> HarryPotter1(IEnumerable<Wizard> wzCol)=>
        wzCol.Where(x => x.Medium.Contains("Harry Potter")).Select(x => new List<(string,int?)>{(x.Name , x.Year)}).SelectMany(x=>x.Distinct())
    ;

    public static IEnumerable<(string,int?)> HarryPotter2(IEnumerable<Wizard> wzCol)=> 
        from wz in wzCol
        where wz.Medium.Contains("Harry Potter")
        select (wz.Name, wz.Year)
    ;

    public static IEnumerable<string> reverseOrder1(IEnumerable<Wizard> wzCol)=> 
        (from wz in wzCol
        group wz by new {wz.Name,wz.Creator} into g
        orderby g.Key.Creator descending, g.Key.Name ascending
        select g.Key.Name)

    ;

    public static IEnumerable<string> reverseOrder2(IEnumerable<Wizard> wzCol)=>
             wzCol.OrderByDescending(x=>x.Creator)
             .GroupBy(grp => grp.Creator)
            .SelectMany(g => g.OrderBy(grp => grp.Name))
            .Select(x=>x.Name)
    ;


}
