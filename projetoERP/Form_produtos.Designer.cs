namespace projetoERP
{
    partial class Form_produtos
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
            label_cadprodutos = new Label();
            label_NOMEPRODUTO = new Label();
            label_CODIGO = new Label();
            label_DESCRIÇÃO = new Label();
            label_PREÇO = new Label();
            label_ESTOQUE = new Label();
            textBox_descprod = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            Column_codigo = new DataGridViewTextBoxColumn();
            Column_nomeprod = new DataGridViewTextBoxColumn();
            Column_preco = new DataGridViewTextBoxColumn();
            Column_estoque = new DataGridViewTextBoxColumn();
            button_salvarprodutos = new Button();
            button_editarprodutos = new Button();
            button_excluirprodutos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_cadprodutos
            // 
            label_cadprodutos.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_cadprodutos.Location = new Point(233, 7);
            label_cadprodutos.Name = "label_cadprodutos";
            label_cadprodutos.Size = new Size(257, 26);
            label_cadprodutos.TabIndex = 0;
            label_cadprodutos.Text = "CADASTRO DE PRODUTOS";
            // 
            // label_NOMEPRODUTO
            // 
            label_NOMEPRODUTO.AutoSize = true;
            label_NOMEPRODUTO.Location = new Point(57, 40);
            label_NOMEPRODUTO.Name = "label_NOMEPRODUTO";
            label_NOMEPRODUTO.Size = new Size(119, 15);
            label_NOMEPRODUTO.TabIndex = 1;
            label_NOMEPRODUTO.Text = "NOME DO PRODUTO";
            // 
            // label_CODIGO
            // 
            label_CODIGO.AutoSize = true;
            label_CODIGO.Location = new Point(496, 40);
            label_CODIGO.Name = "label_CODIGO";
            label_CODIGO.Size = new Size(129, 15);
            label_CODIGO.TabIndex = 2;
            label_CODIGO.Text = "CÓDIGO DO PRODUTO";
            // 
            // label_DESCRIÇÃO
            // 
            label_DESCRIÇÃO.AutoSize = true;
            label_DESCRIÇÃO.Location = new Point(57, 97);
            label_DESCRIÇÃO.Name = "label_DESCRIÇÃO";
            label_DESCRIÇÃO.Size = new Size(147, 15);
            label_DESCRIÇÃO.TabIndex = 3;
            label_DESCRIÇÃO.Text = "DESCRIÇÃO DO PRODUTO";
            // 
            // label_PREÇO
            // 
            label_PREÇO.AutoSize = true;
            label_PREÇO.Location = new Point(57, 183);
            label_PREÇO.Name = "label_PREÇO";
            label_PREÇO.Size = new Size(44, 15);
            label_PREÇO.TabIndex = 4;
            label_PREÇO.Text = "PREÇO";
            // 
            // label_ESTOQUE
            // 
            label_ESTOQUE.AutoSize = true;
            label_ESTOQUE.Location = new Point(496, 183);
            label_ESTOQUE.Name = "label_ESTOQUE";
            label_ESTOQUE.Size = new Size(57, 15);
            label_ESTOQUE.TabIndex = 5;
            label_ESTOQUE.Text = "ESTOQUE";
            // 
            // textBox_descprod
            // 
            textBox_descprod.Location = new Point(57, 114);
            textBox_descprod.Margin = new Padding(3, 2, 3, 2);
            textBox_descprod.MaximumSize = new Size(582, 76);
            textBox_descprod.MinimumSize = new Size(582, 31);
            textBox_descprod.Multiline = true;
            textBox_descprod.Name = "textBox_descprod";
            textBox_descprod.Size = new Size(582, 61);
            textBox_descprod.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(496, 57);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(57, 57);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(57, 200);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(131, 23);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(496, 200);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(142, 23);
            textBox4.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column_codigo, Column_nomeprod, Column_preco, Column_estoque });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(57, 284);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(581, 84);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column_codigo
            // 
            Column_codigo.HeaderText = "Código";
            Column_codigo.MinimumWidth = 6;
            Column_codigo.Name = "Column_codigo";
            // 
            // Column_nomeprod
            // 
            Column_nomeprod.HeaderText = "Nome";
            Column_nomeprod.MinimumWidth = 6;
            Column_nomeprod.Name = "Column_nomeprod";
            // 
            // Column_preco
            // 
            Column_preco.HeaderText = "Preço";
            Column_preco.MinimumWidth = 6;
            Column_preco.Name = "Column_preco";
            // 
            // Column_estoque
            // 
            Column_estoque.HeaderText = "Estoque";
            Column_estoque.MinimumWidth = 6;
            Column_estoque.Name = "Column_estoque";
            // 
            // button_salvarprodutos
            // 
            button_salvarprodutos.Location = new Point(57, 241);
            button_salvarprodutos.Margin = new Padding(3, 2, 3, 2);
            button_salvarprodutos.Name = "button_salvarprodutos";
            button_salvarprodutos.Size = new Size(105, 22);
            button_salvarprodutos.TabIndex = 12;
            button_salvarprodutos.Text = "Salvar";
            button_salvarprodutos.UseVisualStyleBackColor = true;
            button_salvarprodutos.Click += button_salvarprodutos_Click;
            // 
            // button_editarprodutos
            // 
            button_editarprodutos.Location = new Point(167, 241);
            button_editarprodutos.Margin = new Padding(3, 2, 3, 2);
            button_editarprodutos.Name = "button_editarprodutos";
            button_editarprodutos.Size = new Size(116, 22);
            button_editarprodutos.TabIndex = 13;
            button_editarprodutos.Text = "Editar";
            button_editarprodutos.UseVisualStyleBackColor = true;
            button_editarprodutos.Click += button_editarprodutos_Click;
            // 
            // button_excluirprodutos
            // 
            button_excluirprodutos.Location = new Point(522, 241);
            button_excluirprodutos.Margin = new Padding(3, 2, 3, 2);
            button_excluirprodutos.Name = "button_excluirprodutos";
            button_excluirprodutos.Size = new Size(116, 22);
            button_excluirprodutos.TabIndex = 14;
            button_excluirprodutos.Text = "Excluir";
            button_excluirprodutos.UseVisualStyleBackColor = true;
            button_excluirprodutos.Click += button_excluirprodutos_Click;
            // 
            // Form_produtos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(657, 392);
            Controls.Add(button_excluirprodutos);
            Controls.Add(button_editarprodutos);
            Controls.Add(button_salvarprodutos);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(textBox_descprod);
            Controls.Add(label_ESTOQUE);
            Controls.Add(label_PREÇO);
            Controls.Add(label_DESCRIÇÃO);
            Controls.Add(label_CODIGO);
            Controls.Add(label_NOMEPRODUTO);
            Controls.Add(label_cadprodutos);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_produtos";
            Text = "Form_produtos";
            Load += Form_produtos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_cadprodutos;
        private Label label_NOMEPRODUTO;
        private Label label_CODIGO;
        private Label label_DESCRIÇÃO;
        private Label label_PREÇO;
        private Label label_ESTOQUE;
        private TextBox textBox_descprod;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column_codigo;
        private DataGridViewTextBoxColumn Column_nomeprod;
        private DataGridViewTextBoxColumn Column_preco;
        private DataGridViewTextBoxColumn Column_estoque;
        private Button button_salvarprodutos;
        private Button button_editarprodutos;
        private Button button_excluirprodutos;
    }
}