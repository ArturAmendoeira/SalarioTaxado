using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioTaxadoMaster
{
    class Salario
    {
        private double valor;
        private int horasExtras;
        public Salario(double grana, int hours)
        {
            valor = grana;
            horasExtras = hours;
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public int HorasExtras
        {
            get { return horasExtras; }
            set { horasExtras = value; }
        }
        public double CalcularExtra()
        {
            return ((valor / 176) * HorasExtras) * 1.5;
        }
        public double CalcularBruto()
        {
            return valor + CalcularExtra();
        }
        public double INSS()
        {
            double taxa = CalcularBruto() / 10;
            if (taxa <= 150)
            {
                return taxa;
            }
            else
            {
                return 150.00;
            }
        }
        public double CalcularLiquido()
        {
            return (CalcularBruto() - INSS());
        }

    }
}



