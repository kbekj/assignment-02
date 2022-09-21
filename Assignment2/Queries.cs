namespace Assignment2;

public class Queries
{
    public static IEnumerable<String> Rowling1(IEnumerable<Wizard> wzCol)=> 
    from wz in wzCol
    where wz.Creator.Contains("Rowling")
    select  wz.Name 
    ;

    public static IEnumerable<String> Rowling2(IEnumerable<Wizard> wzCol)=> throw new NotImplementedException();
    //wzCol.Where(x=>x.Creator.Contains("Rowling")).ToList();

    public static int Sith1(IEnumerable<Wizard> wzCol)=>throw new NotImplementedException()

    ;

    public static int Sith2(IEnumerable<Wizard> wzCol)=> throw new NotImplementedException();

    public static IEnumerable<T> HarryPotter1<T>()=> throw new NotImplementedException();

    public static IEnumerable<T> HarryPotter2<T>()=> throw new NotImplementedException();

    public static IEnumerable<T> reverseOrderByNameThenWiz1<T>()=> throw new NotImplementedException();

    public static IEnumerable<T> reverseOrderByNameThenWiz2<T>()=> throw new NotImplementedException();


}
