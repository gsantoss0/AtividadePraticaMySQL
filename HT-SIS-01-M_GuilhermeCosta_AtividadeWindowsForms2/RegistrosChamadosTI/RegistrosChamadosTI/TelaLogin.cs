using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RegistrosChamadosTI
{

	public partial class TelaLogin : Form
	{
		string conexaoBanco = "server=localhost;port=8080;database=sistema_chamados_ti;uid=root;pwd=;";
		public TelaLogin()
		{
			
			InitializeComponent();
			
		}
		void BtnEntrarClick(object sender, EventArgs e)
		{
			
    	if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtSenha.Text))
    	{
        	MessageBox.Show("Preencha o usuário e a senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        	return;
    	}

    	using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
    	{
        	try
        	{
            	conexao.Open();
            	string query = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND senha = @senha";
            
            	using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            	{
                	cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim());
                	cmd.Parameters.AddWithValue("@senha", txtSenha.Text);

                	int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                	if (resultado > 0)
                	{
                    	// Login correto: abrir TelaCadastroChamado
                    	TelaCadastroChamado chamados = new TelaCadastroChamado();
                    	chamados.Show();
                    	this.Hide();
                	}
                	else
                	{
                    	// Login incorreto
                    	MessageBox.Show("Usuário ou senha incorretos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                	}
            	}
        	}
        	catch (Exception ex)
        	{
            	MessageBox.Show("Erro de conexão: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        	}
    	}
	}
		void LinkCadastrarLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
    	TelaCadastroUsuario cadastro = new TelaCadastroUsuario();
    	cadastro.Show();
    	this.Hide();
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
    		
    		if (txtSenha.UseSystemPasswordChar == false)
    	{
        	
        	txtSenha.UseSystemPasswordChar = true;
        
    	}
    	else{
        	
        	txtSenha.UseSystemPasswordChar = false;
    	}

		}
		void TelaLoginFormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		
	}
	
}
	


