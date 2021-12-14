<<<<<<< HEAD
/*
******************************************Desafio
Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

******************************************Entrada
A entrada contém valores inteiros.

******************************************Saída
A saída deve conter uma das mensagens conforme descrito acima.
*/


using System;

 class minhaClasse {
        static void Main(string[] args) {
            //continue a solucao com a insercao da variavel corretamente

            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);//Aqui foi reservado o primeiro espaço e valor da matriz
            int B = int.Parse(valores[1]);//Aqui foi reservado o segundo espaço e valor da matriz

            if (A % B == 0 || B % A == 0)
            //iremos comparar a divição de a/b e b/a se nos dois casos o resto for 0 então são Multiplos.
            { 
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
=======
/*
******************************************Desafio
Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

******************************************Entrada
A entrada contém valores inteiros.

******************************************Saída
A saída deve conter uma das mensagens conforme descrito acima.
*/


using System;

 class minhaClasse {
        static void Main(string[] args) {
            //continue a solucao com a insercao da variavel corretamente

            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);//Aqui foi reservado o primeiro espaço e valor da matriz
            int B = int.Parse(valores[1]);//Aqui foi reservado o segundo espaço e valor da matriz

            if (A % B == 0 || B % A == 0)
            //iremos comparar a divição de a/b e b/a se nos dois casos o resto for 0 então são Multiplos.
            { 
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
>>>>>>> c41382c9fe84566e9b40ae23221b290e626ee115
    }