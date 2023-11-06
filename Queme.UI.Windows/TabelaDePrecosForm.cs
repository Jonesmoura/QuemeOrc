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
using MySql.Data.MySqlClient;
using Queme.Db;
using Queme.Models;
using Queme.Models.Enums;

namespace Queme.UI.Windows
{
    public partial class TabelaDePrecosForm : Form
    {
        public TabelaDePrecosForm()
        {
            InitializeComponent();
        }

        private void CadastrarTabelaButton_Click(object sender, EventArgs e)
        {
            var tabelaDePreco = new TabelaDePreco();
            Dictionary<TipoServico, double> custos = new Dictionary<TipoServico, double>();
            tabelaDePreco.DescricaoTabela = descricaoTabelaTextBox.Text;
            tabelaDePreco.ObsDaTabela = ObsTabelaTextBox.Text;

            var dbTabela = new TabelaDePrecoDb();
            try
            {
                dbTabela.Incluir(tabelaDePreco);

            }catch(MySqlException ex)
            {
                MessageBox.Show("Erro ao gravar tabela de preço no banco de dados: " + ex.Message);
                return;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            custos[TipoServico.Consultoria] = double.Parse(consultoriaValorTextBox.Text);
            custos[TipoServico.Estrutural] = double.Parse(estruturalValorTextBox.Text);
            custos[TipoServico.Arquitetura] = double.Parse(arquiteturaValorTextBox.Text);
            custos[TipoServico.Elétrico] = double.Parse(eletricoValorTextBox.Text);
            custos[TipoServico.HVAC] = double.Parse(hvacValorTextBox.Text);
            custos[TipoServico.Hidrossanitário] = double.Parse(hidroValorTextBox.Text);
            //to-do: try catch do metodo Incluir Custos
            try
            {
                CustoPorTipoDb.IncluirCustos(tabelaDePreco, custos);

            }catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar custos. "+ ex.Message);
                return;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void consultoriaValorTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void TxtKeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar.Equals((char)Keys.Back))
            {
                TextBox t = (TextBox)sender;
                string w = Regex.Replace(t.Text, "[^0-9]", string.Empty);
                if (w == string.Empty) w = "00";

                if (e.KeyChar.Equals((char)Keys.Back))
                {
                    w = w.Substring(0, w.Length - 1);
                }
                else
                {
                    w += e.KeyChar;
                }


                t.Text = string.Format("{0:#,##0.00}", Double.Parse(w) / 100);
                t.Select(t.Text.Length, 0);
            }
            e.Handled = true;
        }

        private void TabelaDePrecosForm_Load(object sender, EventArgs e)
        {

        }

        private void consultoriaValorTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
