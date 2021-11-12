using System;

namespace AppLogicaExerciciosPropostos_07
{
    /// <summary>
    /// Exercícios sobre Estrutura Condicional (if-else)
    /// Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
    /// de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
    /// ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
    /// Se o ponto estiver na origem, escreva a mensagem “Origem”.
    /// Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.
    /// </summary>
    class Program
    {
        public static void verificaQustrante(double x, double y) 
        {
            if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0.0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os valores de x e y para determinar a posição do quadrante: ");
            string[] vet = Console.ReadLine().Split(" ");
            double x = double.Parse(vet[0]);
            double y = double.Parse(vet[1]);
            verificaQustrante(x, y);
            Console.ReadLine();
        }
    }
}
