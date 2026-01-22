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
    public partial class Form_contas_a_pagar : Form
    {
        public Form_contas_a_pagar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
            }
        }

        private void Form_contas_a_pagar_Load(object sender, EventArgs e)
        {
            {
                dataGridView1.Rows.Add("Fialho", "Tem cabeo de malqueiro", "1425", "20/12/25", "A Apargar");
                dataGridView1.Rows.Add("Wesley", "Indio da Empresa", "1424", "15 / 10 / 25", "Pago");
                dataGridView1.Rows.Add("Arthur", "Rico", "1426", "15 / 11 / 25", "Pago");
            }
        }
    }
}
