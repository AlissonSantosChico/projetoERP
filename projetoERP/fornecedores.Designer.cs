namespace projetoERP
{
    partial class fornecedores
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
            label_fornecedores = new Label();
            label_nomeRazao = new Label();
            label_cnpj = new Label();
            label_EMAILFORNECEDOR = new Label();
            labeltelefonefornecedor = new Label();
            label_listafornecedor = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            Column_nomeRazao = new DataGridViewTextBoxColumn();
            Column_cnpj = new DataGridViewTextBoxColumn();
            Column_EmailFornecedor = new DataGridViewTextBoxColumn();
            Column_Telefone = new DataGridViewTextBoxColumn();
            button_SalvarFornecedor = new Button();
            button_editarFornecedor = new Button();
            button_excluir_fornecedor = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_fornecedores
            // 
            label_fornecedores.AutoSize = true;
            label_fornecedores.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_fornecedores.Location = new Point(218, 18);
            label_fornecedores.Name = "label_fornecedores";
            label_fornecedores.Size = new Size(238, 25);
            label_fornecedores.TabIndex = 0;
            label_fornecedores.Text = "CADASTRAR FORNECEDOR";
            // 
            // label_nomeRazao
            // 
            label_nomeRazao.AutoSize = true;
            label_nomeRazao.Location = new Point(35, 59);
            label_nomeRazao.Name = "label_nomeRazao";
            label_nomeRazao.Size = new Size(129, 15);
            label_nomeRazao.TabIndex = 1;
            label_nomeRazao.Text = "NOME/RAZÃO SOCIAL";
            // 
            // label_cnpj
            // 
            label_cnpj.AutoSize = true;
            label_cnpj.Location = new Point(444, 59);
            label_cnpj.Name = "label_cnpj";
            label_cnpj.Size = new Size(34, 15);
            label_cnpj.TabIndex = 2;
            label_cnpj.Text = "CNPJ";
            // 
            // label_EMAILFORNECEDOR
            // 
            label_EMAILFORNECEDOR.AutoSize = true;
            label_EMAILFORNECEDOR.Location = new Point(35, 121);
            label_EMAILFORNECEDOR.Name = "label_EMAILFORNECEDOR";
            label_EMAILFORNECEDOR.Size = new Size(46, 15);
            label_EMAILFORNECEDOR.TabIndex = 3;
            label_EMAILFORNECEDOR.Text = "E-MAIL";
            // 
            // labeltelefonefornecedor
            // 
            labeltelefonefornecedor.AutoSize = true;
            labeltelefonefornecedor.Location = new Point(444, 121);
            labeltelefonefornecedor.Name = "labeltelefonefornecedor";
            labeltelefonefornecedor.Size = new Size(62, 15);
            labeltelefonefornecedor.TabIndex = 4;
            labeltelefonefornecedor.Text = "TELEFONE";
            // 
            // label_listafornecedor
            // 
            label_listafornecedor.AutoSize = true;
            label_listafornecedor.Location = new Point(35, 206);
            label_listafornecedor.Name = "label_listafornecedor";
            label_listafornecedor.Size = new Size(143, 15);
            label_listafornecedor.TabIndex = 5;
            label_listafornecedor.Text = "LISTA DE FORNECEDORES";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(444, 76);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(444, 138);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(35, 138);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(35, 76);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(206, 23);
            textBox4.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column_nomeRazao, Column_cnpj, Column_EmailFornecedor, Column_Telefone });
            dataGridView1.Location = new Point(35, 224);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(641, 105);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column_nomeRazao
            // 
            Column_nomeRazao.HeaderText = "Nome/Razão";
            Column_nomeRazao.MinimumWidth = 6;
            Column_nomeRazao.Name = "Column_nomeRazao";
            // 
            // Column_cnpj
            // 
            Column_cnpj.HeaderText = "CNPJ";
            Column_cnpj.MinimumWidth = 6;
            Column_cnpj.Name = "Column_cnpj";
            // 
            // Column_EmailFornecedor
            // 
            Column_EmailFornecedor.HeaderText = "E-mail";
            Column_EmailFornecedor.MinimumWidth = 6;
            Column_EmailFornecedor.Name = "Column_EmailFornecedor";
            // 
            // Column_Telefone
            // 
            Column_Telefone.HeaderText = "Telenone";
            Column_Telefone.MinimumWidth = 6;
            Column_Telefone.Name = "Column_Telefone";
            // 
            // button_SalvarFornecedor
            // 
            button_SalvarFornecedor.Location = new Point(35, 172);
            button_SalvarFornecedor.Margin = new Padding(3, 2, 3, 2);
            button_SalvarFornecedor.Name = "button_SalvarFornecedor";
            button_SalvarFornecedor.Size = new Size(88, 22);
            button_SalvarFornecedor.TabIndex = 11;
            button_SalvarFornecedor.Text = "Salvar";
            button_SalvarFornecedor.UseVisualStyleBackColor = true;
            button_SalvarFornecedor.Click += button_SalvarFornecedor_Click;
            // 
            // button_editarFornecedor
            // 
            button_editarFornecedor.Location = new Point(158, 172);
            button_editarFornecedor.Margin = new Padding(3, 2, 3, 2);
            button_editarFornecedor.Name = "button_editarFornecedor";
            button_editarFornecedor.Size = new Size(82, 22);
            button_editarFornecedor.TabIndex = 12;
            button_editarFornecedor.Text = "Editar";
            button_editarFornecedor.UseVisualStyleBackColor = true;
            button_editarFornecedor.Click += button_editarFornecedor_Click;
            // 
            // button_excluir_fornecedor
            // 
            button_excluir_fornecedor.BackColor = SystemColors.InactiveCaption;
            button_excluir_fornecedor.Location = new Point(541, 172);
            button_excluir_fornecedor.Margin = new Padding(3, 2, 3, 2);
            button_excluir_fornecedor.Name = "button_excluir_fornecedor";
            button_excluir_fornecedor.Size = new Size(108, 22);
            button_excluir_fornecedor.TabIndex = 13;
            button_excluir_fornecedor.Text = "Excluir";
            button_excluir_fornecedor.UseVisualStyleBackColor = false;
            button_excluir_fornecedor.Click += button_excluir_fornecedor_Click;
            // 
            // fornecedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(700, 338);
            Controls.Add(button_excluir_fornecedor);
            Controls.Add(button_editarFornecedor);
            Controls.Add(button_SalvarFornecedor);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label_listafornecedor);
            Controls.Add(labeltelefonefornecedor);
            Controls.Add(label_EMAILFORNECEDOR);
            Controls.Add(label_cnpj);
            Controls.Add(label_nomeRazao);
            Controls.Add(label_fornecedores);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fornecedores";
            Text = "fornecedores";
            Load += fornecedores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_fornecedores;
        private Label label_nomeRazao;
        private Label label_cnpj;
        private Label label_EMAILFORNECEDOR;
        private Label labeltelefonefornecedor;
        private Label label_listafornecedor;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column_nomeRazao;
        private DataGridViewTextBoxColumn Column_cnpj;
        private DataGridViewTextBoxColumn Column_EmailFornecedor;
        private DataGridViewTextBoxColumn Column_Telefone;
        private Button button_SalvarFornecedor;
        private Button button_editarFornecedor;
        private Button button_excluir_fornecedor;
    }
}