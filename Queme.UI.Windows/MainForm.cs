using Queme.Db;

namespace Queme.UI.Windows
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ClientesForm();
            form.ShowDialog();
        }

        private void novoOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Inicialização do form de orçamento será realizada após a seleção do cliente, no método de selecionar cliente
            //var form = new NovoOrcamentoForm();
            //form.ShowDialog();
            var formBuscaCliente = new BuscaClienteForm();
            formBuscaCliente.ShowDialog();
        }
    }
}
