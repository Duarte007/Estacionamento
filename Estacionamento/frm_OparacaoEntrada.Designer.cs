namespace Estacionamento
{
    partial class frm_OparacaoEntrada
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
            this.cbmVaga = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Entrada = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_Chekin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbmVaga
            // 
            this.cbmVaga.FormattingEnabled = true;
            this.cbmVaga.Location = new System.Drawing.Point(43, 50);
            this.cbmVaga.Name = "cbmVaga";
            this.cbmVaga.Size = new System.Drawing.Size(149, 21);
            this.cbmVaga.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vaga";
            // 
            // Entrada
            // 
            this.Entrada.AutoSize = true;
            this.Entrada.Location = new System.Drawing.Point(43, 85);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(44, 13);
            this.Entrada.TabIndex = 2;
            this.Entrada.Text = "Entrada";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh: mm:ss ";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // btn_Chekin
            // 
            this.btn_Chekin.Location = new System.Drawing.Point(117, 152);
            this.btn_Chekin.Name = "btn_Chekin";
            this.btn_Chekin.Size = new System.Drawing.Size(75, 23);
            this.btn_Chekin.TabIndex = 5;
            this.btn_Chekin.Text = "Check-In";
            this.btn_Chekin.UseVisualStyleBackColor = true;
            this.btn_Chekin.Click += new System.EventHandler(this.btn_Chekin_Click);
            // 
            // frm_OparacaoEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 206);
            this.Controls.Add(this.btn_Chekin);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Entrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbmVaga);
            this.Name = "frm_OparacaoEntrada";
            this.Text = "Check-In";
            this.Load += new System.EventHandler(this.frm_OparacaoEntrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmVaga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Entrada;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_Chekin;
    }
}