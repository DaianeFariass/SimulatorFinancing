using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFinanciamento
{
    //Classe Abstrata (Mãe)
    public abstract class Financiamento
    {
        #region Atributos
        private double _montanteAFinanciar;

        private int _prazoPagamento;

        private double _taxaAnual;

        #endregion

        #region Propriedades
        public double Montante
        {
            get
            {
                return _montanteAFinanciar;
            }
            set
            {
                _montanteAFinanciar = value;
            }

        }
        // Propriedade Abstrata Prazo de Pagamento
        public abstract int PrazoPagamento { get; set; }
        public double TaxaAnual
        {
            get
            {
                return _taxaAnual;
            }
            set
            {
                _taxaAnual = value;
            }
        }
        #endregion
        #region Métodos
        public Financiamento(double montante, int prazo, double taxa)
        {
            Montante = montante;
            PrazoPagamento = prazo;
            TaxaAnual = taxa;

        }
        // Método Abstrato sem corpo CalcularTaxa que será utilizado nas subclasses
        public abstract double CalcularTaxaAnual();
        public override string ToString()
        {
            return $"{Montante}{PrazoPagamento}{TaxaAnual}";
        }
        #endregion


    }
}
