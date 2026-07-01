using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TelaCadastroUsuario
{

	public partial class TelaLogin : Form
	{
		
		string conexaoBanco = "server=localhost;port=8080;database=sistema_clientes;uid=root;pwd=;";
		public TelaLogin()
		{
		
			InitializeComponent();
			
		}
		void BtnLoginClick(object sender, EventArgs e)
		{
			
   
    if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtSenha.Text))
    {
        MessageBox.Show("Por favor, digite o usuário e a senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
    {
        try
        {
            conexao.Open();
            // Query que conta quantos registros batem com o usuário e senha digitados
            string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND senha = @senha";
            
            using (MySqlCommand comando = new MySqlCommand(query, conexao))
            {
                comando.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                comando.Parameters.AddWithValue("@senha", txtSenha.Text);
                
                
                int resultado = Convert.ToInt32(comando.ExecuteScalar());
                
                if (resultado > 0)
                {
                    
                    TelaCadastroCliente cadastroCliente = new TelaCadastroCliente();
                    cadastroCliente.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao conectar ao banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
		void LinkCadastrarLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
	
    		TelaCadastroUsuario cadastro = new TelaCadastroUsuario();
    		cadastro.Show();
    		this.Hide();
    
		}
		}
	}

