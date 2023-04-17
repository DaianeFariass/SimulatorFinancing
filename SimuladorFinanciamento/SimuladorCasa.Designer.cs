namespace SimuladorFinanciamento
{
    partial class SimuladorCasa
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nomeFiador = new System.Windows.Forms.TextBox();
            this.txt_Morada = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_Taxa = new System.Windows.Forms.Label();
            this.lbl_Prazo = new System.Windows.Forms.Label();
            this.lbl_Montante = new System.Windows.Forms.Label();
            this.txt_Nif = new System.Windows.Forms.TextBox();
            this.txt_RendimentoBruto = new System.Windows.Forms.TextBox();
            this.lbl_Calculos = new System.Windows.Forms.Label();
            this.btn_Simular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(94, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Taxa Anual Bruta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(94, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prazo de Pagamento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(94, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Montante a Financiar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nomeFiador
            // 
            this.txt_nomeFiador.Location = new System.Drawing.Point(392, 230);
            this.txt_nomeFiador.Name = "txt_nomeFiador";
            this.txt_nomeFiador.Size = new System.Drawing.Size(302, 32);
            this.txt_nomeFiador.TabIndex = 1;
            this.txt_nomeFiador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NomeFiador);
            // 
            // txt_Morada
            // 
            this.txt_Morada.Location = new System.Drawing.Point(392, 278);
            this.txt_Morada.Name = "txt_Morada";
            this.txt_Morada.Size = new System.Drawing.Size(302, 32);
            this.txt_Morada.TabIndex = 2;
            this.txt_Morada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MoradaFiador);
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(392, 323);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(302, 32);
            this.txt_Telefone.TabIndex = 3;
            this.txt_Telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefone_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label5.Location = new System.Drawing.Point(53, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nome Fiador:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label6.Location = new System.Drawing.Point(53, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Morada:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label7.Location = new System.Drawing.Point(53, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 32);
            this.label7.TabIndex = 8;
            this.label7.Text = "Telefone:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label8.Location = new System.Drawing.Point(53, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "NIF:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label9.Location = new System.Drawing.Point(53, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 32);
            this.label9.TabIndex = 8;
            this.label9.Text = "Rendimento Bruto Anual:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Taxa
            // 
            this.lbl_Taxa.BackColor = System.Drawing.Color.White;
            this.lbl_Taxa.Location = new System.Drawing.Point(392, 181);
            this.lbl_Taxa.Name = "lbl_Taxa";
            this.lbl_Taxa.Size = new System.Drawing.Size(236, 32);
            this.lbl_Taxa.TabIndex = 12;
            this.lbl_Taxa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Prazo
            // 
            this.lbl_Prazo.BackColor = System.Drawing.Color.White;
            this.lbl_Prazo.Location = new System.Drawing.Point(392, 136);
            this.lbl_Prazo.Name = "lbl_Prazo";
            this.lbl_Prazo.Size = new System.Drawing.Size(236, 32);
            this.lbl_Prazo.TabIndex = 13;
            this.lbl_Prazo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Montante
            // 
            this.lbl_Montante.BackColor = System.Drawing.Color.White;
            this.lbl_Montante.Location = new System.Drawing.Point(392, 89);
            this.lbl_Montante.Name = "lbl_Montante";
            this.lbl_Montante.Size = new System.Drawing.Size(236, 32);
            this.lbl_Montante.TabIndex = 14;
            this.lbl_Montante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Nif
            // 
            this.txt_Nif.Location = new System.Drawing.Point(392, 372);
            this.txt_Nif.Name = "txt_Nif";
            this.txt_Nif.Size = new System.Drawing.Size(302, 32);
            this.txt_Nif.TabIndex = 4;
            this.txt_Nif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NifFiador);
            // 
            // txt_RendimentoBruto
            // 
            this.txt_RendimentoBruto.Location = new System.Drawing.Point(392, 421);
            this.txt_RendimentoBruto.Name = "txt_RendimentoBruto";
            this.txt_RendimentoBruto.Size = new System.Drawing.Size(302, 32);
            this.txt_RendimentoBruto.TabIndex = 5;
            this.txt_RendimentoBruto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RendimentoBruto);
            // 
            // lbl_Calculos
            // 
            this.lbl_Calculos.BackColor = System.Drawing.Color.White;
            this.lbl_Calculos.Location = new System.Drawing.Point(47, 462);
            this.lbl_Calculos.Name = "lbl_Calculos";
            this.lbl_Calculos.Size = new System.Drawing.Size(466, 162);
            this.lbl_Calculos.TabIndex = 7;
            // 
            // btn_Simular
            // 
            this.btn_Simular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Simular.Enabled = false;
            this.btn_Simular.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Simular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Simular.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Simular.Location = new System.Drawing.Point(519, 462);
            this.btn_Simular.Name = "btn_Simular";
            this.btn_Simular.Size = new System.Drawing.Size(182, 65);
            this.btn_Simular.TabIndex = 6;
            this.btn_Simular.Text = "Simular";
            this.btn_Simular.UseVisualStyleBackColor = false;
            this.btn_Simular.Click += new System.EventHandler(this.btn_Simular_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 80);
            this.label1.TabIndex = 15;
            this.label1.Text = "Simulador de Financiamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimuladorCasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(706, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Simular);
            this.Controls.Add(this.lbl_Calculos);
            this.Controls.Add(this.txt_RendimentoBruto);
            this.Controls.Add(this.txt_Nif);
            this.Controls.Add(this.lbl_Taxa);
            this.Controls.Add(this.lbl_Prazo);
            this.Controls.Add(this.lbl_Montante);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_Morada);
            this.Controls.Add(this.txt_nomeFiador);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SimuladorCasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimuladorCasa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_nomeFiador;
        private TextBox txt_Morada;
        private TextBox txt_Telefone;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lbl_Taxa;
        private Label lbl_Prazo;
        private Label lbl_Montante;
        private TextBox txt_Nif;
        private TextBox txt_RendimentoBruto;
        private Label lbl_Calculos;
        private Button btn_Simular;
        private Label label1;
    }
}