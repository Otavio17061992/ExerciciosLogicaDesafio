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
    }
}