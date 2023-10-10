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

        private void novoOr�amentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Inicializa��o do form de or�amento ser� realizada ap�s a sele��o do cliente, no m�todo de selecionar cliente
            //var form = new NovoOrcamentoForm();
            //form.ShowDialog();
            var formBuscaCliente = new BuscaClienteForm();
            formBuscaCliente.ShowDialog();
        }
    }
}
