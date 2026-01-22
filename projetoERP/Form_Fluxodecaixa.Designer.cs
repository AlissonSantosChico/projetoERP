namespace projetoERP
{
    partial class Form_Fluxodecaixa
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
            panel_periodo = new Panel();
            button_filtrar = new Button();
            label_até = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label_periodo = new Label();
            panel_entradas = new Panel();
            label2 = new Label();
            label_ENTRADAS = new Label();
            panel1 = new Panel();
            label_SAIDASVALOR = new Label();
            label_SAIDAS = new Label();
            dataGridView1 = new DataGridView();
            Column_data = new DataGridViewTextBoxColumn();
            Column_valor = new DataGridViewTextBoxColumn();
            Column_desc = new DataGridViewTextBoxColumn();
            Column_tipo = new DataGridViewTextBoxColumn();
            label_movi = new Label();
            button_adicionar = new Button();
            button_excluir = new Button();
            button_editar = new Button();
            panel_periodo.SuspendLayout();
            panel_entradas.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "FLUXO DE CAIXA";
            // 
            // panel_periodo
            // 
            panel_periodo.BackColor = SystemColors.ButtonHighlight;
            panel_periodo.BorderStyle = BorderStyle.Fixed3D;
            panel_periodo.Controls.Add(button_filtrar);
            panel_periodo.Controls.Add(label_até);
            panel_periodo.Controls.Add(dateTimePicker2);
            panel_periodo.Controls.Add(dateTimePicker1);
            panel_periodo.Controls.Add(label_periodo);
            panel_periodo.Location = new Point(94, 37);
            panel_periodo.Name = "panel_periodo";
            panel_periodo.Size = new Size(448, 38);
            panel_periodo.TabIndex = 1;
            // 
            // button_filtrar
            // 
            button_filtrar.Location = new Point(353, 9);
            button_filtrar.Name = "button_filtrar";
            button_filtrar.Size = new Size(75, 23);
            button_filtrar.TabIndex = 4;
            button_filtrar.Text = "Filtrar";
            button_filtrar.UseVisualStyleBackColor = true;
            // 
            // label_até
            // 
            label_até.AutoSize = true;
            label_até.Location = new Point(181, 11);
            label_até.Name = "label_até";
            label_até.Size = new Size(25, 15);
            label_até.TabIndex = 3;
            label_até.Text = "Até";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(215, 9);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(95, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.Off;
            dateTimePicker1.Location = new Point(77, 9);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(98, 23);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.Value = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // label_periodo
            // 
            label_periodo.AutoSize = true;
            label_periodo.Location = new Point(20, 11);
            label_periodo.Name = "label_periodo";
            label_periodo.Size = new Size(51, 15);
            label_periodo.TabIndex = 0;
            label_periodo.Text = "Período:";
            // 
            // panel_entradas
            // 
            panel_entradas.BackColor = Color.MediumSeaGreen;
            panel_entradas.BorderStyle = BorderStyle.Fixed3D;
            panel_entradas.Controls.Add(label2);
            panel_entradas.Controls.Add(label_ENTRADAS);
            panel_entradas.Location = new Point(55, 81);
            panel_entradas.Name = "panel_entradas";
            panel_entradas.Size = new Size(180, 68);
            panel_entradas.TabIndex = 2;
            // 
            // label2
            // 
            label2.CausesValidation = false;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(30, 24);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(115, 30);
            label2.TabIndex = 1;
            label2.Text = "R$: 00,00";
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // label_ENTRADAS
            // 
            label_ENTRADAS.AutoSize = true;
            label_ENTRADAS.ForeColor = SystemColors.Control;
            label_ENTRADAS.Location = new Point(59, 9);
            label_ENTRADAS.Name = "label_ENTRADAS";
            label_ENTRADAS.Size = new Size(65, 15);
            label_ENTRADAS.TabIndex = 0;
            label_ENTRADAS.Text = "ENTRADAS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label_SAIDASVALOR);
            panel1.Controls.Add(label_SAIDAS);
            panel1.Location = new Point(404, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(160, 67);
            panel1.TabIndex = 3;
            // 
            // label_SAIDASVALOR
            // 
            label_SAIDASVALOR.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_SAIDASVALOR.ForeColor = SystemColors.ButtonHighlight;
            label_SAIDASVALOR.Location = new Point(21, 24);
            label_SAIDASVALOR.Name = "label_SAIDASVALOR";
            label_SAIDASVALOR.Size = new Size(117, 37);
            label_SAIDASVALOR.TabIndex = 1;
            label_SAIDASVALOR.Text = "R$: 00,00";
            // 
            // label_SAIDAS
            // 
            label_SAIDAS.AutoSize = true;
            label_SAIDAS.ForeColor = SystemColors.Control;
            label_SAIDAS.Location = new Point(58, 9);
            label_SAIDAS.Name = "label_SAIDAS";
            label_SAIDAS.Size = new Size(46, 15);
            label_SAIDAS.TabIndex = 0;
            label_SAIDAS.Text = "SAÍDAS";
            label_SAIDAS.Click += label_SAIDAS_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column_data, Column_valor, Column_desc, Column_tipo });
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(85, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(457, 165);
            dataGridView1.TabIndex = 4;
            // 
            // Column_data
            // 
            Column_data.HeaderText = "Data";
            Column_data.Name = "Column_data";
            Column_data.Width = 90;
            // 
            // Column_valor
            // 
            Column_valor.HeaderText = "Valor";
            Column_valor.Name = "Column_valor";
            Column_valor.Width = 90;
            // 
            // Column_desc
            // 
            Column_desc.HeaderText = "Descrição";
            Column_desc.Name = "Column_desc";
            Column_desc.Width = 192;
            // 
            // Column_tipo
            // 
            Column_tipo.HeaderText = "Tipo";
            Column_tipo.Name = "Column_tipo";
            Column_tipo.Width = 83;
            // 
            // label_movi
            // 
            label_movi.AutoSize = true;
            label_movi.Location = new Point(85, 152);
            label_movi.Name = "label_movi";
            label_movi.Size = new Size(92, 15);
            label_movi.TabIndex = 5;
            label_movi.Text = "Movimentações";
            // 
            // button_adicionar
            // 
            button_adicionar.Location = new Point(481, 349);
            button_adicionar.Name = "button_adicionar";
            button_adicionar.Size = new Size(102, 23);
            button_adicionar.TabIndex = 6;
            button_adicionar.Text = "Adicionar";
            button_adicionar.UseVisualStyleBackColor = true;
            // 
            // button_excluir
            // 
            button_excluir.Location = new Point(55, 349);
            button_excluir.Name = "button_excluir";
            button_excluir.Size = new Size(101, 23);
            button_excluir.TabIndex = 7;
            button_excluir.Text = "Excluir";
            button_excluir.UseVisualStyleBackColor = true;
            // 
            // button_editar
            // 
            button_editar.Location = new Point(171, 349);
            button_editar.Name = "button_editar";
            button_editar.Size = new Size(98, 23);
            button_editar.TabIndex = 8;
            button_editar.Text = "Editar";
            button_editar.UseVisualStyleBackColor = true;
            // 
            // Form_Fluxodecaixa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(644, 384);
            Controls.Add(button_editar);
            Controls.Add(button_excluir);
            Controls.Add(button_adicionar);
            Controls.Add(label_movi);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel_entradas);
            Controls.Add(panel_periodo);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Fluxodecaixa";
            Text = "Form_Fluxodecaixa";
            panel_periodo.ResumeLayout(false);
            panel_periodo.PerformLayout();
            panel_entradas.ResumeLayout(false);
            panel_entradas.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel_periodo;
        private DateTimePicker dateTimePicker1;
        private Label label_periodo;
        private DateTimePicker dateTimePicker2;
        private Label label_até;
        private Button button_filtrar;
        private Panel panel_entradas;
        private Label label_ENTRADAS;
        private Panel panel1;
        private Label label_SAIDAS;
        private Label label2;
        private Label label_SAIDASVALOR;
        private DataGridView dataGridView1;
        private Label label_movi;
        private DataGridViewTextBoxColumn Column_data;
        private DataGridViewTextBoxColumn Column_valor;
        private DataGridViewTextBoxColumn Column_desc;
        private DataGridViewTextBoxColumn Column_tipo;
        private Button button_adicionar;
        private Button button_excluir;
        private Button button_editar;
    }
}