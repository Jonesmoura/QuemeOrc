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
            if(nOrcTextBox.Text == string.Empty)
            {
                Orcamento orc = new Orcamento();
                var db = new OrcamentoDb();
                int id = db.Incluir(orc);
                nOrcTextBox.Text = id.ToString();   
            }
            ServicosDb servicoDb = new ServicosDb();
            //to:do método de incluir serviços 
            //servicoDb.incluirServico();
        }
    }
}
