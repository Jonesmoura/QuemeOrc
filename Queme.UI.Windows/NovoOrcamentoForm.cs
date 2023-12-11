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
using Queme.Models.DTOs;

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
            PreenchimentoDeCamposDoCliente(cliente);

        }

        public NovoOrcamentoForm(int idOrcamento)
        {
            InitializeComponent();
            ReadOrcamentoDto orcamento = OrcamentoDb.GetOrcamentoById(idOrcamento);
            PreenchimentoDeCamposDoCliente(orcamento.Cliente);
            AtualizarViewServicos(orcamento.Id);
            AtualizarViewCustosAdicionais(orcamento.Id);
            //to:do metodo para preencher informações referentes ao orçamento no form
            PreenchimentoDeDadosDoOrc(orcamento);
            AlterarCliente.Enabled = false;

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

            inclusoRadioButton.Checked = true;
            simComissaoRadioButton.Checked = true;
            simArtRadioButton.Checked = true;


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
                if (!ValidacaoDeDados.ValidacaoInputCep(CepTextBox.Text) || ComplementoTextBox.Text == string.Empty || int.Parse(numeroTextBox.Text) != 0)
                {
                    MessageBox.Show("Formato do Endereço inválido");
                    return;
                };
                int id_cliente = int.Parse(id_clienteLabel.Text);
                int idTabelaDeCustos = TabelaDePrecoDb.CapturarId(TabelaDePrecosComboBox.Text);
                Orcamento orc = new Orcamento(id_cliente, idTabelaDeCustos);
                var db = new OrcamentoDb();
                int id = db.Incluir(orc);

                orc.Endereco = EnderecoObraDb.IncluirEndereco(id, CepTextBox.Text, ComplementoTextBox.Text, int.Parse(numeroTextBox.Text));
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

            servicosDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            servicosDataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            decimal totalServicos = OrcamentoDb.TotalServicos(id_orcamento);
            totalServicosTextBox.Text = totalServicos.ToString("c", CultureInfo.CreateSpecificCulture("pt-br"));

        }

        public void PreenchimentoDeCamposDoCliente(Cliente cliente)
        {
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

        public void PreenchimentoDeDadosDoOrc(ReadOrcamentoDto orcamento)
        {
            TabelaDePrecosComboBox.Text = TabelaDePrecoDb.CapturarDesc(orcamento.IdTabelaDeCustos);
            CepTextBox.Text = orcamento.EnderecoObra.CEP;
            numeroTextBox.Text = orcamento.EnderecoObra.Numero.ToString();
            ComplementoTextBox.Text = orcamento.EnderecoObra.Complemento;
            nOrcTextBox.Text = orcamento.Id.ToString();

        }

        private void recolherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            percentImpstoMaskedTextBox.ReadOnly = true;
        }

        private void inclusoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            percentImpstoMaskedTextBox.ReadOnly = false;
        }

        private void naoComissaoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            percentComissaoMaskedTextBox.ReadOnly = true;
        }

        private void simComissaoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            percentComissaoMaskedTextBox.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriaDeCustoAdicional categoria = Enum.Parse<CategoriaDeCustoAdicional>(categoriaComboBox.Text);
            CustoAdicional custoAdicional = new CustoAdicional(int.Parse(nOrcTextBox.Text), categoria, descricaoTextBox.Text, decimal.Parse(valorUnTextBox.Text), int.Parse(qtdTextBox.Text), decimal.Parse(totalTextBox.Text));
            CustosAdicionaisDb.IncluirCustoAdicional(custoAdicional);

            AtualizarViewCustosAdicionais(custoAdicional.Id_orcamento);

        }

        private void AtualizarViewCustosAdicionais(int id_orcamento)
        {
            custosAdicionaisDataGridView.DataSource = CustosAdicionaisDb.GetCustosAdicionaisList(id_orcamento);
            custosAdicionaisDataGridView.AutoGenerateColumns = true;
            custosAdicionaisDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            custosAdicionaisDataGridView.ReadOnly = false;
            custosAdicionaisDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            custosAdicionaisDataGridView.RowHeadersVisible = false;
            custosAdicionaisDataGridView.EnableHeadersVisualStyles = false;
            custosAdicionaisDataGridView.Columns["id_orcamento"].Visible = false;
            custosAdicionaisDataGridView.Columns["ValorUN"].HeaderText = "Valor Unitário (R$)";
            custosAdicionaisDataGridView.Columns["ValorTotal"].HeaderText = "Valor Total (R$)";
            custosAdicionaisDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            custosAdicionaisDataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            decimal totalCustosAdicionais = OrcamentoDb.TotalCustosAdicionais(id_orcamento);
            totalCustosAdicionaisTextBox.Text = totalCustosAdicionais.ToString("c", CultureInfo.CreateSpecificCulture("pt-br"));
        }

        private void valorTotalEtapaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void qtdTextBox_TextChanged(object sender, EventArgs e)
        {

            if (qtdTextBox.Text != string.Empty)
            {
                decimal totalCustoAdicional = Convert.ToInt32(qtdTextBox.Text) * Convert.ToDecimal(valorUnTextBox.Text);
                totalTextBox.Text = totalCustoAdicional.ToString("F2", CultureInfo.InvariantCulture);
            }
        }
    }
}
