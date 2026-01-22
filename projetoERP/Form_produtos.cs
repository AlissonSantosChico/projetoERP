using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoERP
{
    public partial class Form_produtos : Form
    {
        public Form_produtos()
        {
            InitializeComponent();
        }

        private void Form_produtos_Load(object sender, EventArgs e)
        {

            {
                dataGridView1.Rows.Add("001", "TV LG 32 polegadas", "599,90", "20");
                dataGridView1.Rows.Add("002", "Teclado mecânico CLANH", "89,90", "15");
                dataGridView1.Rows.Add("003", "Notebook Dell inspiron 15", "899,90", "5");

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void button_salvarprodutos_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios!");
                return;
            }
            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button_editarprodutos_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um fornecedor para editar!");
                return;
            }
            dataGridView1.CurrentRow.Cells[0].Value = textBox1.Text;
            dataGridView1.CurrentRow.Cells[1].Value = textBox2.Text;
            dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
            dataGridView1.CurrentRow.Cells[3].Value = textBox4.Text;

            MessageBox.Show("Dados atualizados com sucesso!");
        }

        private void button_excluirprodutos_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um fornecedor para excluir!");
                return;
            }

            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resp == DialogResult.Yes)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);


                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }
    }
}
