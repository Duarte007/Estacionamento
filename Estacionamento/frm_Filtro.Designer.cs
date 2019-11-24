namespace Estacionamento
{
    partial class frm_Filtro
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
            this.txt_Filtro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Filtro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Filtro
            // 
            this.txt_Filtro.Location = new System.Drawing.Point(31, 57);
            this.txt_Filtro.Name = "txt_Filtro";
            this.txt_Filtro.Size = new System.Drawing.Size(240, 20);
            this.txt_Filtro.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o CPF do cliente:";
            // 
            // btn_Filtro
            // 
            this.btn_Filtro.Location = new System.Drawing.Point(196, 98);
            this.btn_Filtro.Name = "btn_Filtro";
            this.btn_Filtro.Size = new System.Drawing.Size(75, 23);
            this.btn_Filtro.TabIndex = 2;
            this.btn_Filtro.Text = "Filtrar";
            this.btn_Filtro.UseVisualStyleBackColor = true;
            this.btn_Filtro.Click += new System.EventHandler(this.Btn_Filtro_Click);
            // 
            // frm_Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 133);
            this.Controls.Add(this.btn_Filtro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Filtro);
            this.Name = "frm_Filtro";
            this.Text = "Filtro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Filtro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Filtro;
    }
}