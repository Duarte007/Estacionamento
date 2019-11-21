namespace Estacionamento
{
    partial class frm_GridVeiculos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.placa,
            this.proprietario,
            this.porte});
            this.dataGridView1.Location = new System.Drawing.Point(28, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(659, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // placa
            // 
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            // 
            // proprietario
            // 
            this.proprietario.HeaderText = "Proprietário";
            this.proprietario.Name = "proprietario";
            // 
            // porte
            // 
            this.porte.HeaderText = "Porte";
            this.porte.Name = "porte";
            // 
            // frm_GridVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 535);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_GridVeiculos";
            this.Text = "Veículos";
            this.Load += new System.EventHandler(this.frm_GridVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn proprietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn porte;
    }
}