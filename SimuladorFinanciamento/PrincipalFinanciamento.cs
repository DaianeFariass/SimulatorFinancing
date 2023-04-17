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
    public partial class PrincipalFinanciamento : Form
    {
        public PrincipalFinanciamento()
        {
            InitializeComponent();
        }
        // Leitura e Validação da caixa de texto montanteAFinanciar podendo aceitar somente números
        private void montanteAFinanciar(object sender, KeyPressEventArgs e) 
        {
            if (e.KeyChar == (char)Keys.Enter) // Evento que faz o cast para Char e seta a tecla Enter como chave para trocar de uma caixa de texto para outra
            {
                if (txt_montanteAFinanciar.Text.Length == 0)
                {
                    MessageBox.Show("Obrigatório Preencher todos os campos!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!Regex.IsMatch(txt_montanteAFinanciar.Text, @"[0-9]"))
                {

                    MessageBox.Show("Entrada Inválida...");
                    txt_montanteAFinanciar.ResetText();
                    txt_montanteAFinanciar.Focus();
                    return;

                }
                double montante;
                if (!double.TryParse(txt_montanteAFinanciar.Text, out montante) || montante < 500)
                {
                    MessageBox.Show("Valor minímo de financiamento é 500€");
                    txt_montanteAFinanciar.ResetText();
                    txt_montanteAFinanciar.Focus();
                    return;

                }
                txt_prazoPagamento.Enabled= true;
                txt_prazoPagamento.Focus();
                e.Handled = true;   

            }


        }
        // Leitura e Validação da caixa de texto prazoPagamento podendo aceitar somente números
        private void PrazoDePagamento(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_prazoPagamento.Text.Length == 0)
                {
                    MessageBox.Show("Obrigatório Preencher todos os campos!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (!Regex.IsMatch(txt_prazoPagamento.Text, @"[0-9]"))
                {

                    MessageBox.Show("Entrada Inválida...");
                    txt_prazoPagamento.ResetText();
                    txt_prazoPagamento.Focus();
                    return;

                }
                txt_taxaAnual.Enabled= true;  
                txt_taxaAnual.Focus();  
                e.Handled = true;

            }

        }
        // Leitura e Validação da caixa de texto taxaAnual podendo aceitar somente números
        private void TaxaAnualBruta(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!Regex.IsMatch(txt_taxaAnual.Text, @"[0-9]"))
                {

                    MessageBox.Show("Entrada Inválida...");
                    txt_taxaAnual.ResetText();
                    txt_taxaAnual.Focus();
                    return;
                }
                btn_financiarCarro.Enabled= true;
                btn_FinanciarCasa.Enabled= true;
                btn_OutrosFinanciamentos.Enabled= true;
                e.Handled = true;

            }

        }
        // Método que abre os forms(SimuladorCarro, SimuladorCasa,SimuladorOutrosFinanciamentos) em um único painel no form PrincipalFinanciamento
        private Form formPrincial = null;
        private void AbrirFormSimulador(Form formSimulador)
        {
            if (formPrincial != null)
                formPrincial.Close();
            formPrincial = formSimulador;
            formSimulador.TopLevel = false;
            formSimulador.FormBorderStyle = FormBorderStyle.None;
            formSimulador.Dock = DockStyle.Fill;
            pnl_Principal.Controls.Add(formSimulador);
            pnl_Principal.Tag = formSimulador;
            formSimulador.BringToFront();
            formSimulador.Show();

        }

        private void btn_financiarCarro_Click(object sender, EventArgs e)
        {
            int prazo;
            if (!int.TryParse(txt_prazoPagamento.Text, out prazo) || prazo > 60)
            {
                MessageBox.Show("O prazo de Pagamento não pode ser superior a 60 meses", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_prazoPagamento.ResetText();
                txt_prazoPagamento.Focus();
                return;
            }
            else
            {
                AbrirFormSimulador(new SimuladorCarro(Convert.ToDouble(txt_montanteAFinanciar.Text), Convert.ToInt32(txt_prazoPagamento.Text), Convert.ToDouble(txt_taxaAnual.Text)));
            

            }


        }

        private void btn_FinanciarCasa_Click(object sender, EventArgs e)
        {
            AbrirFormSimulador(new SimuladorCasa(Convert.ToDouble(txt_montanteAFinanciar.Text), Convert.ToInt32(txt_prazoPagamento.Text), Convert.ToDouble(txt_taxaAnual.Text)));
            
        }

        private void btn_OutrosFinanciamentos_Click(object sender, EventArgs e)
        {
            AbrirFormSimulador(new SimuladorOutrosFinanciamentos(Convert.ToDouble(txt_montanteAFinanciar.Text), Convert.ToInt32(txt_prazoPagamento.Text), Convert.ToDouble(txt_taxaAnual.Text)));
        }
      
       
        

    }
}
