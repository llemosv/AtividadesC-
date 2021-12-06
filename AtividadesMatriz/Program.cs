using System;
using System.Globalization;


namespace AtividadesMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            //Exercicio04();
            //Exercicio05();
            //Exercicio06();
            //Exercicio07();
            //Exercicio08();
            //Exercicio09();
            //Exercicio10();
            Exercicio11();
        }
        static void imprimirMatriz(double[,] matriz, int linhas, int colunas)
        {
            for (int i = 0; i <= (linhas - 1); i++)
            {
                for (int j = 0; j <= (colunas - 1); j++)
                {
                    Console.Write($"{ matriz[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void preencherMatriz(double[,] matriz, int linhas, int colunas)
        {
            for (int i = 0; i <= (linhas - 1); i++)
            {
                for (int j = 0; j <= (colunas - 1); j++)
                {
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void produtoDuasMatriz(double[,] matrizA, double [,] matrizB, double [,] produto, int linhas, int colunas)
        {
            for (int i = 0; i <= (linhas - 1); i++)
            {
                for (int j = 0; j <= (colunas - 1); j++)
                {
                    produto[i, j] = matrizA[i, j] * matrizB[i, j];
                }
            }
        }
        static void transformarMatrizTransposta(double[,] matriz, double[,] transposta, int linhas, int colunas)
        {
            for (int i = 0; i <= (linhas - 1); i++)
            {
                for (int j = 0; j <= (colunas - 1); j++)
                {
                    transposta[i, j] = matriz[j, i];
                }
            }
        }
        static void conferirParOuImpar(int numero)
        {
            if (numero % 2 == 0) Console.WriteLine("O número é par.");
            else Console.WriteLine("O número é ímpar.");
        }
        static int calcularFatorial(int numero)
        {
            if (numero == 0) return 1;
            else return  numero * calcularFatorial(numero - 1);
        }
        static double distanciaEntreDoisPontos(int x1, int x2, int y1, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static double calculoEx8(int numero)
        {
            double S = 0;
            for (double i = 1; i <= numero; i++)
            {
                S = S + (1 / i);
            }
            return S;
        }
        static int menorValorArray(int[] array, int maxValor)
        {
            for (int i = 0; i < 4; i++)
            {
                if (array[i] < maxValor)
                    maxValor = array[i];
            }
            return maxValor;
        }
        static int maiorValorArray(int[] array, int minValor)
        {
            for (int i = 0; i < 4; i++)
            {
                if (array[i] > minValor)
                    minValor = array[i];
            }
            return minValor;
        }
        static double elementosParMatriz(double [,] matriz, int linhas, int colunas, double[] elementosPar)
        {
            elementosPar = 0;
            for (int i = 0; i <= (linhas - 1); i++)
            {
                for (int j = 0; j <= (colunas - 1); j++)
                {
                    if (matriz[i, j] % 2 == 0) return elementosPar[i] += matriz[i, j];
                }
            }
            return;
        }
        static void Exercicio01()
        {
            //Preencha com 1 a diagonal principal da matriz de uma matriz 5x5
            double[,] matriz1 = new double[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j) matriz1[i, j] = 1;
                    else matriz1[i, j] = 0;
                }
            }
            imprimirMatriz(matriz1, 5, 5);
        }//CONCLUIDO
        static void Exercicio02()
        {
            //mostre na tela o produto das duas matrizes 3X3
            double[,] matrizA = new double [3, 3];
            double[,] matrizB = new double [3, 3];
            double[,] produto = new double [3, 3];
            //preencher matrizA
            Console.WriteLine("Digite os valores da matriz A: ");
            preencherMatriz(matrizA, 3, 3);

            Console.WriteLine("Matriz A: ");
            imprimirMatriz(matrizA, 3, 3);
            //preencher matrizB
            Console.WriteLine("Digite os valores da matriz B: ");
            preencherMatriz(matrizB, 3, 3);

            Console.WriteLine("Matriz B: ");
            imprimirMatriz(matrizB, 3, 3);

            produtoDuasMatriz(matrizA, matrizB, produto, 3,3);
            Console.WriteLine("Produto");
            imprimirMatriz(produto, 3, 3);

        }//A CONCLUIR
        static void Exercicio03()
        {
            // receber uma matriz 4x3 e imprimir a transposta
            double[,] matriz = new double[4, 3];
            double[,] transposta = new double[3, 4];

            Console.WriteLine("Digite a matriz 4x3:");
            preencherMatriz(matriz, 4, 3);

            Console.WriteLine("Matriz informada:");
            imprimirMatriz(matriz, 4, 3);

            Console.WriteLine("Matriz transposta:");
            transformarMatrizTransposta(matriz, transposta, 3, 4);
            imprimirMatriz(transposta, 3, 4);
        }//CONCLUIDO
        static void Exercicio04()
        {
            //receber uma matriz 3x3 e um valor k = inteiro, depois multiplique os elementos da matriz por k 
            double[,] matriz = new double[3, 3];
            double[,] novaMatriz = new double[3, 3];
            int k;

            Console.Write("Digite o valor de K: ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira a matriz: ");
            preencherMatriz(matriz, 3, 3);

            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    novaMatriz[i, j] = matriz[i, j] * k;
                }
            }
            Console.WriteLine("Matriz inserida: ");
            imprimirMatriz(matriz, 3, 3);

            Console.WriteLine("Nova matriz:");
            imprimirMatriz(novaMatriz, 3, 3);
        }//CONCLUIDO
        static void Exercicio05()
        {
            //criar um metodo que confere se um numero é par ou impar
            int numero;

            Console.WriteLine("Digite um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            conferirParOuImpar(numero);
        }//CONCLUIDO
        static void Exercicio06()
        {
            //função para calcular o fatorial de um dado inteiro
            int numero, fatorial;
            Console.WriteLine("Digite um número inteiro que deseja saber o fatorial: ");
            numero = Convert.ToInt32(Console.ReadLine());

            fatorial = calcularFatorial(numero);
            Console.Write($"Fatorial = {fatorial}");
        }//CONCLUIDO
        static void Exercicio07()
        {
            //faça uma função para calcular a distancia entre dois pontos, retorna double
            int x1, y1, x2, y2;
            double distancia;
            Console.WriteLine("Expressão utilizada para realizar o calculo: √ (x2 - x1)² + (y2 - y1)²");

            Console.Write("Digite o valor de x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            distancia = distanciaEntreDoisPontos(x1, x2, y1, y2);
            Console.WriteLine($"A distância entre os pontos é: {distancia}");
        }//CONCLUIDO
        static void Exercicio08()
        {
            //criar um metodo e que retorna o valor de S
            int numero;
            Console.Write("Digite um número inteiro: ");
            numero = Convert.ToInt32(Console.ReadLine());

            double resultado = calculoEx8(numero);
            Console.WriteLine($"O resultado de S é: {resultado}");
        }//CONCLUIDO
        static void Exercicio09()
        {
            //criar uma função que recebe um array de inteiros e retorne o menor valor
            int[] vetor = new int[5] {31, 69, 25, 190, 53 };
            int menorValor, maxValor;
            maxValor = 1000;
            menorValor = menorValorArray(vetor,maxValor);
            Console.WriteLine($"O menor valor do array é: {menorValor}");

        }//CONCLUIDO
        static void Exercicio10()
        {
            //função para retornar o maior valor do array array e a soma do maior e menor valor dele
            int[] vetor = new int[5] { 111, 629, 295, 523, 833 };
            int menorValor,maiorValor, minValor, maxValor, soma;
            minValor = -1000;
            maxValor = 1000;
            menorValor = menorValorArray(vetor, maxValor);
            Console.WriteLine($"O menor valor do array é: {menorValor}");
            maiorValor = maiorValorArray(vetor, minValor);
            Console.WriteLine($"O maior valor do array é: {maiorValor}");
            soma = menorValor + maiorValor;
            Console.WriteLine($"A soma do menor valor e do maior é: {soma}");
        }//CONCLUIDO
        static void Exercicio11()
        {
            // criar função que recebe uma matriz e retornar os elementos pares
            double[,] matriz = new double[3,3];
            double[] elementosPar = new double[matriz.Length];

            Console.WriteLine("Insira os valores da matriz 3x3: ");
            preencherMatriz(matriz, 3, 3);

            double resultado = elementosParMatriz(matriz, 3, 3, elementosPar);
            Console.WriteLine(resultado);
        }
    } 

}