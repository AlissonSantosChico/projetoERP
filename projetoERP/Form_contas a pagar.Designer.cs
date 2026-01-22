namespace projetoERP
{
    partial class Form_contas_a_pagar
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
            label_contasAPagar = new Label();
            dataGridView1 = new DataGridView();
            Column_fornecedorPagar = new DataGridViewTextBoxColumn();
            Column_Descrição = new DataGridViewTextBoxColumn();
            ColumnValor = new DataGridViewTextBoxColumn();
            Vencimento = new DataGridViewTextBoxColumn();
            ColumnStatus = new DataGridViewTextBoxColumn();
            button_EditarContaspagar = new Button();
            button_salvarContaspagar = new Button();
            button_excluirContaspagar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_contasAPagar
            // 
            label_contasAPagar.AutoSize = true;
            label_contasAPagar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_contasAPagar.Location = new Point(258, 20);
            label_contasAPagar.Name = "label_contasAPagar";
            label_contasAPagar.Size = new Size(162, 25);
            label_contasAPagar.TabIndex = 0;
            label_contasAPagar.Text = "CONTAS A PAGAR";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column_fornecedorPagar, Column_Descrição, ColumnValor, Vencimento, ColumnStatus });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(10, 56);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(679, 236);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column_fornecedorPagar
            // 
            Column_fornecedorPagar.HeaderText = "Fornecedor";
            Column_fornecedorPagar.MinimumWidth = 6;
            Column_fornecedorPagar.Name = "Column_fornecedorPagar";
            // 
            // Column_Descrição
            // 
            Column_Descrição.HeaderText = "Descrição";
            Column_Descrição.MinimumWidth = 6;
            Column_Descrição.Name = "Column_Descrição";
            // 
            // ColumnValor
            // 
            ColumnValor.HeaderText = "Valor";
            ColumnValor.MinimumWidth = 6;
            ColumnValor.Name = "ColumnValor";
            // 
            // Vencimento
            // 
            Vencimento.HeaderText = "Vencimento";
            Vencimento.MinimumWidth = 6;
            Vencimento.Name = "Vencimento";
            // 
            // ColumnStatus
            // 
            ColumnStatus.HeaderText = "Status";
            ColumnStatus.MinimumWidth = 6;
            ColumnStatus.Name = "ColumnStatus";
            // 
            // button_EditarContaspagar
            // 
            button_EditarContaspagar.Location = new Point(145, 296);
            button_EditarContaspagar.Margin = new Padding(3, 2, 3, 2);
            button_EditarContaspagar.Name = "button_EditarContaspagar";
            button_EditarContaspagar.Size = new Size(82, 22);
            button_EditarContaspagar.TabIndex = 2;
            button_EditarContaspagar.Text = "Editar";
            button_EditarContaspagar.UseVisualStyleBackColor = true;
            // 
            // button_salvarContaspagar
            // 
            button_salvarContaspagar.Location = new Point(35, 296);
            button_salvarContaspagar.Margin = new Padding(3, 2, 3, 2);
            button_salvarContaspagar.Name = "button_salvarContaspagar";
            button_salvarContaspagar.Size = new Size(82, 22);
            button_salvarContaspagar.TabIndex = 3;
            button_salvarContaspagar.Text = "Salvar";
            button_salvarContaspagar.UseVisualStyleBackColor = true;
            // 
            // button_excluirContaspagar
            // 
            button_excluirContaspagar.Location = new Point(572, 296);
            button_excluirContaspagar.Margin = new Padding(3, 2, 3, 2);
            button_excluirContaspagar.Name = "button_excluirContaspagar";
            button_excluirContaspagar.Size = new Size(82, 22);
            button_excluirContaspagar.TabIndex = 4;
            button_excluirContaspagar.Text = "Excluir";
            button_excluirContaspagar.UseVisualStyleBackColor = true;
            // 
            // Form_contas_a_pagar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(748, 397);
            Controls.Add(button_excluirContaspagar);
            Controls.Add(button_salvarContaspagar);
            Controls.Add(button_EditarContaspagar);
            Controls.Add(dataGridView1);
            Controls.Add(label_contasAPagar);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(764, 436);
            MinimumSize = new Size(764, 436);
            Name = "Form_contas_a_pagar";
            Text = "Form_contas_a_pagar";
            Load += Form_contas_a_pagar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_contasAPagar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column_fornecedorPagar;
        private DataGridViewTextBoxColumn Column_Descrição;
        private DataGridViewTextBoxColumn ColumnValor;
        private DataGridViewTextBoxColumn Vencimento;
        private DataGridViewTextBoxColumn ColumnStatus;
        private Button button_EditarContaspagar;
        private Button button_salvarContaspagar;
        private Button button_excluirContaspagar;
    }
}