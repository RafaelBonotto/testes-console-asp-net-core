
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
    int len = cc.Length;

    if (len <= 4)
        return cc;

    return cc.Substring(len - 4).PadLeft(len, '#');
}

