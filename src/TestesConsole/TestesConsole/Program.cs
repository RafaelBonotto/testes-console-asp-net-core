
// CODE WARS 'Credit Card Mask'
/* 
    Assert.AreEqual("############5616", Kata.Maskify("4556364607935616"));
    Assert.AreEqual("1", Kata.Maskify("1"));
    Assert.AreEqual("#1111", Kata.Maskify("11111")); 
 */
var mask = "11111";
Console.WriteLine(Maskify(mask));

static string Maskify(string cc)
{
    if (cc.Length < 4)
        return cc;

    var aux = cc.Substring(cc.Length - 4);
    string ret = string.Empty;

    for (int i = 0; i < cc.Length - 4; i++)
        ret += "#";

    ret += aux;

    return ret;
}

