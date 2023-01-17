using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Classes e objetos POO
            //MinhaClasse mClasse = new MinhaClasse();
            //MinhaClasse m2 = null;
            //OutraClasse m3 = null;
            #endregion

            #region Atributos das classes
            Pesssoa p1 = new Pesssoa();
            p1.nome = "Jardel";
            p1.sobrenome = "Mandel";
            p1.anoNascimento = 1992;

            Pesssoa p2 = new Pesssoa()
            {
                nome = "Camila",
                sobrenome = "Rodrigues",
                anoNascimento = 1986
            };
            Console.WriteLine("Pessoa 1: " + p1.nome);
            Console.WriteLine("Pessoa 1: " + p1.sobrenome);
            Console.WriteLine("Pessoa 1: " + p1.anoNascimento);
            p1.Cumprimentar();

            Console.WriteLine("Pessoa 2: " + p2.nome);
            Console.WriteLine("Pessoa 2: " + p2.sobrenome);
            Console.WriteLine("Pessoa 2: " + p2.anoNascimento);
            p2.Cumprimentar();

            Console.ReadKey();
            #endregion


        }
    }

    class MinhaClasse
    {

    }
}
