namespace projetoERP
{
    partial class Form_contasAReceber
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
            label_contasAreceber = new Label();
            dataGridView1 = new DataGridView();
            ColumnFornecedorReceber = new DataGridViewTextBoxColumn();
            Column_DescriçãoReceber = new DataGridViewTextBoxColumn();
            ColumnValor = new DataGridViewTextBoxColumn();
            ColumnVencimento = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_contasAreceber
            // 
            label_contasAreceber.AutoSize = true;
            label_contasAreceber.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_contasAreceber.Location = new Point(243, 16);
            label_contasAreceber.Name = "label_contasAreceber";
            label_contasAreceber.Size = new Size(179, 25);
            label_contasAreceber.TabIndex = 0;
            label_contasAreceber.Text = "CONTAS A RECEBER";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnFornecedorReceber, Column_DescriçãoReceber, ColumnValor, ColumnVencimento, ColumnStatus });
            dataGridView1.Location = new Point(22, 59);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(654, 238);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnFornecedorReceber
            // 
            ColumnFornecedorReceber.HeaderText = "Fornecedor";
            ColumnFornecedorReceber.MinimumWidth = 6;
            ColumnFornecedorReceber.Name = "ColumnFornecedorReceber";
            // 
            // Column_DescriçãoReceber
            // 
            Column_DescriçãoReceber.HeaderText = "Descrição";
            Column_DescriçãoReceber.MinimumWidth = 6;
            Column_DescriçãoReceber.Name = "Column_DescriçãoReceber";
            // 
            // ColumnValor
            // 
            ColumnValor.HeaderText = "Valor";
            ColumnValor.MinimumWidth = 6;
            ColumnValor.Name = "ColumnValor";
            // 
            // ColumnVencimento
            // 
            ColumnVencimento.HeaderText = "Vencimento";
            ColumnVencimento.MinimumWidth = 6;
            ColumnVencimento.Name = "ColumnVencimento";
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.MinimumWidth = 6;
            ColumnStatus.Name = "ColumnStatus";
            // 
            // Form_contasAReceber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridView1);
            Controls.Add(label_contasAreceber);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_contasAReceber";
            Text = "Form_contasAReceber";
            Load += Form_contasAReceber_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_contasAreceber;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnFornecedorReceber;
        private DataGridViewTextBoxColumn Column_DescriçãoReceber;
        private DataGridViewTextBoxColumn ColumnValor;
        private DataGridViewTextBoxColumn ColumnVencimento;
        private DataGridViewTextBoxColumn ColumnStatus;
    }
}