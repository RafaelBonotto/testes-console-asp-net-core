using System.Linq;

static Object Sub(Object a, Object b)
{
    string A = a.ToString();
    string B = b.ToString();
    string response = string.Empty;
    foreach (var caracter in B)
    {
        while (A.Contains(caracter))
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].Equals(caracter))
                {
                    A = A.Substring(0, (i - 1)) + A.Substring(i);
                    break;
                }
            }
        }
    }        

   return A;
}

Console.WriteLine(Sub("Yes or no", "orn "));

var str = "12345";


//string str1 = str.Substring(0, (3 - 1));
//var str2 = str.Substring(3);
//Console.WriteLine(str1 + str2);