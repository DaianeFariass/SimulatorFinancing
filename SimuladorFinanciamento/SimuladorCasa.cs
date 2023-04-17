using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorFinanciamento
{
    public partial class SimuladorCasa : Form
    {
        FinanciamentoDeCasa _financiamento;

        double spread;

        public SimuladorCasa(double montante, int prazo, double taxa)
        {
            InitializeComponent();         
            lbl_Montante.Text = montante.ToString();
            lbl_Prazo.Text = prazo.ToString();
            lbl_Taxa.Text = taxa.ToString();
            _financiamento = new FinanciamentoDeCasa(montante, prazo, taxa, spread);

        }
        // Leitura e Validação da caixa de texto NomeFiador podendo aceitar somente Letras e Acentuação
        private void NomeFiador(object sender, KeyPressEventArgs e) // Evento KeyPress 
        {
            if (e.KeyChar == (char)Keys.Enter) /// Faz o cast para Char e seta a tecla Enter como chave para trocar de uma caixa de texto para outra
            {
                if (txt_nomeFiador.Text.Length == 0) // Verifica se preencheu a caixa de texto
                {
                    MessageBox.Show("Obrigatório Preencher todos os campos!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!Regex.IsMatch(txt_nomeFiador.Text, @"^[a-zà-úA-ZÀ-Ú-'\s]+$"))
                {

                    MessageBox.Show("Entrada Inválida...");
                    txt_nomeFiador.ResetText();
                    txt_nomeFiador.Focus();
                    return;

                }
                txt_Morada.Enabled = true;
                txt_Morada.Focus();
                e.Handled = true;

            }
        }

        // Leitura e Validação da caixa de texto Morada podendo aceitar qualquer tipo de string menos a vazia
        private void MoradaFiador(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_Morada.Text.Length == 0)
                {
                    MessageBox.Show("Obrigatório Preencher todos os campos!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                txt_Telefone.Enabled = true;
                txt_Telefone.Focus();
                e.Handled = true;

            }

        }
        // Leitura e Validação da caixa de texto Telefone podendo aceitar somente números
        private void txt_Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_Telefone.Text.Length == 0)
                {
                    MessageBox.Show("Obrigatório Preencher todos os campos!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!Regex.IsMatch(txt_Telefone.Text, @"[0-9]"))
                {

                    MessageBox.Show("Entrada Inválida...");
                    txt_Telefone.ResetText();
                    txt_Telefone.Focus();
                    return;

                }
                txt_Nif.Enabled = true;
                txt_Nif.Focus();
                e.Handled = true;

            }
        }
        // Leitura e Validação da caixa de texto Nif podendo aceitar somente números
        private void NifFiador(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_Nif.Text.Length == 0)
                {
                    MessageBox.Show("Obrigatório Preencher todos os campos!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!Regex.IsMatch(txt_Nif.Text, @"[0-9]"))
                {

                    MessageBox.Show("Entrada Inválida...");
                    txt_Nif.ResetText();
                    txt_Nif.Focus();
                    return;

                }
                txt_RendimentoBruto.Enabled = true;
                txt_RendimentoBruto.Focus();
                e.Handled = true;

            }

        }
        // Leitura e Validação da caixa de texto RendimentoBruto podendo aceitar somente números
        private void RendimentoBruto(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_RendimentoBruto.Text.Length == 0)
                {
                    MessageBox.Show("Obrigatório Preencher todos os campos!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!Regex.IsMatch(txt_RendimentoBruto.Text, @"[0-9]"))
                {

                    MessageBox.Show("Entrada Inválida...");
                    txt_RendimentoBruto.ResetText();
                    txt_RendimentoBruto.Focus();
                    return;

                }
                btn_Simular.Enabled = true;
                btn_Simular.Focus();
                e.Handled = true;

            }
        }
        // Método que realiza a soma total do financiamneto
        private double SomarFinanciamento()
        {
            double soma = Math.Round(_financiamento.Montante + _financiamento.CalcularTaxaAnual() + _financiamento.CalcularSpread(), 2);
            return soma;
        }
        // Método que realiza o cálculo das parcelas
        private double CalcularParcelas()
        {

            double parcelas = Math.Round(SomarFinanciamento() / _financiamento.PrazoPagamento, 2);
            return parcelas;

        }

        private void btn_Simular_Click(object sender, EventArgs e)
        {


            lbl_Calculos.Text = $"Cliente:{txt_nomeFiador.Text}\t NIF:{txt_Nif.Text}\n" +
                $"Rendimento Bruto:{txt_RendimentoBruto.Text}€\n" +
                $"Taxa Anual Bruta = {_financiamento.CalcularTaxaAnual().ToString()}€\n" +
                $"Spread = {_financiamento.CalcularSpread().ToString()}€\n" +
                $"Total Financiamento = {SomarFinanciamento().ToString()}€\n" +
                $"Total Parcela Mensal = {CalcularParcelas().ToString()}€";



        }


    }
}
