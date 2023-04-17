namespace SimuladorFinanciamento
{
    partial class SimuladorOutrosFinanciamentos
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
            this.lbl_Prazo = new System.Windows.Forms.Label();
            this.lbl_Taxa = new System.Windows.Forms.Label();
            this.lbl_Montante = new System.Windows.Forms.Label();
            this.lbl_Calculos = new System.Windows.Forms.Label();
            this.btn_Simular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label4.Location = new System.Drawing.Point(89, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Taxa Anual Bruta:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label3.Location = new System.Drawing.Point(89, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prazo de Pagamento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(89, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 37);
            this.label2.TabIndex = 10;
            this.label2.Text = "Montante a Financiar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Prazo
            // 
            this.lbl_Prazo.BackColor = System.Drawing.Color.White;
            this.lbl_Prazo.Location = new System.Drawing.Point(394, 228);
            this.lbl_Prazo.Name = "lbl_Prazo";
            this.lbl_Prazo.Size = new System.Drawing.Size(271, 37);
            this.lbl_Prazo.TabIndex = 11;
            // 
            // lbl_Taxa
            // 
            this.lbl_Taxa.BackColor = System.Drawing.Color.White;
            this.lbl_Taxa.Location = new System.Drawing.Point(394, 320);
            this.lbl_Taxa.Name = "lbl_Taxa";
            this.lbl_Taxa.Size = new System.Drawing.Size(271, 37);
            this.lbl_Taxa.TabIndex = 11;
            // 
            // lbl_Montante
            // 
            this.lbl_Montante.BackColor = System.Drawing.Color.White;
            this.lbl_Montante.Location = new System.Drawing.Point(394, 139);
            this.lbl_Montante.Name = "lbl_Montante";
            this.lbl_Montante.Size = new System.Drawing.Size(271, 37);
            this.lbl_Montante.TabIndex = 11;
            // 
            // lbl_Calculos
            // 
            this.lbl_Calculos.BackColor = System.Drawing.Color.White;
            this.lbl_Calculos.Location = new System.Drawing.Point(40, 420);
            this.lbl_Calculos.Name = "lbl_Calculos";
            this.lbl_Calculos.Size = new System.Drawing.Size(432, 168);
            this.lbl_Calculos.TabIndex = 12;
            // 
            // btn_Simular
            // 
            this.btn_Simular.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Simular.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Simular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Simular.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Simular.Location = new System.Drawing.Point(493, 420);
            this.btn_Simular.Name = "btn_Simular";
            this.btn_Simular.Size = new System.Drawing.Size(201, 66);
            this.btn_Simular.TabIndex = 13;
            this.btn_Simular.Text = "Simular";
            this.btn_Simular.UseVisualStyleBackColor = false;
            this.btn_Simular.Click += new System.EventHandler(this.btn_Simular_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 80);
            this.label1.TabIndex = 15;
            this.label1.Text = "Simulador de Financiamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimuladorOutrosFinanciamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(706, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Simular);
            this.Controls.Add(this.lbl_Calculos);
            this.Controls.Add(this.lbl_Taxa);
            this.Controls.Add(this.lbl_Prazo);
            this.Controls.Add(this.lbl_Montante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "SimuladorOutrosFinanciamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimuladorOutrosFinanciamentos";
            this.ResumeLayout(false);

        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lbl_Prazo;
        private Label lbl_Taxa;
        private Label lbl_Montante;
        private Label lbl_Calculos;
        private Button btn_Simular;
        private Label label1;
    }
}