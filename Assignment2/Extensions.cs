namespace Assignment2;

public static class Extensions
{

//public static IEnumerable<int>[] leapNumbers(this IEnumerable<int>[] nums) => new IEnumerable<int>[nums.Max()];

public static IEnumerable<T> Flatten1<T>(IEnumerable<T>[] xs)=> xs.SelectMany(x => x).Distinct().ToList();

public static IEnumerable<int> Filter1(int[] ys)=> ys.Where(x => ((x % 7 == 0) && (x > 42)));

public static IEnumerable<int> Filter2(int[] ys)=> ys.Where(x => ((x % 4 == 0) && (x > 0)));

public static bool isSecure(this string s) => throw new NotImplementedException();

public static int WordCount(this string s) => throw new NotImplementedException();       

}

