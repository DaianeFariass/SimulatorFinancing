namespace SimuladorFinanciamento
{
    partial class SimuladorCarro
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
            this.btn_Simular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_valorCarro = new System.Windows.Forms.TextBox();
            this.txt_anoCarro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_taxaDepreciacao = new System.Windows.Forms.TextBox();
            this.lbl_Montante = new System.Windows.Forms.Label();
            this.lbl_Prazo = new System.Windows.Forms.Label();
            this.lbl_Taxa = new System.Windows.Forms.Label();
            this.lbl_Calculos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Simular
            // 
            this.btn_Simular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Simular.Enabled = false;
            this.btn_Simular.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Simular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Simular.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Simular.Location = new System.Drawing.Point(493, 526);
            this.btn_Simular.Name = "btn_Simular";
            this.btn_Simular.Size = new System.Drawing.Size(201, 70);
            this.btn_Simular.TabIndex = 4;
            this.btn_Simular.Text = "Simular";
            this.btn_Simular.UseVisualStyleBackColor = false;
            this.btn_Simular.Click += new System.EventHandler(this.btn_Simular_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(100, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Taxa Anual Bruta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(100, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prazo de Pagamento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(100, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Montante a Financiar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Location = new System.Drawing.Point(100, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 37);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valor do Carro:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Location = new System.Drawing.Point(100, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ano do Carro:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_valorCarro
            // 
            this.txt_valorCarro.Location = new System.Drawing.Point(398, 319);
            this.txt_valorCarro.Name = "txt_valorCarro";
            this.txt_valorCarro.Size = new System.Drawing.Size(287, 32);
            this.txt_valorCarro.TabIndex = 1;
            this.txt_valorCarro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorCarro);
            // 
            // txt_anoCarro
            // 
            this.txt_anoCarro.Location = new System.Drawing.Point(398, 382);
            this.txt_anoCarro.Name = "txt_anoCarro";
            this.txt_anoCarro.Size = new System.Drawing.Size(287, 32);
            this.txt_anoCarro.TabIndex = 2;
            this.txt_anoCarro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AnoCarro);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Location = new System.Drawing.Point(100, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "Taxa de Depreciação:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_taxaDepreciacao
            // 
            this.txt_taxaDepreciacao.Location = new System.Drawing.Point(398, 446);
            this.txt_taxaDepreciacao.Name = "txt_taxaDepreciacao";
            this.txt_taxaDepreciacao.Size = new System.Drawing.Size(287, 32);
            this.txt_taxaDepreciacao.TabIndex = 3;
            this.txt_taxaDepreciacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TaxaDepreciacao);
            // 
            // lbl_Montante
            // 
            this.lbl_Montante.BackColor = System.Drawing.Color.White;
            this.lbl_Montante.Location = new System.Drawing.Point(398, 129);
            this.lbl_Montante.Name = "lbl_Montante";
            this.lbl_Montante.Size = new System.Drawing.Size(236, 37);
            this.lbl_Montante.TabIndex = 7;
            this.lbl_Montante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Prazo
            // 
            this.lbl_Prazo.BackColor = System.Drawing.Color.White;
            this.lbl_Prazo.Location = new System.Drawing.Point(398, 192);
            this.lbl_Prazo.Name = "lbl_Prazo";
            this.lbl_Prazo.Size = new System.Drawing.Size(236, 37);
            this.lbl_Prazo.TabIndex = 7;
            this.lbl_Prazo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Taxa
            // 
            this.lbl_Taxa.BackColor = System.Drawing.Color.White;
            this.lbl_Taxa.Location = new System.Drawing.Point(398, 255);
            this.lbl_Taxa.Name = "lbl_Taxa";
            this.lbl_Taxa.Size = new System.Drawing.Size(236, 37);
            this.lbl_Taxa.TabIndex = 7;
            this.lbl_Taxa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Calculos
            // 
            this.lbl_Calculos.BackColor = System.Drawing.Color.White;
            this.lbl_Calculos.Location = new System.Drawing.Point(25, 526);
            this.lbl_Calculos.Name = "lbl_Calculos";
            this.lbl_Calculos.Size = new System.Drawing.Size(436, 146);
            this.lbl_Calculos.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 80);
            this.label1.TabIndex = 9;
            this.label1.Text = "Simulador de Financiamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimuladorCarro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(728, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Calculos);
            this.Controls.Add(this.btn_Simular);
            this.Controls.Add(this.txt_taxaDepreciacao);
            this.Controls.Add(this.txt_anoCarro);
            this.Controls.Add(this.txt_valorCarro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Taxa);
            this.Controls.Add(this.lbl_Prazo);
            this.Controls.Add(this.lbl_Montante);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SimuladorCarro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimuladorCarro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Simular;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox txt_valorCarro;
        private TextBox txt_anoCarro;
        private Label label7;
        private TextBox txt_taxaDepreciacao;
        private Label lbl_Montante;
        private Label lbl_Prazo;
        private Label lbl_Taxa;
        private Label lbl_Calculos;
        private Label label1;
    }
}