using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace project_AquaLumia
{
    public partial class frmLogin : Form
    {
        const string conn = "Server = 127.0.0.1; user id = root; database = linkwatts; password = ''";
        MySqlConnection conectar = new MySqlConnection(conn);

        Construtor c = new Construtor();
        Metodos_AL m = new Metodos_AL();


        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void btnEntar_Click(object sender, EventArgs e)
        {
            string login, senha;

            login = txtLogin.Text;
            senha = txtSenha.Text;
            try
           {
               conectar.Open();

               MySqlCommand verificar = new MySqlCommand("SELECT * FROM login WHERE NomeUsu_Log = '" + login + "' AND Senha_Log = '" + senha + "'", conectar);

               bool resultado = verificar.ExecuteReader().HasRows;

               if (resultado == true)
               {
                   conectar.Close(); //fecha a conexão pois ela já foi usada



                   frmSplash vemSplash = new frmSplash();
                   this.Hide();
                   vemSplash.ShowDialog();
                   this.Close();



               }

               else
               {
                   MessageBox.Show("Usuário ou senha inválidos!", "Login inválido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   txtLogin.Text = "";
                   txtSenha.Text = "";
                   txtLogin.Focus();
               }
           }

           catch
           {
               MessageBox.Show("Não foi possível estabelecer a conexão!", "Erro de conexão", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtLogin.Text = "";
               txtSenha.Text = "";
               txtLogin.Focus();
           }
       }

        

        private void btnSair_Click(object sender, EventArgs e)
        {
            const string message = "Você Realmente deseja sair?";
            const string caption = "Sair.";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }
    }
}
