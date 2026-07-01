using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TelaCadastroUsuario
{
    
    public partial class TelaCadastroUsuario : Form
    {
        string conexaoBanco = "server=localhost;port=8080;database=sistema_clientes;uid=root;pwd=;";

        public TelaCadastroUsuario()
        {
            InitializeComponent();
        }
		void BtnCadastrarClick(object sender, EventArgs e)
		{
	
   		 if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
   		 {
      	  MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     	   return;
   		  }

   
   		 using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
    		{
        	try
        	{
            conexao.Open();
            
            string query = "INSERT INTO usuarios (nome, usuario, senha) VALUES (@nome, @usuario, @senha)";
            
            using (MySqlCommand comando = new MySqlCommand(query, conexao))
            {
                
                comando.Parameters.AddWithValue("@nome", txtNome.Text);
                comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@senha", txtSenha.Text);
                
                comando.ExecuteNonQuery();
                
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao cadastrar no banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
		void LinkLoginLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			TelaLogin login = new TelaLogin();
                login.Show();
                this.Hide();
		}
		
		}

}