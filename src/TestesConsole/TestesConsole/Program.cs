using System.Collections.Generic;

static int[] CountBy(int x, int n)
{
    List<int> response = new();
    int incremento = 1;

    while (incremento <= n)
    {
        response.Add(x * incremento);
        incremento++;
    }
    return response.ToArray();
}

var resp = CountBy(2, 5);
foreach (var item in resp)
{
    Console.Write(item + " , ");
}

/* Code Wars Challenge Count by x (Arrays C#)

[TestFixture]
public static class Test
{
  [Test]
  public static void CountBy1()
  {
    Assert.AreEqual(new int[] {1,2,3,4,5}, Kata.CountBy(1,5), "Array does not match");
  }
  
  [Test]
  public static void CountBy2()
  {
    Assert.AreEqual(new int[] {2,4,6,8,10}, Kata.CountBy(2,5), "Array does not match");
  }
}
 */