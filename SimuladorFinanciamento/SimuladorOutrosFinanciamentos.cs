using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorFinanciamento
{
    public partial class SimuladorOutrosFinanciamentos : Form
    {
        OutrosFinanciamentos _financiamentos;
        double comissao;
        double amortizacao;
        public SimuladorOutrosFinanciamentos(double montante, int prazo, double taxa)
        {
            InitializeComponent();
            lbl_Montante.Text = montante.ToString();
            lbl_Prazo.Text = prazo.ToString();
            lbl_Taxa.Text = taxa.ToString();

            _financiamentos = new OutrosFinanciamentos(montante, prazo, taxa, comissao, amortizacao );
        }
        // Método que realiza a soma total do Financiamento
        private double SomarFinanciamento()
        {
            double soma = (_financiamentos.Montante + _financiamentos.CalcularTaxaAnual() + _financiamentos.CalcularComissaoAberturaOutros()) - _financiamentos.CalcularAmortizacao();
            return soma;
        }
        // Método que realiza o Cálculo das parcela mensais
        private double CalcularParcelas()
        {
            double parcelas = Math.Round(SomarFinanciamento() / _financiamentos.PrazoPagamento, 2);

            return parcelas;
        }

      
        private void btn_Simular_Click(object sender, EventArgs e)
        {
            lbl_Calculos.Text = $"Taxa Anual Bruta = {_financiamentos.CalcularTaxaAnual().ToString()}€\n" +
                $"Comissão de Abertura = {_financiamentos.CalcularComissaoAberturaOutros().ToString()}€\n" +
                $"Amortização = {_financiamentos.CalcularAmortizacao().ToString()}€\n" +
                $"Total Financiamento = {SomarFinanciamento().ToString()}€\n" +
                $"Total Parcela = {CalcularParcelas().ToString()}€\n";

        }



    }
}
