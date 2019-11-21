namespace Estacionamento
{
    partial class frm_OperacaoSaida
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
            this.btn_Chekout = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Entrada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbmVaga = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Chekout
            // 
            this.btn_Chekout.Location = new System.Drawing.Point(114, 167);
            this.btn_Chekout.Name = "btn_Chekout";
            this.btn_Chekout.Size = new System.Drawing.Size(75, 23);
            this.btn_Chekout.TabIndex = 10;
            this.btn_Chekout.Text = "Check-Out";
            this.btn_Chekout.UseVisualStyleBackColor = true;
            this.btn_Chekout.Click += new System.EventHandler(this.btn_Chekout_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh: mm:ss ";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // Entrada
            // 
            this.Entrada.AllowDrop = true;
            this.Entrada.AutoSize = true;
            this.Entrada.Location = new System.Drawing.Point(37, 99);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(34, 13);
            this.Entrada.TabIndex = 8;
            this.Entrada.Text = "Saida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vaga";
            // 
            // cbmVaga
            // 
            this.cbmVaga.FormattingEnabled = true;
            this.cbmVaga.Location = new System.Drawing.Point(40, 55);
            this.cbmVaga.Name = "cbmVaga";
            this.cbmVaga.Size = new System.Drawing.Size(149, 21);
            this.cbmVaga.TabIndex = 6;
            // 
            // frm_OperacaoSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 225);
            this.Controls.Add(this.btn_Chekout);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmVaga);
            this.Name = "frm_OperacaoSaida";
            this.Text = "Check-Out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Chekout;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Entrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbmVaga;
    }
}