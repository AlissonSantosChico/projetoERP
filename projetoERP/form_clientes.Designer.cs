namespace projetoERP
{
    partial class teste
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
            label_cadcliente = new Label();
            label_NOME = new Label();
            textBox1 = new TextBox();
            label_CPF = new Label();
            label_EMAIL = new Label();
            label_NASCIMENTO = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            Nome = new DataGridViewTextBoxColumn();
            Column_cpf = new DataGridViewTextBoxColumn();
            Column_email = new DataGridViewTextBoxColumn();
            Column_datanasc = new DataGridViewTextBoxColumn();
            button_salvar = new Button();
            button_editar = new Button();
            button_excluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label_cadcliente
            // 
            label_cadcliente.BackColor = SystemColors.ActiveCaption;
            label_cadcliente.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_cadcliente.ForeColor = SystemColors.ActiveCaptionText;
            label_cadcliente.Location = new Point(244, 9);
            label_cadcliente.Name = "label_cadcliente";
            label_cadcliente.Size = new Size(287, 40);
            label_cadcliente.TabIndex = 0;
            label_cadcliente.Text = "CADASTRO DE CLIENTES";
            // 
            // label_NOME
            // 
            label_NOME.AutoSize = true;
            label_NOME.Location = new Point(20, 56);
            label_NOME.Name = "label_NOME";
            label_NOME.Size = new Size(110, 15);
            label_NOME.TabIndex = 1;
            label_NOME.Text = "NOME COMPLETO:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 74);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label_CPF
            // 
            label_CPF.AutoSize = true;
            label_CPF.Location = new Point(425, 56);
            label_CPF.Name = "label_CPF";
            label_CPF.Size = new Size(31, 15);
            label_CPF.TabIndex = 3;
            label_CPF.Text = "CPF:";
            // 
            // label_EMAIL
            // 
            label_EMAIL.AutoSize = true;
            label_EMAIL.Location = new Point(20, 116);
            label_EMAIL.Name = "label_EMAIL";
            label_EMAIL.Size = new Size(49, 15);
            label_EMAIL.TabIndex = 4;
            label_EMAIL.Text = "E-MAIL:";
            // 
            // label_NASCIMENTO
            // 
            label_NASCIMENTO.AutoSize = true;
            label_NASCIMENTO.Location = new Point(425, 116);
            label_NASCIMENTO.Name = "label_NASCIMENTO";
            label_NASCIMENTO.Size = new Size(134, 15);
            label_NASCIMENTO.TabIndex = 5;
            label_NASCIMENTO.Text = "DATA DE NASCIMENTO:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(425, 74);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(175, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(20, 135);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 23);
            textBox3.TabIndex = 7;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(425, 134);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(274, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nome, Column_cpf, Column_email, Column_datanasc });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.WindowText;
            dataGridView1.Location = new Point(20, 220);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(696, 108);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Column_cpf
            // 
            Column_cpf.HeaderText = "CPF";
            Column_cpf.MinimumWidth = 6;
            Column_cpf.Name = "Column_cpf";
            Column_cpf.ReadOnly = true;
            // 
            // Column_email
            // 
            Column_email.HeaderText = "E-mail";
            Column_email.MinimumWidth = 6;
            Column_email.Name = "Column_email";
            Column_email.ReadOnly = true;
            // 
            // Column_datanasc
            // 
            Column_datanasc.HeaderText = "Data de nascimento";
            Column_datanasc.MinimumWidth = 6;
            Column_datanasc.Name = "Column_datanasc";
            Column_datanasc.ReadOnly = true;
            // 
            // button_salvar
            // 
            button_salvar.Location = new Point(20, 173);
            button_salvar.Margin = new Padding(3, 2, 3, 2);
            button_salvar.Name = "button_salvar";
            button_salvar.Size = new Size(127, 22);
            button_salvar.TabIndex = 10;
            button_salvar.Text = "Salvar";
            button_salvar.UseVisualStyleBackColor = true;
            button_salvar.Click += button_salvar_Click;
            // 
            // button_editar
            // 
            button_editar.Location = new Point(162, 173);
            button_editar.Margin = new Padding(3, 2, 3, 2);
            button_editar.Name = "button_editar";
            button_editar.Size = new Size(132, 22);
            button_editar.TabIndex = 11;
            button_editar.Text = "Editar";
            button_editar.UseVisualStyleBackColor = true;
            button_editar.Click += button_editar_Click;
            // 
            // button_excluir
            // 
            button_excluir.Location = new Point(579, 173);
            button_excluir.Margin = new Padding(3, 2, 3, 2);
            button_excluir.Name = "button_excluir";
            button_excluir.Size = new Size(120, 22);
            button_excluir.TabIndex = 12;
            button_excluir.Text = "Excluir";
            button_excluir.UseVisualStyleBackColor = true;
            button_excluir.Click += button_excluir_Click;
            // 
            // teste
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(748, 397);
            Controls.Add(button_excluir);
            Controls.Add(button_editar);
            Controls.Add(button_salvar);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label_NASCIMENTO);
            Controls.Add(label_EMAIL);
            Controls.Add(label_CPF);
            Controls.Add(textBox1);
            Controls.Add(label_NOME);
            Controls.Add(label_cadcliente);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(764, 436);
            MinimumSize = new Size(764, 436);
            Name = "teste";
            Text = "Form1";
            Load += form_clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_cadcliente;
        private Label label_NOME;
        private TextBox textBox1;
        private Label label_CPF;
        private Label label_EMAIL;
        private Label label_NASCIMENTO;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Column_cpf;
        private DataGridViewTextBoxColumn Column_email;
        private DataGridViewTextBoxColumn Column_datanasc;
        private Button button_salvar;
        private Button button_editar;
        private Button button_excluir;
    }
}