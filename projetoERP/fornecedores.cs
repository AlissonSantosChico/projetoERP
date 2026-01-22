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
    public partial class fornecedores : Form
    {
        public fornecedores()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void fornecedores_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Rissul", "120.345.678/0001-90", "Rissulsu@Gmail.com", "123456789");
            dataGridView1.Rows.Add("Senac", "876.543.128/0002-89", "Senacrs@gmail.com", "987654321");
            dataGridView1.Rows.Add("Pastelaria do jorge", "321.654.981/0020-89", "Pasteltotoso@gmail.com", "147258369");
        }

        private void button_SalvarFornecedor_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios!");
                return;
            }
            dataGridView1.Rows.Add(textBox4.Text, textBox1.Text, textBox3.Text, textBox2.Text);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button_editarFornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um fornecedor para editar!");
                return;
            }
            dataGridView1.CurrentRow.Cells[0].Value = textBox4.Text;
            dataGridView1.CurrentRow.Cells[1].Value = textBox1.Text;
            dataGridView1.CurrentRow.Cells[2].Value = textBox3.Text;
            dataGridView1.CurrentRow.Cells[3].Value = textBox2.Text;

            MessageBox.Show("Dados atualizados com sucesso!");
        }

        private void button_excluir_fornecedor_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um fornecedor para excluir!");
                return;
            }

            DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir este fornecedor?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           
            if (resp == DialogResult.Yes)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

             
                textBox4.Clear();
                textBox1.Clear();
                textBox3.Clear();
                textBox2.Clear();
            }
        }
    }
}
