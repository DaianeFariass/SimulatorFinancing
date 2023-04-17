namespace SimuladorFinanciamento
{
    partial class PrincipalFinanciamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalFinanciamento));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_montanteAFinanciar = new System.Windows.Forms.TextBox();
            this.txt_prazoPagamento = new System.Windows.Forms.TextBox();
            this.txt_taxaAnual = new System.Windows.Forms.TextBox();
            this.btn_financiarCarro = new System.Windows.Forms.Button();
            this.btn_FinanciarCasa = new System.Windows.Forms.Button();
            this.btn_OutrosFinanciamentos = new System.Windows.Forms.Button();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.pnl_Logo = new System.Windows.Forms.Panel();
            this.pnl_Principal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_Menu.SuspendLayout();
            this.pnl_Principal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 84);
            this.label1.TabIndex = 5;
            this.label1.Text = "Simulador de Financiamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(72, 343);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Taxa Anual Bruta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(72, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prazo de Pagamento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(72, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Montante a Financiar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_montanteAFinanciar
            // 
            this.txt_montanteAFinanciar.Location = new System.Drawing.Point(354, 174);
            this.txt_montanteAFinanciar.Name = "txt_montanteAFinanciar";
            this.txt_montanteAFinanciar.Size = new System.Drawing.Size(330, 32);
            this.txt_montanteAFinanciar.TabIndex = 11;
            this.txt_montanteAFinanciar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montanteAFinanciar);
            // 
            // txt_prazoPagamento
            // 
            this.txt_prazoPagamento.Location = new System.Drawing.Point(354, 263);
            this.txt_prazoPagamento.Name = "txt_prazoPagamento";
            this.txt_prazoPagamento.Size = new System.Drawing.Size(335, 32);
            this.txt_prazoPagamento.TabIndex = 12;
            this.txt_prazoPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrazoDePagamento);
            // 
            // txt_taxaAnual
            // 
            this.txt_taxaAnual.Location = new System.Drawing.Point(354, 348);
            this.txt_taxaAnual.Name = "txt_taxaAnual";
            this.txt_taxaAnual.Size = new System.Drawing.Size(330, 32);
            this.txt_taxaAnual.TabIndex = 13;
            this.txt_taxaAnual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TaxaAnualBruta);
            // 
            // btn_financiarCarro
            // 
            this.btn_financiarCarro.BackColor = System.Drawing.Color.Transparent;
            this.btn_financiarCarro.Enabled = false;
            this.btn_financiarCarro.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_financiarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_financiarCarro.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_financiarCarro.ForeColor = System.Drawing.Color.Black;
            this.btn_financiarCarro.Location = new System.Drawing.Point(0, 305);
            this.btn_financiarCarro.Name = "btn_financiarCarro";
            this.btn_financiarCarro.Size = new System.Drawing.Size(250, 75);
            this.btn_financiarCarro.TabIndex = 14;
            this.btn_financiarCarro.Text = "Financiar Carro";
            this.btn_financiarCarro.UseVisualStyleBackColor = false;
            this.btn_financiarCarro.Click += new System.EventHandler(this.btn_financiarCarro_Click);
            // 
            // btn_FinanciarCasa
            // 
            this.btn_FinanciarCasa.BackColor = System.Drawing.Color.Transparent;
            this.btn_FinanciarCasa.Enabled = false;
            this.btn_FinanciarCasa.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_FinanciarCasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FinanciarCasa.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_FinanciarCasa.ForeColor = System.Drawing.Color.Black;
            this.btn_FinanciarCasa.Location = new System.Drawing.Point(0, 415);
            this.btn_FinanciarCasa.Name = "btn_FinanciarCasa";
            this.btn_FinanciarCasa.Size = new System.Drawing.Size(250, 75);
            this.btn_FinanciarCasa.TabIndex = 14;
            this.btn_FinanciarCasa.Text = "Financiar Casa";
            this.btn_FinanciarCasa.UseVisualStyleBackColor = false;
            this.btn_FinanciarCasa.Click += new System.EventHandler(this.btn_FinanciarCasa_Click);
            // 
            // btn_OutrosFinanciamentos
            // 
            this.btn_OutrosFinanciamentos.BackColor = System.Drawing.Color.Transparent;
            this.btn_OutrosFinanciamentos.Enabled = false;
            this.btn_OutrosFinanciamentos.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_OutrosFinanciamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OutrosFinanciamentos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_OutrosFinanciamentos.ForeColor = System.Drawing.Color.Black;
            this.btn_OutrosFinanciamentos.Location = new System.Drawing.Point(0, 542);
            this.btn_OutrosFinanciamentos.Name = "btn_OutrosFinanciamentos";
            this.btn_OutrosFinanciamentos.Size = new System.Drawing.Size(250, 75);
            this.btn_OutrosFinanciamentos.TabIndex = 14;
            this.btn_OutrosFinanciamentos.Text = "Outros Financiamentos";
            this.btn_OutrosFinanciamentos.UseVisualStyleBackColor = false;
            this.btn_OutrosFinanciamentos.Click += new System.EventHandler(this.btn_OutrosFinanciamentos_Click);
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Menu.Controls.Add(this.btn_OutrosFinanciamentos);
            this.pnl_Menu.Controls.Add(this.pnl_Logo);
            this.pnl_Menu.Controls.Add(this.btn_financiarCarro);
            this.pnl_Menu.Controls.Add(this.btn_FinanciarCasa);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(250, 764);
            this.pnl_Menu.TabIndex = 15;
            // 
            // pnl_Logo
            // 
            this.pnl_Logo.BackColor = System.Drawing.Color.Gold;
            this.pnl_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_Logo.BackgroundImage")));
            this.pnl_Logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Logo.Name = "pnl_Logo";
            this.pnl_Logo.Size = new System.Drawing.Size(250, 253);
            this.pnl_Logo.TabIndex = 0;
            // 
            // pnl_Principal
            // 
            this.pnl_Principal.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Principal.Controls.Add(this.panel1);
            this.pnl_Principal.Controls.Add(this.txt_taxaAnual);
            this.pnl_Principal.Controls.Add(this.label4);
            this.pnl_Principal.Controls.Add(this.txt_prazoPagamento);
            this.pnl_Principal.Controls.Add(this.txt_montanteAFinanciar);
            this.pnl_Principal.Controls.Add(this.label2);
            this.pnl_Principal.Controls.Add(this.label3);
            this.pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Principal.Location = new System.Drawing.Point(250, 0);
            this.pnl_Principal.Name = "pnl_Principal";
            this.pnl_Principal.Size = new System.Drawing.Size(728, 764);
            this.pnl_Principal.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 84);
            this.panel1.TabIndex = 14;
            // 
            // PrincipalFinanciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 764);
            this.Controls.Add(this.pnl_Principal);
            this.Controls.Add(this.pnl_Menu);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "PrincipalFinanciamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalFinanciamento";
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_Principal.ResumeLayout(false);
            this.pnl_Principal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_montanteAFinanciar;
        private TextBox txt_prazoPagamento;
        private TextBox txt_taxaAnual;
        private Button btn_financiarCarro;
        private Button btn_FinanciarCasa;
        private Button btn_OutrosFinanciamentos;
        private Panel pnl_Menu;
        private Panel pnl_Logo;
        private Panel pnl_Principal;
        private Panel panel1;
    }
}