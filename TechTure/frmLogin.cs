using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechTure
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Obrigatório preencher os campos Login e Senha", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (txtLogin.Text == "andre" && txtSenha.Text == "12345" || txtLogin.Text == "Eduardo" && txtSenha.Text == "251099"
                || txtLogin.Text == "GABRIEL" && txtSenha.Text == "36741" || txtLogin.Text == "Ashley" && txtSenha.Text == "12345"
                || txtLogin.Text == "Angelo" && txtSenha.Text == "saas" || txtLogin.Text == "Julia" && txtSenha.Text == "12345")
            {
                frmPrincipal menu = new frmPrincipal();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha inválidos", "Ocorreu um erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Clear();
                txtSenha.Clear();
                txtLogin.Focus();
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.Show();
            this.Hide();
        }
    }
}
