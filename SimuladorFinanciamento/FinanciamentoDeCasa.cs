using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SimuladorFinanciamento
{
    public class FinanciamentoDeCasa : Financiamento
    {
        private int _prazoPagamento = 0;
        private double _spread = 1.5;
        public FinanciamentoDeCasa(double montante, int prazo, double taxa, double spread) 
            : base(montante, prazo, taxa)
        {
            spread = _spread;       

        }
        // Propriedade que retorna e seta o valor prazo de pagamento relativo ao Financiamneto Casa
        public override int PrazoPagamento { get { return _prazoPagamento; } set {_prazoPagamento = value; }  }

        // Método que realiza o cálculo do Spread relativo ao Financiamento Casa
        public double CalcularSpread()
        {
            double spread =Math.Round(_spread/ 100 * Montante,2);
            return spread;
        }
        // Método que realiza o cálculo da taxa anual
        public override double CalcularTaxaAnual()
        {
            double prazoTaxa = _prazoPagamento / 12;
            double totalTaxa = Math.Round((TaxaAnual / 100 * Montante) * prazoTaxa, 2);
            return totalTaxa;

        }
        public override string ToString()
        {
            return $"{base.ToString()} {CalcularTaxaAnual()} {CalcularSpread()}";

        }
    }
}
