using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesConsole
{
    public class Teste
    {
        public void SetValores(out string var1)
        {
            var1 = "Setado";
        }

        public void Inicializar()
        {
            var variavel = "empty";
            SetValores(out variavel);
            Console.WriteLine(variavel);
        }
    }
}
