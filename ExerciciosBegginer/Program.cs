// # 🧩 Desafios - Nível Iniciante 1



namespace ExerciciosBegginer
{
    public class Program
    {
        public static void Main(string[] Args)
        {
            // ### 1. Encontre o maior e o menor número de uma lista
            // **Descrição:**
            // Dada uma lista de números inteiros, encontre e retorne o maior e o menor número da lista.
            // **Entrada:**
            // Uma lista de números inteiros.
            // Exemplo:
            //[3,7,1,9,4]

            List<int> numeros = new List<int>() {3,7,1,9,4};

            int[] numerosRetorno = MaiorMenor(numeros);

            foreach(var numero in numerosRetorno)
            {
                Console.WriteLine(numero);
            }

            // ### 2. Calcular a média de uma lista de números
            // **Descrição:**
            // Receba uma lista de números e retorne a média aritmética.
            // **Entrada:**
            //[10,20,30]
            Console.WriteLine(MediaNumeros([10,20,30]));

            // ### 3. Verifique se um número é par ou ímpar
            // **Descrição:**
            // Dado um número inteiro, determine se ele é par ou ímpar.
            // **Entrada:**
            // 7
            Console.WriteLine(ImparPar(7));

            // ## 4. Conte quantos números pares existem em uma lista
            // **Descrição:**
            // Receba uma lista de inteiros e retorne quantos números pares existem nela.
            // **Entrada:**
            // [1, 2, 3, 4, 5, 6]
            int pares = NumerosPares([1,2,3,4,5,6]);
            Console.WriteLine($"Quantidade de pares: {pares}");

            // ### 5. Inverta uma string

            // **Descrição:**

            // Dada uma string, retorne ela invertida.

            // **Entrada:**
            //"programar"

            //Saída esperada:
            //"ramargorp"

            string palavra = "programar";
            Console.WriteLine(PalavraReversa(palavra));

            //### 6. Verifique se uma palavra é um palíndromo
            // **Descrição:**
            // Um palíndromo é uma palavra que se lê igual de frente pra trás e de trás pra frente.
            //  Verifique se uma string é um palíndromo.
            // **Entrada:**
            //"radar"
            //Saida Esperada:
            // É palindromo

            string palavra3 = "radar";
            Console.WriteLine(EhPalindromo(palavra3));

            //### 7. Conte quantas vogais existem em uma palavra
            //**Descrição:**
            // Dada uma string, conte quantas vogais existem nela (a, e, i, o, u).
            //**Entrada:**
            //"javascript"
            //**Saida:**
            // Número de vogais: 3

            int vogais = Vogais("javascript");
            Console.WriteLine($"Número de vogais: {vogais} ");

            //### 8. Some todos os números de 1 até N
            //**Descrição:**
            //Receba um número `N` e retorne a soma de todos os números de 1 até `N`.
            //**Entrada:**
            // 5
            // Nesse caso: 1+2+3+4+5
            //**Saída esperada:**
            // Soma: 15

            int soma = Soma(5);
            Console.WriteLine($"Soma: {soma}");

            //### 9. Retorne apenas os números positivos de uma lista

            //**Descrição:**

            //Dada uma lista de números inteiros, retorne uma nova lista apenas com os números positivos.

            //**Entrada:**
            //[-2, 5, 0, -8, 7]

            List<int> num = new List<int> () {-2, 5, 0, -8, 7};

            var positivos = ListaNumPositivo(num);

            foreach(var n in positivos)
            {
                Console.Write($"{n}," );
            }
            Console.WriteLine();
            // ### 10. Converta uma temperatura de Celsius para Fahrenheit
            //**Descrição:**
            //Dado um valor em Celsius, converta e retorne o valor equivalente em Fahrenheit.
            //Fórmula: `F = C × 1.8 + 32`
            //**Entrada:**
            // 0
            // Saída esperada:
            // 32
            Console.WriteLine(ConvertCelsToFaren(0));
        }

        public static int[] MaiorMenor(List<int> numeros)
        {
            int maior = numeros[0];
            int menor = numeros[0];

            for(int i = 0; i < numeros.Count; i++)
            {
                if(numeros[i] > maior)
                {
                    maior = numeros[i];
                }
                else if(numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            int[] MaiorMenor = new int[2];

            MaiorMenor[0] = menor;
            MaiorMenor[1] = maior;

            return MaiorMenor;
        }
        public static int MediaNumeros(int[] numeros)
        {
            int soma = 0;

            for(int i =0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

            int media = soma/numeros.Length;

            return media;
        }
        public static string ImparPar(int numero)
        {
            return numero % 2 == 0 ? "par" : "impar"; 
        }
        public static int NumerosPares(int[] numeros)
        {
            int totalPares = 0;

            for(int i = 0; i < numeros.Length; i++)
            {
                if(numeros[i] % 2 == 0)
                {
                    totalPares++;
                }
            }

            return totalPares;
        }
        public static string PalavraReversa(string palavra)
        {
            string palavraReversa = "";


            for(int i = palavra.Count() -1; i >= 0; i--)
            {
                palavraReversa += palavra[i];
            }

            return palavraReversa;
        }

        public static string EhPalindromo(string palavra)
        {
            string palavraAlcontrario = "";
            bool EhPalindromo = true;
            int j = 0;

            for(int i =palavra.Count()-1; i >= 0; i--)
            {
                palavraAlcontrario += palavra[i];

                if(palavra[i] != palavraAlcontrario[j])
                {
                    EhPalindromo = false;
                    break;
                }

                j++;
            }

            if(EhPalindromo == true)
            {
                return "É palindromo";
            }
            else
            {
                return "não é palindromo";
            }

        }

        public static int Vogais(string palavra)
        {
            List<char> vogais = new List<char>(){'a', 'e', 'i', 'o', 'u'};
            int qtVogais = 0;
            for(int i = 0; i <= palavra.Length -1; i++)
            {
                if (vogais.Contains(palavra[i]))
                {
                    qtVogais++;
                }
            }

            return qtVogais;
        }

        public static int Soma(int num)
        {
            int max = 1;
            int total = 0;
            while(max <= num)
            {
                total+= max;
                max++;
            }

            return total;
        }

        public static List<int> ListaNumPositivo(List<int> numeros)
        {
            List<int> numerosPositivos = new List<int>();
            foreach(var num in numeros)
            {
                if(num > 0)
                {
                    numerosPositivos.Add(num);
                }
            }

            return numerosPositivos;
        }

        public static double ConvertCelsToFaren(int num)
        {
            double fahrenheit = (num * 1.8) +32;
            
            return fahrenheit; 
        }

    }
}