using System;
using System.Globalization;
using System.Numerics;
using System.Linq;
using POO_MediaProdutos;

namespace POO_MediaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o número de produtos a serem cadastrados: ");
            //Criando e recebendo a variável de entrada. Usar ponto, ao invés de vírgula ao informar.
            int n = int.Parse(Console.ReadLine());
            //Criando o vetor com o número da variável de entrada (n)
            Produto[] vect = new Produto[n];

            //Criação do laço para criar um vetor conforme o tamanho indicado pelo usuário
            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe o nome do produto " + (i + 1) + " :");   //(i+1) informa a sequência dos produtos
                string name = Console.ReadLine();
                Console.Write("Informe o preço do produto " + (i + 1) + " :");   //(i+1) informa a sequência dos produtos
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                //Após a inserção dos dados, é criado um vetor
                vect[i] = new Produto { Name=name, Price = price };
            }

            //Variável SOMA
            double soma = 0.0;

            //Laço para percorrer o vetor
            for (int i = 0; i < n; i++)
            {
                soma += vect[i].Price;
            }
            Console.WriteLine("A soma do preço dos produtos informados é: " + (soma).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("A média do preço dos produtos informados é: " + (soma / n).ToString("F2", CultureInfo.InvariantCulture));
            //"F2" Exibe o resultado com 2 casas após a vírgula
        }
    }
}
