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
            ClientAddForm form = new ClientAddForm();
            form.ShowDialog();
        }

        private void TesteBDBtn_Click(object sender, EventArgs e)
        {
            ClienteDb clienteDb = new ClienteDb();
            clienteDb.teste();
        }
    }
}