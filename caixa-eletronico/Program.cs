using System;

namespace caixa_eletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            //CAIXA-ELETRÔNICO
            
            Console.WriteLine("Qual o valor desejado para o saque:");
            int saque = Convert.ToInt32(Console.ReadLine());                   

            int nota100 = saque / 100;
            int resto100 = saque - (nota100 * 100);
            int nota50 = resto100 / 50;
            int resto50 = resto100 - (nota50 * 50);
            int nota20 = resto50 / 20;
            int resto20 = resto50 - (nota20 * 20);
            int nota10 = resto20 / 10;
            int resto10 = resto20 - (nota10 * 10);
            int nota5 = resto10 / 5;
            int resto5 = resto10 - (nota5 * 5);
            int nota2 = resto5 / 2;

            Console.WriteLine("Serão impressas:");
            Console.WriteLine(nota100 + " notas de R$100.");
            Console.WriteLine(nota50 + " notas de R$50.");
            Console.WriteLine(nota20 + " notas de R$20.");
            Console.WriteLine(nota10 + " notas de R$10.");
            Console.WriteLine(nota5 + " notas de R$5.");
            Console.WriteLine(nota2 + " notas de R$2.");

            //DÚVIDA 1: se o valor do input tem que ser inteiro, como criar um loop para restringir o usuário a digitar apenas números inteiros?
            //DÚVIDA 2: se o sistema sempre seguir a ordem de verificação de notas, eventualmente vai imprimir um valor aproximado. Como corrigir?
    }
}
