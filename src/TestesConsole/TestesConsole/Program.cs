
using System.Text;

var input = "dlrow";
//StringBuilder response = new();
//var length = input.Length - 1;

//for (int i = length; i >= 0 ; i--)
//    response.Append(input[i].ToString());

//Console.WriteLine(response.ToString());

Console.WriteLine(new string(input.Reverse().ToArray()));