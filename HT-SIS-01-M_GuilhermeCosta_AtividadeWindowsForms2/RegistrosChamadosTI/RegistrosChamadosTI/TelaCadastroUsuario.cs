using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RegistrosChamadosTI
{
	public partial class TelaCadastroUsuario : Form
	{
		string conexaoBanco = "server=localhost;port=8080;database=sistema_chamados_ti;uid=root;pwd=;";
		public TelaCadastroUsuario()
		{
			
			InitializeComponent();
			
		}
		void BtnCadastrarClick(object sender, EventArgs e)
		{
			
    		// 1. Validar campos vazios
   			if (string.IsNullOrWhiteSpace(txtNome.Text) || 
        	string.IsNullOrWhiteSpace(txtUsuario.Text) || 
        	string.IsNullOrWhiteSpace(txtSenha.Text))
    	{
        	MessageBox.Show("Todos os campos são obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        	return;
    	}
    
    	using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
    	{
        	try
        	{
            	conexao.Open();

            	// 2. Verificar se o usuário já existe
            	string queryVerificar = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario";
            	using (MySqlCommand cmdVerificar = new MySqlCommand(queryVerificar, conexao))
            	{
                	cmdVerificar.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim());
                	int usuarioExiste = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                	if (usuarioExiste > 0)
                	{
                    	MessageBox.Show("Este nome de usuário já está em uso.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    	return;
                	}
            	}

            	// 3. Inserir o novo usuário
            	string queryInserir = "INSERT INTO usuarios (nome, usuario, senha) VALUES (@nome, @usuario, @senha)";
            	using (MySqlCommand cmdInserir = new MySqlCommand(queryInserir, conexao))
            	{
                	cmdInserir.Parameters.AddWithValue("@nome", txtNome.Text.Trim());
                	cmdInserir.Parameters.AddWithValue("@usuario", txtUsuario.Text.Trim());
                	cmdInserir.Parameters.AddWithValue("@senha", txtSenha.Text); 

                	cmdInserir.ExecuteNonQuery();
            	}

            	MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            	// 4. Redirecionar para a TelaLogin
            	TelaLogin login = new TelaLogin();
            	login.Show();
            	this.Hide(); // Esconde a tela atual
        		}
        	catch (Exception ex)
        	{
            	MessageBox.Show("Erro ao conectar ou gravar dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        	}
    	}
	}
		void LinkLoginLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
    		TelaLogin login = new TelaLogin();
    		login.Show();
    		this.Hide();
		}
		void TelaCadastroUsuarioFormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		
		}
}
	

