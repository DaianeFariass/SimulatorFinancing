using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFinanciamento
{
    public class OutrosFinanciamentos : Financiamento
    {
        private int _prazoPagamento = 0;
        double _comissaoAbertura = 0.01;
        double _taxaAmortizacao = 0.0005;

        public override int PrazoPagamento { get { return _prazoPagamento; } set { _prazoPagamento = value; } }

        public OutrosFinanciamentos(double montante, int prazo, double taxa, double comissaoAbertura, double taxaAmortizacao)
            : base(montante, prazo, taxa)
        {
            comissaoAbertura = _comissaoAbertura;
            taxaAmortizacao = _taxaAmortizacao;


        }
        // Médodo que realiza o cálculo da Comissão de Abertura
        public double CalcularComissaoAberturaOutros()
        {
            double comissaoAbertura = Math.Round(Montante * _comissaoAbertura, 2);
            return comissaoAbertura;
        }
        // Método que realiza o cálculo da Amortização Antecipada
        public double CalcularAmortizacao()
        {
            double taxaAmortizacao = Montante * _taxaAmortizacao;
            return taxaAmortizacao;
        }
        // Método que realiza o cálculo da Taxa Anual Bruta
        public override double CalcularTaxaAnual()
        {
            double prazoTaxa = _prazoPagamento / 12;
            double totalTaxa = Math.Round((TaxaAnual / 100 * Montante) * prazoTaxa, 2);
            return totalTaxa;

        }
        public override string ToString()
        {
            return $"{base.ToString()} {CalcularTaxaAnual()} {CalcularComissaoAberturaOutros} {CalcularAmortizacao}";

        }
    }
}
