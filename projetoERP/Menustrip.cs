namespace projetoERP
{
    public partial class Menustrip : Form
    {
        public Menustrip()
        {
            InitializeComponent();
        }

        private void Menustrip_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            teste frm = new teste();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_produtos frm = new Form_produtos();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fornecedores frm = new fornecedores();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_contas_a_pagar frm = new Form_contas_a_pagar();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_contasAReceber frm = new Form_contasAReceber();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void fluxoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Fluxodecaixa frm = new Form_Fluxodecaixa();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void consiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_consiliação frm = new Form_consiliação();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void Formhome(object sender, EventArgs e)
        {
            Formhome home = new Formhome();
            home.MdiParent = this;
            home.Dock = DockStyle.Fill;
            home.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Está imprimindo");
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Pagina está carregando");
        }
    }
}
