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
    public partial class CadastroDeFuncionarios : Form
    {
        public CadastroDeFuncionarios()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome, estadoCivil;
            nome = txtNomeFuncionario.Text;

            if(rbtnCasado.Checked == true)
            {
                estadoCivil = "casado(a)";
            }else if(rbtnSolteiro.Checked == true)
            {
                estadoCivil = "Solteiro(a)";
            }
            else
            {
                MessageBox.Show("escolha um estado civil");
                return;
            }
            SalvarFuncionario(nome, estadoCivil);
            LimparFuncionario();
        }
        private void SalvarFuncionario(string nome, string estadoCivil)
        {
            StreamWriter arquivo;
            arquivo = File.AppendText("");
            arquivo.WriteLine();
            arquivo.WriteLine("Cadastro de Funcionário");
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("Estado Civil: " + estadoCivil);
            arquivo.WriteLine("---------------------");
            arquivo.WriteLine();
            arquivo.Close();
            MessageBox.Show("Funcionário salvo com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LimparFuncionario()
        {
            txtNomeFuncionario.Clear();
            rbtnCasado.Checked = false;
            rbtnSolteiro.Checked = false;
        }
    }
}
