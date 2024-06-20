using Queme.Db;
using Queme.Models;
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

namespace Queme.UI.Windows
{
    public partial class BuscaClienteForm : Form
    {
        public BuscaClienteForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PFRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BuscaNomePanel.Visible = true;
            BuscaRazaoPanel.Visible = false;
            RazaoTextBox.Text = "";
        }

        private void PJRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BuscaNomePanel.Visible = false;
            BuscaRazaoPanel.Visible = true;
            NomeTextBox.Text = "";
        }

        private void BuscaClienteForm_Load(object sender, EventArgs e)
        {
            PJRadioButton.Checked = true;
        }

        private void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            var db = new Queme.Db.ClienteDb();
            bool pfChecked = PFRadioButton.Checked;

            ClientesEncontradosDataGridView.DataSource = db.BuscarClientesOrc(RazaoTextBox.Text, NomeTextBox.Text, pfChecked);
            ClientesEncontradosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ClientesEncontradosDataGridView.ReadOnly = false;
            ClientesEncontradosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ClientesEncontradosDataGridView.RowHeadersVisible = false;
            ClientesEncontradosDataGridView.EnableHeadersVisualStyles = false;
            ClientesEncontradosDataGridView.Columns["ID"].Width = 20;

            ClientesEncontradosDataGridView.Columns["Complemento"].Visible = false;
            ClientesEncontradosDataGridView.Columns["CEP"].Visible = false;
            ClientesEncontradosDataGridView.Columns["Numero"].Visible = false;
            ClientesEncontradosDataGridView.Columns["Bairro"].Visible = false;
            ClientesEncontradosDataGridView.Columns["Logradouro"].Visible = false;
            ClientesEncontradosDataGridView.Columns["UF"].Visible = false;
            ClientesEncontradosDataGridView.Columns["localidade"].Visible = false;

            if (!pfChecked)
            {
                ClientesEncontradosDataGridView.Columns["CPF"].Visible = false;
                ClientesEncontradosDataGridView.Columns["CNPJ"].Visible = true;
                ClientesEncontradosDataGridView.Columns["razaoSocial"].Visible = true;

            }
            else
            {
                ClientesEncontradosDataGridView.Columns["razaoSocial"].Visible = false;
                ClientesEncontradosDataGridView.Columns["CNPJ"].Visible = false;
                ClientesEncontradosDataGridView.Columns["CPF"].Visible = true;
            }
        }

        private void ClientesEncontradosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelecionarClienteButton_Click(object sender, EventArgs e)
        {
            var db = new ClienteDb();

            int id = int.Parse(ClientesEncontradosDataGridView.SelectedRows[0].Cells["ID"].Value.ToString());

            Cliente cliente = db.buscarInfoCliente(id);

            if (cliente.ID == 0)
            {
                MessageBox.Show("Cliente não encontrado");
            }
            else
            {
                Close();
                Form orcamentoForm = Application.OpenForms["NovoOrcamentoForm"];

                if (orcamentoForm != null)
                {
                    // testar, caso funcionar alterar os demais dados do formulário
                    NovoOrcamentoForm formAberto = (NovoOrcamentoForm)orcamentoForm;
                    Panel clientePanel = formAberto.Controls["ConteudoOrcPanel"].Controls["ClientePanel"].Controls["InfoClienteFlowLayoutPanel"] as Panel;

                    clientePanel.Controls["NomePanel"].Controls["NomeTextBox"].Text = cliente.Name.ToString();
                    clientePanel.Controls["EmailPanel"].Controls["EmailTextBox"].Text = cliente.Email.ToString();
                    clientePanel.Controls["TelPanel"].Controls["TelTextBox"].Text = cliente.Tel.ToString();

                    if (cliente.CNPJ != "")
                    {

                        clientePanel.Controls["CnpjPanel"].Controls["CnpjTextBox"].Text = cliente.CNPJ.ToString();
                        clientePanel.Controls["RazaoPanel"].Controls["RazaoTextBox"].Text = cliente.razaoSocial.ToString();
                        clientePanel.Controls["CnpjPanel"].Visible = true;
                        clientePanel.Controls["RazaoPanel"].Visible = true;
                        clientePanel.Controls["CpfPanel"].Visible = false;

                    }
                    else if (cliente.CPF != "")
                    {
                        clientePanel.Controls["CpfPanel"].Controls["CpfTextBox"].Text = cliente.CPF.ToString();
                        clientePanel.Controls["CnpjPanel"].Visible = false;
                        clientePanel.Controls["RazaoPanel"].Visible = false;
                        clientePanel.Controls["CpfPanel"].Visible = true;

                    }
                }
                else
                {
                    var novoOrcamentoForm = new NovoOrcamentoForm(cliente);
                    novoOrcamentoForm.ShowDialog();

                }

            }

        }

        public static void AlterarClienteOrc()
        {
            var buscarClienteForm = new BuscaClienteForm();

            buscarClienteForm.ShowDialog();

        }

    }
}
