using System;

namespace AppPosicaoQuadrantePlano
{
    /// <summary>
    /// Exercicios livres.
    /// Programa para calcular a posição em um quadrante dado os valores de X e Y.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y;
            string posicao;

            Console.WriteLine("Informe o valor de X e Y para receber a posição do quadrante: ");
            string[] vet = Console.ReadLine().Split(" ");
            
            X = double.Parse(vet[0]);
            Y = double.Parse(vet[1]);
            
            Quadrante quadrante = new Quadrante(X,Y);
            posicao = quadrante.VerificaQuatrante();

            Console.WriteLine("A posição está no {0}", posicao);
            Console.ReadLine();
        }
    }
}
