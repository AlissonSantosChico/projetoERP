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
    public partial class Form_contasAReceber : Form
    {
        public Form_contasAReceber()
        {
            InitializeComponent();
        }

        private void Form_contasAReceber_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Rissul", "Mercado caro", "5000", "14/05/2026", "Em Processo");
            dataGridView1.Rows.Add("Senac", "Cursos legais", "4990", "15/02/2024", "Processo feito");
            dataGridView1.Rows.Add("Pastelaria do jorge", "Pasteis gostosos", "9991", "09/12/2030", "Em Processo");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
