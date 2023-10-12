﻿using Queme.Db;
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
            ClientesEncontradosDataGridView.DataSource = db.BuscarClientesOrc(RazaoTextBox.Text, NomeTextBox.Text);
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

            if (NomeTextBox.Text == "")
            {
                ClientesEncontradosDataGridView.Columns["CPF"].Visible = false;
                ClientesEncontradosDataGridView.Columns["CNPJ"].Visible = true;
                ClientesEncontradosDataGridView.Columns["razaoSocial"].Visible = true;

            }
            else if (RazaoTextBox.Text == "")
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
                var orcamentoForm = new NovoOrcamentoForm(cliente);
                orcamentoForm.ShowDialog();
            }
            
        }
    }
}