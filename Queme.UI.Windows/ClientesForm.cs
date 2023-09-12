using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using Queme.Db;
using Queme.Models;


namespace Queme.UI.Windows
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void ExibirGrid()
        {
            listaDataGridView.Visible = true;
            listaDataGridView.Dock = DockStyle.Fill;
            FichaPanel.Visible = false;
            NovoButton.Visible = true;
            AlterarButton.Visible = true;
            ExcluirButton.Visible = true;
            SairButton.Visible = true;
            confirmarAlterarButton.Visible = false;
            ConfirmarExcluirButton.Visible = false;
            ConfirmarInclusaoButton.Visible = false;
            VoltarButton.Visible = false;

            var db = new Queme.Db.ClienteDb();
            listaDataGridView.DataSource = db.Listar();
            listaDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listaDataGridView.ReadOnly = false;
            listaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            listaDataGridView.RowHeadersVisible = false;
            listaDataGridView.EnableHeadersVisualStyles = false;
            listaDataGridView.Columns["ID"].Width = 50;

        }

        private void ExibirFicha()
        {
            FichaPanel.Visible = true;
            FichaPanel.Dock = DockStyle.Fill;
            listaDataGridView.Visible = false;
            NovoButton.Visible = false;
            AlterarButton.Visible = false;
            ExcluirButton.Visible = false;
            SairButton.Visible = false;
            confirmarAlterarButton.Visible = false;
            ConfirmarExcluirButton.Visible = false;
            ConfirmarInclusaoButton.Visible = true;
            VoltarButton.Visible = true;


        }

        private void LimparFicha()
        {

            IDtextBox.Clear();
            NameTextBox.Clear();
            EmailTextBox.Clear();
            TelTextBox.Clear();

            IDtextBox.Focus();

        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void NovoButton_Click(object sender, EventArgs e)
        {
            ExibirFicha();
            confirmarAlterarButton.Visible = false;
            ConfirmarExcluirButton.Visible = false;
            ConfirmarInclusaoButton.Visible = true;
            LimparFicha();
        }

        private void VoltarButton_Click(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void ConfirmarInclusaoButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();

            cliente.ID = int.Parse(IDtextBox.Text);
            cliente.Name = NameTextBox.Text;
            cliente.Email = EmailTextBox.Text;
            cliente.Tel = TelTextBox.Text;

            var db = new ClienteDb();
            db.Incluir(cliente);

            ExibirGrid();

        }

        private void AlterarButton_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)listaDataGridView.CurrentRow.DataBoundItem;
            IDtextBox.Text = cliente.ID.ToString();
            NameTextBox.Text = cliente.Name.ToString();
            EmailTextBox.Text = cliente.Email.ToString();
            TelTextBox.Text = cliente.Tel.ToString();
            ExibirFicha();

            confirmarAlterarButton.Visible = true;
            ConfirmarExcluirButton.Visible = false;
            ConfirmarInclusaoButton.Visible = false;
        }

        private void confirmarAlterarButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();

            cliente.ID = int.Parse(IDtextBox.Text);
            cliente.Name = NameTextBox.Text;
            cliente.Email = EmailTextBox.Text;
            cliente.Tel = TelTextBox.Text;

            var db = new ClienteDb();
            db.Alterar(cliente);

            ExibirGrid();
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)listaDataGridView.CurrentRow.DataBoundItem;
            IDtextBox.Text = cliente.ID.ToString();
            NameTextBox.Text = cliente.Name.ToString();
            EmailTextBox.Text = cliente.Email.ToString();
            TelTextBox.Text = cliente.Tel.ToString();
            ExibirFicha();

            confirmarAlterarButton.Visible = false;
            ConfirmarExcluirButton.Visible = true;
            ConfirmarInclusaoButton.Visible = false;
        }

        private void ConfirmarExcluirButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();

            cliente.ID = int.Parse(IDtextBox.Text);
            cliente.Name = NameTextBox.Text;
            cliente.Email = EmailTextBox.Text;
            cliente.Tel = TelTextBox.Text;

            var db = new ClienteDb();
            db.Excluir(cliente.ID);

            ExibirGrid();
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
