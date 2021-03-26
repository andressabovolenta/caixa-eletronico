using System;

namespace caixa_eletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor desejado para saque:");
            double saque = Convert.ToDouble(Console.ReadLine());

            double debito = saque;

            int nota100 = 0;
            int nota50 = 0;
            int nota20 = 0;
            int nota10 = 0;
            int nota5 = 0;
            int nota2 = 0;
            int nota1 = 0;

            while (debito > 0)
            {
                if (debito >= 100)
                {
                    debito = debito - 100;
                    nota100 = nota100 + 1;
                }
                else
                {
                    if (debito >= 50)
                    {
                        debito = debito - 50;
                        nota50 = nota50 + 1;
                    }
                    else
                    {
                        if (debito >= 20)
                        {
                            debito = debito - 20;
                            nota20 = nota20 + 1;
                        }
                        else
                        {
                            if (debito >= 10)
                            {
                                debito = debito - 10;
                                nota10 = nota10 + 1;
                            }
                            else
                            {
                                if (debito >= 5)
                                {
                                    debito = debito - 5;
                                    nota5 = nota5 + 1;
                                }
                                else
                                {
                                    if (debito >= 2)
                                    {
                                        debito = debito - 2;
                                        nota2 = nota2 + 1;
                                    }
                                    else
                                    {
                                        if (debito >= 1)
                                        {
                                            debito = debito - 1;
                                            nota1 = nota1 + 1;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Erro!");
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (debito == 0)
            {
                Console.WriteLine("Serão impressas:");
                Console.WriteLine(nota100 + " notas de R$100.");
                Console.WriteLine(nota50 + " notas de R$50.");
                Console.WriteLine(nota20 + " notas de R$20.");
                Console.WriteLine(nota10 + " notas de R$10.");
                Console.WriteLine(nota5 + " notas de R$5.");
                Console.WriteLine(nota2 + " notas de R$2.");
                Console.WriteLine(nota1 + " notas de R$1.");
            }

        }
    }
}
