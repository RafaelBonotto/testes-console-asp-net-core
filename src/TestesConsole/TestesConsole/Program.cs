using System.Collections.Generic;

static int[] CountBy(int x, int n)
{
    List<int> response = new();
    int incremento = x;

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