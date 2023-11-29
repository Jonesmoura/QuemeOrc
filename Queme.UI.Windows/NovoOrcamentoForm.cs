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
using System.Globalization;
using Queme.Models.Enums;

namespace Queme.UI.Windows
{
    public partial class NovoOrcamentoForm : Form
    {
        public NovoOrcamentoForm()
        {
            InitializeComponent();
        }
        public NovoOrcamentoForm(Cliente cliente)
        {
            InitializeComponent();
            // Teste transferencia de dados do form de busca para o form de orçamentos
            NomeTextBox.Text = cliente.Name.ToString();
            EmailTextBox.Text = cliente.Email.ToString();
            TelTextBox.Text = cliente.Tel.ToString();
            id_clienteLabel.Text = cliente.ID.ToString();
            id_clienteLabel.Visible = false;

            if (cliente.CNPJ != "")
            {
                RazaoTextBox.Text = cliente.razaoSocial.ToString();
                CnpjTextBox.Text = cliente.CNPJ.ToString();
                CnpjPanel.Visible = true;
                RazaoPanel.Visible = true;
                CpfPanel.Visible = false;
            }
            else if (cliente.CPF != "")
            {
                CpfTextBox.Text = cliente.CPF.ToString();
                CnpjPanel.Visible = false;
                RazaoPanel.Visible = false;
                CpfPanel.Visible = true;

            }


        }

        public NovoOrcamentoForm(Cliente cliente, Orcamento orcamento)
        {
            InitializeComponent();
            //to:do método preenchimento do orçamento e cliente
        }

        private void NovoOrcamentoForm_Load(object sender, EventArgs e)
        {
            // carregar tabelas de preços
            TabelaDePrecosComboBox.Items.Clear();
            List<string> tabelas = TabelaDePrecoDb.getTabelas();
            foreach (string tabela in tabelas)
            {
                TabelaDePrecosComboBox.Items.Add(tabela);
            }

        }

        private void NomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlterarCliente_Click(object sender, EventArgs e)
        {
            BuscaClienteForm.AlterarClienteOrc();

        }

        private void TabelaDePrecosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabelaDePrecosComboBox_SelectedIndexChanged(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // método para consultar valor na tabela de PrecosPorDisciplina
            custoPorHoraTextBox.Text = CustoPorTipoDb.getValorEtapa(TabelaDePrecosComboBox.Text, disciplinaComboBox.Text).ToString();
        }

        private void estimativaHorasTextBox_TextChanged(object sender, EventArgs e)
        {
            //método para calcular total do serviço
            if (estimativaHorasTextBox.Text != string.Empty)
            {
                double totalEtapa = Convert.ToDouble(estimativaHorasTextBox.Text) * Convert.ToDouble(custoPorHoraTextBox.Text);
                valorTotalEtapaTextBox.Text = totalEtapa.ToString("F2", CultureInfo.InvariantCulture);
            }
        }

        private void adicionarServicoButton_Click(object sender, EventArgs e)
        {
            if (nOrcTextBox.Text == string.Empty)
            {
                int id_cliente = int.Parse(id_clienteLabel.Text);
                Orcamento orc = new Orcamento(id_cliente);
                var db = new OrcamentoDb();
                int id = db.Incluir(orc);
                nOrcTextBox.Text = id.ToString();
            }
            ServicosDb servicoDb = new ServicosDb();
            Servico servico = new Servico();
            servico.Id_orcamento = int.Parse(nOrcTextBox.Text);
            servico.Etapa = Enum.Parse<EtapasServico>(etapaComboBox.Text);
            servico.TipoServico = Enum.Parse<TipoServico>(disciplinaComboBox.Text);
            servico.Qtd_horas = int.Parse(estimativaHorasTextBox.Text);
            servico.ValorHora = double.Parse(custoPorHoraTextBox.Text, CultureInfo.InvariantCulture);
            servico.TotalServico = double.Parse(valorTotalEtapaTextBox.Text, CultureInfo.InvariantCulture);
            servicoDb.IncluirServico(servico);

            // atualizar dataGridView a cada inserção

            AtualizarViewServicos(servico.Id_orcamento);
        }

        public void AtualizarViewServicos(int id_orcamento)
        {
            ServicosDb servicoDb = new ServicosDb();
            servicosDataGridView.DataSource = servicoDb.GetServicoList(id_orcamento);
            servicosDataGridView.AutoGenerateColumns = true;
            servicosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            servicosDataGridView.ReadOnly = false;
            servicosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            servicosDataGridView.RowHeadersVisible = false;
            servicosDataGridView.EnableHeadersVisualStyles = false;
            servicosDataGridView.Columns["id_orcamento"].Visible = false;

            servicosDataGridView.Columns["TipoServico"].HeaderText = "Disciplina";
            servicosDataGridView.Columns["Qtd_horas"].HeaderText = "Quantidade Horas";
            servicosDataGridView.Columns["ValorHora"].HeaderText = "Valor/Hora (R$)";
            servicosDataGridView.Columns["TotalServico"].HeaderText = "Valor Total (R$)";

        }
    }
}
