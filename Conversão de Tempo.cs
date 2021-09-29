/*
******************************************Desafio
Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja,
e informe-o expresso no formato horas:minutos:segundos.

******************************************Entrada
O arquivo de entrada contém um valor inteiro N.

******************************************Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.
*/


using System;

    class MinhaClasse {
        static void Main(string[] args) {
            var timeInSeconds = int.Parse(Console.ReadLine());

       //continue a solucao
            var hours = timeInSeconds/3600;//Aqui iremos converter os segundos informado em horas 
            //var timeInSeconds = int.Parse(Console.ReadLine());
            var minutes = (timeInSeconds % 3600) / 60; //Aqui iremos converter os segundos informado em minuto
            //var seconds = N   ;
            var seconds = (timeInSeconds % 3600) % 60;//Aqui no caso o resto será 0.

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }