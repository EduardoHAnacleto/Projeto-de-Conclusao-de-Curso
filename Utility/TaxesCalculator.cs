using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoEduardoAnacletoWindowsForm1.Utility
{
    public class TaxesCalculator
    {
        public double WorkTax(double x, double y)
        {
            return x * y;
        }

        public double valorFrete { get; private set; } = 0;

        public double FreteCalc (double valorTotal, List<double> valorProds) //Calcula Valor total do Frete
        {
            //Valor do Produto / Soma de todos produtos) x ValorFrete = valorDoRateio
            double valorRateio = 0;
            double valorFreteCalc = valorFrete;
            foreach (var item in valorProds)
            {
                valorRateio =+ (item / valorTotal) * valorFreteCalc; 
            }

            return valorRateio;
        }
    }
}
