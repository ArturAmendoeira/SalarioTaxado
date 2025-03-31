using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
namespace SalarioTaxadoMaster
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Jhony trabalha nas casas Bahia, e quer ajuda para saber quanto irá receber no mês, e você irá o ajudar!");
            Console.WriteLine("Diga qual o valor do salário mensal de Jhony: ");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Diga quantas horas extras Jhony fez este mês: ");
            int horas = int.Parse(Console.ReadLine());
            Salario salario = new Salario(valor, horas);
            Console.WriteLine("Valores de Jhony: ");
            Console.WriteLine("Valor das horas extras =  " + Math.Round(salario.CalcularExtra(), 2));
            Console.WriteLine("Valor descontado do INSS =  " + Math.Round(salario.INSS(), 2));
            Console.WriteLine("Valor liquido total recebido =  " + Math.Round(salario.CalcularLiquido(), 2));
            Console.WriteLine("Jhony está triste por receber tão pouco");
        }
    }
}

