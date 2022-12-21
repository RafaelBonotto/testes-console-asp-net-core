int[] ints1 = { 5, 3, 9, 7, 5, 9, 3, 7 };
int[] ints2 = { 8, 3, 6, 4, 4, 9, 1, 0 };

IEnumerable<int> union = ints1.Intersect(ints2);

foreach (int num in union)
{
    Console.Write("{0} ", num);
}






//static int[] ArrayDiff(int[] a, int[] b)
//{
//    List<int> response = new();

//    if(! a.Any())
//        return response.ToArray();

//    if (!b.Any())
//        return a;

//    foreach (var item in a.ToList())
//        foreach (var rem in b.ToList())
//            if (item != rem)
//                response.Add(item);

//    return response.ToArray();
//}

/*
 namespace Solution 
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void SampleTest()
    {
      Assert.AreEqual(new int[] {2},       Kata.ArrayDiff(new int[] {1, 2},    new int[] {1}));
      Assert.AreEqual(new int[] {2, 2},    Kata.ArrayDiff(new int[] {1, 2, 2}, new int[] {1}));
      Assert.AreEqual(new int[] {1},       Kata.ArrayDiff(new int[] {1, 2, 2}, new int[] {2}));
      Assert.AreEqual(new int[] {1, 2, 2}, Kata.ArrayDiff(new int[] {1, 2, 2}, new int[] {}));
      Assert.AreEqual(new int[] {},        Kata.ArrayDiff(new int[] {},        new int[] {1, 2}));
    }
  }
}
 
 */