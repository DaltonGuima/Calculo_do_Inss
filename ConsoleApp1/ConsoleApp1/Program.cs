using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
                string continua = "S";
                double salario, aliquota, valINSS;
                double[] tbSalario = { 1045.00, 2089.60, 3134.40, 6101.06, 6101.06 };
                double[] tbAliquota = { 7.5, 9, 12, 14, 11.69 };
                Console.WriteLine("Calculo do valor do INSS");
                while (continua == "S")
                {
                    Console.WriteLine("Digite o valor do salario: ");
                    salario = Convert.ToDouble(Console.ReadLine());
                    aliquota = 0;
                    for (int i = 0; i < 5; i++)
                    {
                        if (salario <= tbSalario[i])
                        {
                            aliquota = tbAliquota[i];
                            i = 5;
                        }
                    }
                    if (aliquota == 0)
                        aliquota = tbAliquota[4];
                    valINSS = salario * aliquota / 100;
                    Console.WriteLine("O valor do INSS: " + String.Format("{0:00.00}", valINSS));
                    Console.WriteLine("Vai calcular novo salario, S ou N");
                    continua = Console.ReadLine();
                    continua = continua.ToUpper();
                }
                Console.WriteLine("Final do programa");
                Console.ReadLine();
        }
    }
}
