using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorFinanciamento
{
    public partial class SimuladorCarro : Form
    {
        FinanciamentoDeCarro _financiamento;
        double comissaoAbertura = 0;
        double valorResidual = 0;
        
        public SimuladorCarro(double montante, int prazo,double taxa)
        {
            InitializeComponent();
            lbl_Montante.Text = montante.ToString();
            lbl_Prazo.Text = prazo.ToString();
            lbl_Taxa.Text = taxa.ToString();

            _financiamento = new FinanciamentoDeCarro(montante, prazo, taxa, comissaoAbertura, valorResidual);

        }
        // Leitura e Validação da caixa de texto valorCarro podendo aceitar somente números
        private void ValorCarro(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)// Evento que faz o cast para Char e seta a tecla Enter como chave para trocar de uma caixa de texto para outra
            {
                if (txt_valorCarro.Text.Length == 0) // Verifica se preencheu a caixa de texto
                {
                    MessageBox.Show("Obrigatório Preencher todos os campos!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!Regex.IsMatch(txt_valorCarro.Text, @"[0-9]"))
                {

                    MessageBox.Show("Entrada Inválida...");
                    txt_valorCarro.ResetText();
                    txt_valorCarro.Focus();
                    return;

                }
                double valorCarro; ;
                if (!double.TryParse(txt_valorCarro.Text, out valorCarro) || valorCarro < 500) // Validação do valor carro não podendo ser menor que o valor minímo de financiamento
                {
                    MessageBox.Show("Valor minímo de financiamento é 500€");
                    txt_valorCarro.ResetText();
                    txt_valorCarro.Focus();
                    return;

                }
                txt_anoCarro.Enabled = true;
                txt_anoCarro.Focus();
                e.Handled = true;

            }
        }
        // Leitura e Validação da caixa de texto anoCarro podendo aceitar somente números
        private void AnoCarro(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_anoCarro.Text.Length == 0)
                {
                    MessageBox.Show("Obrigatório Preencher todos os campos!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!Regex.IsMatch(txt_anoCarro.Text, @"[0-9]"))
                {

                    MessageBox.Show("Entrada Inválida...");
                    txt_anoCarro.ResetText();
                    txt_anoCarro.Focus();
                    return;

                }
                int ano;
                if (!int.TryParse(txt_anoCarro.Text, out ano) || ano > 2023) // Validação do ano não podendo inserir maior que 2023
                {
                    MessageBox.Show("Entrada Inválida...");
                    txt_anoCarro.ResetText();
                    txt_anoCarro.Focus();
                    return;

                }
                txt_taxaDepreciacao.Enabled = true;
                txt_taxaDepreciacao.Focus();
                e.Handled = true;

            }

        }
        // Leitura e Validação da caixa de texto taxaDepreciacao podendo aceitar somente números
        private void TaxaDepreciacao(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_taxaDepreciacao.Text.Length == 0)
                {
                    MessageBox.Show("Obrigatório Preencher todos os campos!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!Regex.IsMatch(txt_taxaDepreciacao.Text, @"[0-9]"))
                {

                    MessageBox.Show("Entrada Inválida...");
                    txt_taxaDepreciacao.ResetText();
                    txt_taxaDepreciacao.Focus();
                    return;

                }
                btn_Simular.Enabled = true;
                btn_Simular.Focus();
                e.Handled = true;

            }

        }
        // Método que realiza o cálculo do valor residual referente ao ano de fabricação do carro
        private double CalcularValorResidual()
        {

            int anoCarro = DateTime.Now.Year - Convert.ToInt32(txt_anoCarro.Text);
            double depreciacao = Math.Round(Convert.ToDouble(txt_valorCarro.Text) * Convert.ToDouble(txt_taxaDepreciacao.Text) / 100,2);
            valorResidual = depreciacao * anoCarro;

            return valorResidual;

        }
        // Método que realiza a soma total do financiamento
        private double SomarFinanciamento()
        {
            double soma = Math.Round(_financiamento.CalcularTaxaAnual() + _financiamento.CalcularComissaoAbertura() + valorResidual + _financiamento.Montante,2);
            return soma;

        }
        // Método que realiza o cálculo das parcelas mensais
        private double CalcularParcelas()
        {
            double parcelas = Math.Round(SomarFinanciamento() / _financiamento.PrazoPagamento,2);

            return parcelas;
        }


        private void btn_Simular_Click(object sender, EventArgs e)
        {
           
            lbl_Calculos.Text =
                $"Taxa Anual Bruta = {_financiamento.CalcularTaxaAnual().ToString()}€\n" +
                $"Comissão de Abertura = {_financiamento.CalcularComissaoAbertura().ToString()}€\n" +
                $"Valor Residual = {CalcularValorResidual().ToString()}€\n" +
                $"Total do Financiamento = {SomarFinanciamento().ToString()}€\n" +
                $"Valor das parcelas = {CalcularParcelas().ToString()}€";


        }
      
    }
}
