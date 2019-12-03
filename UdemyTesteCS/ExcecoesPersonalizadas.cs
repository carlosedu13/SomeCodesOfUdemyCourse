using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTesteCS
{
    public class NegativeException : Exception
    {
        public NegativeException() { }
        public NegativeException(string message) : base(message) { }
        public NegativeException(string message, Exception innerException) : base(message, innerException) { }
    }

    public class OddException : Exception
    {
        public OddException(string message) : base(message) { }
    }

    class ExcecoesPersonalizadas
    {
        public static int PositiveEven()
        {
            Random random = new Random();

            int valor = random.Next(-30, 30);

            if (valor < 0)
                throw new NegativeException("Número negativo... :(");
            if (valor % 2 == 1)
                throw new OddException("Número impar... :(");

            return valor;
        }

        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositiveEven());
            }
            catch(NegativeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(OddException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
