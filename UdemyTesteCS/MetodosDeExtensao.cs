using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTesteCS
{
    public static class ExtensoesInteiros
    {
        public static int Soma(this int num, int outroNum)
        {
            return num + outroNum;
        }

        public static int Subtracao(this int num, int outroNum)
        {
            return num - outroNum;
        }
    }

    class MetodosDeExtensao
    {
        public static void Executar()
        {
            int numero = 5;
            Console.WriteLine(numero.Soma(10));
        }
    }
}
