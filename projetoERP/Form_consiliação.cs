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
    public partial class Form_consiliação : Form
    {
        public Form_consiliação()
        {
            InitializeComponent();
        }

        private void Form_consiliação_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("12/10/2025", "Gabriel Souza", "Boleto", "Banrisul", "Pago");
            dataGridView1.Rows.Add("05/03/2026", "Vinicius de Mello", "Cartão", "Nubank", "Em aberto");
            dataGridView1.Rows.Add("06/05/2026", "Jorge Santos", "Dinheiro", "Caixa", "Em aberto");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
