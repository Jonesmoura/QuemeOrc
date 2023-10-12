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

        }

        private void NomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
