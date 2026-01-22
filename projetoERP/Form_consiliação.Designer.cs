namespace projetoERP
{
    partial class Form_consiliação
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ColumnData = new DataGridViewTextBoxColumn();
            Column_Desc = new DataGridViewTextBoxColumn();
            Column_Sistema = new DataGridViewTextBoxColumn();
            Column_banco = new DataGridViewTextBoxColumn();
            Column_status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(173, 9);
            label1.Name = "label1";
            label1.Size = new Size(290, 34);
            label1.TabIndex = 0;
            label1.Text = "CONCILIAÇÃO BANCÁRIA";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnData, Column_Desc, Column_Sistema, Column_banco, Column_status });
            dataGridView1.Location = new Point(56, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(563, 283);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnData
            // 
            ColumnData.HeaderText = "Data";
            ColumnData.Name = "ColumnData";
            ColumnData.Width = 80;
            // 
            // Column_Desc
            // 
            Column_Desc.HeaderText = "Descrição";
            Column_Desc.Name = "Column_Desc";
            Column_Desc.Width = 150;
            // 
            // Column_Sistema
            // 
            Column_Sistema.HeaderText = "Sistema";
            Column_Sistema.Name = "Column_Sistema";
            Column_Sistema.Width = 130;
            // 
            // Column_banco
            // 
            Column_banco.HeaderText = "Banco";
            Column_banco.Name = "Column_banco";
            // 
            // Column_status
            // 
            Column_status.HeaderText = "Status";
            Column_status.Name = "Column_status";
            // 
            // Form_consiliação
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(745, 391);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form_consiliação";
            Text = "Form_consiliação";
            Load += Form_consiliação_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnData;
        private DataGridViewTextBoxColumn Column_Desc;
        private DataGridViewTextBoxColumn Column_Sistema;
        private DataGridViewTextBoxColumn Column_banco;
        private DataGridViewTextBoxColumn Column_status;
    }
}