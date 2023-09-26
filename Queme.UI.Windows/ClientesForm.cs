using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI;
using Queme.Db;
using Queme.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;
using Newtonsoft.Json;

namespace Queme.UI.Windows
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        private bool isEmail(string email)
        {
            string emailRegEx = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailRegEx);

        }

        private bool isCnpj(string cnpj)
        {
            string cnpjRegEx = @"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$";
            return Regex.IsMatch(cnpj, cnpjRegEx);
        }

        private bool isCpf(string cpf)
        {
            string cpfRegEx = @"^\d{3}\.\d{3}\.\d{3}-\d{2}$";
            return Regex.IsMatch(cpf, cpfRegEx);
        }

        private bool VerificaDadosNovoCliente(Cliente cliente)
        {
            if (PFradioButton.Checked == true)
            {
                // logica para verificação de dados PF
                if (!isEmail(cliente.Email))
                {
                    MessageBox.Show("E-mail inválido.");
                    return false;
                }
                // caso necessário, implementar outras validações
                return true;
            }
            else
            {
                // logica para verificação de dados PJ

                if (!isEmail(cliente.Email))
                {
                    MessageBox.Show("E-mail inválido.");
                    return false;
                }
                // caso necessário, implementar outras validações
                return true;
            }
        }

        private void ExibirGrid()
        {
            this.Width = 1173;
            this.Height = 489;
            this.CenterToScreen();

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

            listaDataGridView.Columns["Complemento"].Visible = false;
            listaDataGridView.Columns["CEP"].Visible = false;
            listaDataGridView.Columns["Numero"].Visible = false;
            listaDataGridView.Columns["Bairro"].Visible = false;
            listaDataGridView.Columns["Logradouro"].Visible = false;
            listaDataGridView.Columns["UF"].Visible = false;
            listaDataGridView.Columns["localidade"].Visible = false;

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
            PFradioButton.Visible = false;
            PJradioButton.Visible = false;
            flowLayoutPanel3.Visible = true;
            TelPanel.Visible = true;
            NameTextBox.Focus();

        }

        private void LimparFicha()
        {

            IDtextBox.Clear();
            NameTextBox.Clear();
            EmailTextBox.Clear();
            TelTextBox.Clear();
            CNPJtextBox.Clear();
            CPFtextBox.Clear();
            RazaoSocialTextBox.Clear();
            CEPTextBox.Clear();
            logradouroTextBox.Clear();
            bairroTextBox.Clear();
            cidadeTextBox.Clear();
            numeroTextBox.Clear();
            UFTextBox.Clear();
            complementoTextBox.Clear();


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
            PFradioButton.Visible = true;
            PJradioButton.Visible = true;
            LimparFicha();
            IDPanel.Visible = false;
            PJradioButton.Checked = true;

        }

        private void VoltarButton_Click(object sender, EventArgs e)
        {
            ExibirGrid();
        }

        private void ConfirmarInclusaoButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();
            string cnpj = CNPJtextBox.Text;
            string cpf = CPFtextBox.Text;

            // to-do: função com regex para verificação do cnpj, caso esteja ok, o CPF será null, caso false o proprio cnpj será null

            if (PJradioButton.Checked == true && !isCnpj(cnpj))
            {
                MessageBox.Show("CNPJ inválido");

            }
            else if (PFradioButton.Checked == true && !isCpf(cpf))
            {
                MessageBox.Show("CPF inválido");
            }
            else
            {
                if (isCnpj(cnpj))
                {
                    cliente.CNPJ = cnpj;
                    cliente.razaoSocial = RazaoSocialTextBox.Text;
                    cliente.CPF = null;
                }
                else if (isCpf(cpf))
                {
                    cliente.razaoSocial = null;
                    cliente.CNPJ = null;
                    cliente.CPF = cpf;
                }

                cliente.Name = NameTextBox.Text;
                cliente.Email = EmailTextBox.Text;
                cliente.Tel = TelTextBox.Text;
                cliente.CEP = CEPTextBox.Text;
                cliente.Bairro = bairroTextBox.Text;
                cliente.Numero = int.Parse(numeroTextBox.Text);
                cliente.Logradouro = logradouroTextBox.Text;
                cliente.localidade = cidadeTextBox.Text;
                cliente.UF = UFTextBox.Text;
                cliente.Complemento = complementoTextBox.Text;

                if (VerificaDadosNovoCliente(cliente))
                {
                    var db = new ClienteDb();
                    db.Incluir(cliente);
                    ExibirGrid();
                };
            }

        }

        private void AlterarButton_Click(object sender, EventArgs e)
        {
            var db = new ClienteDb();

            int id = int.Parse(listaDataGridView.SelectedRows[0].Cells["ID"].Value.ToString());


            var cliente = db.buscarInfoCliente(id);

            IDtextBox.Text = cliente.ID.ToString();
            NameTextBox.Text = cliente.Name.ToString();
            RazaoSocialTextBox.Text = cliente.razaoSocial.ToString();
            CNPJtextBox.Text = cliente.CNPJ.ToString();
            CPFtextBox.Text = cliente.CPF.ToString();
            EmailTextBox.Text = cliente.Email.ToString();
            TelTextBox.Text = cliente.Tel.ToString();
            CEPTextBox.Text = cliente.CEP.ToString();
            logradouroTextBox.Text = cliente.Logradouro.ToString();
            bairroTextBox.Text = cliente.Bairro.ToString();
            cidadeTextBox.Text = cliente.localidade.ToString();
            UFTextBox.Text = cliente.UF.ToString();
            numeroTextBox.Text = cliente.Numero.ToString();
            complementoTextBox.Text = cliente.Complemento.ToString();

            ExibirFicha();

            //Teste layout alterar.

            if (isCpf(CPFtextBox.Text))
            {
                CPFPanel.Visible = true;
                CNPJPanel.Visible = false;
                RazaoSocialPanel.Visible = false;
            }
            else
            {
                CPFPanel.Visible = false;
                CNPJPanel.Visible = true;
                RazaoSocialPanel.Visible = true;
            }

            char[] tel = (TelTextBox.Text).ToCharArray();

            if (tel[2] != char.Parse("9"))
            {
                TelradioButton.Checked = true;
                TelTextBox.Text = cliente.Tel.ToString();

            }
            else
            {
                CelRadioButton.Checked = true;
                TelTextBox.Text = cliente.Tel.ToString();

            }
            IDPanel.Visible = true;
            confirmarAlterarButton.Visible = true;
            ConfirmarExcluirButton.Visible = false;
            ConfirmarInclusaoButton.Visible = false;
            PFradioButton.Visible = false;
            PJradioButton.Visible = false;
        }

        private void confirmarAlterarButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();

            cliente.ID = int.Parse(IDtextBox.Text);
            cliente.Name = NameTextBox.Text;
            cliente.Email = EmailTextBox.Text;
            cliente.Tel = TelTextBox.Text;
            cliente.razaoSocial = RazaoSocialTextBox.Text;
            cliente.CNPJ = CNPJtextBox.Text;
            cliente.CPF = CPFtextBox.Text;
            cliente.Logradouro = logradouroTextBox.Text;
            cliente.Bairro = bairroTextBox.Text;
            cliente.Numero = int.Parse(numeroTextBox.Text);
            cliente.UF = UFTextBox.Text;
            cliente.CEP = CEPTextBox.Text;
            cliente.localidade = cidadeTextBox.Text;
            cliente.Complemento = complementoTextBox.Text;

            var db = new ClienteDb();
            db.Alterar(cliente);

            ExibirGrid();
        }

        private void ExcluirButton_Click(object sender, EventArgs e)
        {
            this.Width = 500;
            this.Height = 489;
            this.CenterToScreen();

            var cliente = (Cliente)listaDataGridView.CurrentRow.DataBoundItem;
            IDtextBox.Text = cliente.ID.ToString();
            NameTextBox.Text = cliente.Name.ToString();
            RazaoSocialTextBox.Text = cliente.razaoSocial.ToString();
            CNPJtextBox.Text = cliente.CNPJ.ToString();
            CPFtextBox.Text = cliente.CPF.ToString();
            EmailTextBox.Text = cliente.Email.ToString();
            TelTextBox.Text = cliente.Tel.ToString();
            ExibirFicha();

            IDPanel.Visible = true;
            confirmarAlterarButton.Visible = false;
            ConfirmarExcluirButton.Visible = true;
            ConfirmarInclusaoButton.Visible = false;
            PFradioButton.Visible = false;
            PJradioButton.Visible = false;
            flowLayoutPanel3.Visible = false;
            TelPanel.Visible = false;

            if(cliente.CPF  != "")
            {
                CPFPanel.Visible = true;
                CNPJPanel.Visible = false;
                RazaoSocialPanel.Visible = false;
            }
            else
            {
                CPFPanel.Visible = false;
                CNPJPanel.Visible = true;
                RazaoSocialPanel.Visible = true;

            }
        }

        private void ConfirmarExcluirButton_Click(object sender, EventArgs e)
        {
            var cliente = new Cliente();

            cliente.ID = int.Parse(IDtextBox.Text);
            cliente.Name = NameTextBox.Text;
            cliente.Email = EmailTextBox.Text;
            cliente.Tel = TelTextBox.Text;
            cliente.razaoSocial = RazaoSocialTextBox.Text;
            cliente.CNPJ = CNPJtextBox.Text;
            cliente.CPF = CPFtextBox.Text;

            var db = new ClienteDb();
            db.Excluir(cliente.ID);

            ExibirGrid();
        }

        private void SairButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PJradioButton_CheckedChanged(object sender, EventArgs e)
        {

            ExibirFicha();
            confirmarAlterarButton.Visible = false;
            ConfirmarExcluirButton.Visible = false;
            ConfirmarInclusaoButton.Visible = true;
            CNPJPanel.Visible = true;
            CPFPanel.Visible = false;
            RazaoSocialPanel.Visible = true;
            PFradioButton.Visible = true;
            PJradioButton.Visible = true;

        }

        private void PFradioButton_CheckedChanged(object sender, EventArgs e)
        {

            ExibirFicha();
            confirmarAlterarButton.Visible = false;
            ConfirmarExcluirButton.Visible = false;
            ConfirmarInclusaoButton.Visible = true;
            CNPJPanel.Visible = false;
            CPFPanel.Visible = true;
            RazaoSocialPanel.Visible = false;
            PFradioButton.Visible = true;
            PJradioButton.Visible = true;

        }

        private void RazaoSocialTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RazaoSocialTextBox_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void CNPJtextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void TelTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void CPFtextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void listaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CNPJtextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private async void CEPTextBox_TextChanged(object sender, EventArgs e)
        {
            string cep = CEPTextBox.Text.ToString();
            DadosViaCEP dados = await VerificaCEP(cep);

            if (dados != null && dados.Logradouro != null)
            {
                logradouroTextBox.Text = dados.Logradouro.ToString();
                bairroTextBox.Text = dados.Bairro.ToString();
                cidadeTextBox.Text = dados.Localidade.ToString();
                UFTextBox.Text = dados.UF.ToString();
            }
        }

        static async Task<DadosViaCEP> VerificaCEP(string CEP)
        {
            string url = "https://viacep.com.br/ws/" + CEP + "/json/";

            try
            {
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    DadosViaCEP dadosViaCEP = JsonConvert.DeserializeObject<DadosViaCEP>(json);
                    return dadosViaCEP;

                }
                else
                {
                    throw new Exception("Erro ao buscar CEP");
                }

            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public class DadosViaCEP
        {
            public string Cep { get; set; }
            public string Logradouro { get; set; }
            public string Bairro { get; set; }
            public string Localidade { get; set; }
            public string UF { get; set; }
        }

        private void TelTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            TelTextBox.Mask = "(00) 00000-0000";
        }

        private void TelradioButton_CheckedChanged(object sender, EventArgs e)
        {
            TelTextBox.Mask = "(00) 0000-0000";
        }
    }
}
