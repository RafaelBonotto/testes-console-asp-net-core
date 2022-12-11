using System.Linq;

static Object Sub(Object a, Object b)
{
    string x = a.ToString();
    string y = b.ToString();

    foreach (var caracter in y)
        foreach (var caract in x)
            if (caract.Equals(caracter))
                x.Remove(caract);

   return x;
}

Console.WriteLine(Sub("Yes or no", "orn "));
