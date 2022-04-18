using static System.Convert;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

public class Program
{
    public static void Main()
    {



        List<Notas> lstNotas = new List<Notas>()
        {
            new Notas { Nota = 3 },
            new Notas { Nota = 4 },
            new Notas { Nota = 8 },
            new Notas { Nota = 1 },
            new Notas { Nota = 4 },
            new Notas { Nota = 10 },
            new Notas { Nota = 17 },
            new Notas { Nota = 13 },
            new Notas { Nota = 2 },
            new Notas { Nota = 2 },
            new Notas { Nota = 17 },
            new Notas { Nota = 56 },
            new Notas { Nota = 18 },
            new Notas { Nota = 19 },
            new Notas { Nota = 20 },
            new Notas { Nota = 22 },
            new Notas { Nota = 29 },




        };
        //ordem dos numeros 
        Console.WriteLine("A ordem da nota dos alunos:");
        foreach (var Notas in lstNotas.OrderBy(x => ToInt32(x.Nota))) WriteLine(Notas.Nota);

        //Numeros primos (FINALMENTEEEEE) 
         static bool EhPrimo(int numero)
        {
            bool primo = false;
            int divisores = 0;

            for (int i = 1; i <= numero; i++)
            {
                if (numero == 0)// só para não dar erro de divisão por 0.
                    continue;
                if (numero % i == 0)
                    divisores++;
            }
            if (divisores == 2)
                primo = true;
            else
                primo = false;

            return primo;
        }
        Console.WriteLine("\nNotas de numero primo:");

        for (int i = 0; i < lstNotas.Count; i++)
        {
            if (EhPrimo(lstNotas[i].Nota) == true)
            {
                Console.WriteLine(lstNotas[i].Nota + " é primo.");
            }
        }


        //Maior nota
        var Numeros = new List<int> { 3, 4, 8, 1, 4, 10, 17, 13, 2, 17, 56, 18, 19, 20, 22, 29 };
        int maiorValor = Numeros.Max();
        //Maior nota:
        Console.WriteLine("\nA maior nota é: " + maiorValor);

       

       

        Console.ReadLine();

    }
    public class Notas
    {
        public int Nota;
    }

}
