using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TelaCadastroUsuario
{

	public partial class TelaCadastroCliente : Form
	{
		
		string conexaoBanco = "server=localhost;port=8080;database=sistema_clientes;uid=root;pwd=;";
		public TelaCadastroCliente()
		{
			InitializeComponent();
			
		}
		void BtnCadastrarClienteClick(object sender, EventArgs e)
		{
			
    // não permite cadastrar sem Nome do Cliente e Telefone
    if (string.IsNullOrEmpty(txtNomeCliente.Text) || string.IsNullOrEmpty(txtTelefone.Text))
    {
        MessageBox.Show("Os campos Nome do Cliente e Telefone são obrigatórios!", "Aviso de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        return;
    }

    using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
    {
        try
        {
            conexao.Open();
            
            string query = "INSERT INTO clientes (nome_cliente, telefone, email, endereco, observacao) VALUES (@nome, @telefone, @email, @endereco, @observacao)";
            
            using (MySqlCommand comando = new MySqlCommand(query, conexao))
            {
                // Vincula os valores das caixas de texto aos parâmetros do SQL
                comando.Parameters.AddWithValue("@nome", txtNomeCliente.Text);
                comando.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                comando.Parameters.AddWithValue("@email", txtEmail.Text);
                comando.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                comando.Parameters.AddWithValue("@observacao", txtObservacao.Text);
                
                comando.ExecuteNonQuery(); // Grava no MySQL Workbench
                
                
                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
                LimparCampos();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro ao salvar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
		// Função que limpa todas as caixas de texto
		void LimparCampos()
		{
    		txtNomeCliente.Clear();
   		 	txtTelefone.Clear();
    		txtEmail.Clear();
    		txtEndereco.Clear();
    		txtObservacao.Clear();
		}


		void BtnLimparClick(object sender, EventArgs e)
		{
    	LimparCampos();
		}
		}

}

