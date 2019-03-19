using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema1
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome, cidade, telefone;

            nome = txtNomeCliente.Text;
            cidade = cbxCidade.Items[cbxCidade.SelectedIndex].ToString();
            telefone = mtxtTelefone.Text;
            SalvarCliente(nome, telefone, cidade);
            LimparCliente();
        }
        private void SalvarCliente(string nome, string telefone, string cidade)
        {
            StreamWriter arquivo;
            arquivo = File.AppendText("");
            arquivo.WriteLine();
            arquivo.WriteLine("Cadastro de Cliente");
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("Telefone: " + telefone);
            arquivo.WriteLine("Cidade: " + cidade);
            arquivo.WriteLine("--------------------");
            arquivo.WriteLine();
            arquivo.Close();
            MessageBox.Show("Cliente salvo com sucesso", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LimparCliente()
        {
            txtNomeCliente.Clear();
            mtxtTelefone.Clear();
            cbxCidade.SelectedIndex = -1;
        }
    }
}
