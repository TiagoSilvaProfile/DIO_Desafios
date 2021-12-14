
/*
******************************************Desafio
Leia um número inteiro que representa um código de DDD para discagem interurbana. Em seguida, informe à qual cidade o DDD pertence, considerando a tabela abaixo:
Se a entrada for qualquer outro DDD que não esteja presente na tabela acima, o programa deverá informar:
DDD nao cadastrado

******************************************Entrada
A entrada consiste de um único valor inteiro.

******************************************Saída
Imprima o nome da cidade correspondente ao DDD existente na entrada. Imprima DDD nao cadastrado caso não existir DDD correspondente ao número digitado.

*/





using System; 

class Desafio {

        public static void Main()
        {
            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);

              //continue a solucao
            if (a ≥ b + c)
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (a = b + c)
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (a > b + c)
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (a < b + c)
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (a = b = c)
                Console.WriteLine("TRIANGULO EQUILATERO");
            if (a > b = c)
                Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();
        }
}