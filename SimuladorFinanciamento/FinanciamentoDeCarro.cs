using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFinanciamento
{
    public class FinanciamentoDeCarro : Financiamento
    {
        private double _comissaoAbertura = 0.0001;
        private double _valorResidual = 0.01;
        private int _prazodePagamento = 0;

        public FinanciamentoDeCarro(double montante, int prazo, double taxa, double comissaoAbertura, double valorResidual)
            : base(montante, prazo, taxa)
        {

            {
                comissaoAbertura = _comissaoAbertura;
                valorResidual = _valorResidual;

            }
        }
        // Metódo que realiza o cálculo de Comissão de Abertura do Financiamento Carro
        public double CalcularComissaoAbertura()
        {

            double comissaoAbertura = Math.Round(Montante * _comissaoAbertura, 2);
            return comissaoAbertura;
        }
       
        // Propriedade que realizada a validadação do prazo de pagamento do Financiamento Carro
        public override int PrazoPagamento
        {
            get
            {
                return _prazodePagamento;
            }
            set
            {
                if (value > 60) _prazodePagamento = 60;
                else _prazodePagamento = value;
            }

        }
        // Método que realiza o Cálculo da Taxa Anual
        public override double CalcularTaxaAnual()
        {
            double prazoTaxa = _prazodePagamento / 12;
            double totalTaxa = Math.Round(( TaxaAnual / 100 * Montante) * prazoTaxa, 2);
            return totalTaxa;

        }
        public override string ToString()
        {
            return $"{base.ToString()} {CalcularTaxaAnual()} {CalcularComissaoAbertura()}";
            
        }

    }
}
