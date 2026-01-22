using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace projetoERP
{
    public partial class teste : Form
    {
        public teste()
        {
            InitializeComponent();
        }

        private void form_clientes_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Fialho", "12345678900", "Fialhodjabo@gmail.com", "22/07/2009");
            dataGridView1.Rows.Add("Wesley", "00987654321", "Wesley123321@gmail.com", "08/12/2007");
            dataGridView1.Rows.Add("Arthur", "32165498700", "Arthurgugu22@gmail.com", "06/10/2000");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios!");
                return;
            }
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Text);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1 = null;
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente para editar!");
                return;
            }
            dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
            dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
            dataGridView1.CurrentRow.Cells[3].Value = dateTimePicker1.Text;

            MessageBox.Show("Dados atualizados com sucesso!");
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um cliente para excluir!");
                return;
            }

            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resp == DialogResult.Yes)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                dataGridView1 = null;
            }
        }
    }
}
