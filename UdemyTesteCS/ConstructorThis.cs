using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyTesteCS
{
    public class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
    }

    public class Cachorro : Animal
    {
        public double Altura { get; set; }

        public Cachorro(string nome) : base(nome)
        {
            Console.WriteLine($"Cachorro {nome} inicializado");
        }

        public Cachorro(string nome, double altura) : this(nome)
        {
            Altura = altura;
        }
    }

    class ConstructorThis
    {
    }
}
