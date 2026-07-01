using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RegistrosChamadosTI
{
	public partial class TelaCadastroChamado : Form
	{
		string conexaoBanco = "server=localhost;port=8080;database=sistema_chamados_ti;uid=root;pwd=;";
		public TelaCadastroChamado()
		{
			
			InitializeComponent();
			
		}
		void BtnRegistrarChamadoClick(object sender, EventArgs e)
		{
			
    	// 1. Validar regras obrigatórias de preenchimento
    	if (string.IsNullOrWhiteSpace(txtSolicitante.Text))
    	{
        	MessageBox.Show("Não permitir registrar chamado sem solicitante.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        	return;
    	}
    	if (string.IsNullOrWhiteSpace(txtEquipamento.Text))
    	{
        	MessageBox.Show("Não permitir registrar chamado sem equipamento.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        	return;
    	}
    	if (string.IsNullOrWhiteSpace(txtProblema.Text))
    	{
        	MessageBox.Show("Não permitir registrar chamado sem problema.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        	return;
    	}
    	if (cmbPrioridade.SelectedIndex == -1) // -1 significa nenhum selecionado
    	{
        	MessageBox.Show("Não permitir registrar chamado sem prioridade.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        	return;
    	}

    	using (MySqlConnection conexao = new MySqlConnection(conexaoBanco))
    	{
        	try
        	{
            	conexao.Open();
            	
            	string query = "INSERT INTO chamados (solicitante, equipamento, problema, prioridade) VALUES (@solicitante, @equipamento, @problema, @prioridade)";

            	using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            	{
                	cmd.Parameters.AddWithValue("@solicitante", txtSolicitante.Text.Trim());
                	cmd.Parameters.AddWithValue("@equipamento", txtEquipamento.Text.Trim());
                	cmd.Parameters.AddWithValue("@problema", txtProblema.Text.Trim());
                	cmd.Parameters.AddWithValue("@prioridade", cmbPrioridade.SelectedItem.ToString());

                	cmd.ExecuteNonQuery();
            	}

            	MessageBox.Show("Chamado registrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            	// Limpar os campos após o sucesso
            	LimparCampos();
        	}
        	catch (Exception ex)
        	{
            	MessageBox.Show("Erro ao registrar chamado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        	}
    	}
	}
		void BtnLimparClick(object sender, EventArgs e)
		{
			LimparCampos();
		}
		
		private void LimparCampos()
		{
    		txtSolicitante.Clear();
    		txtEquipamento.Clear();
    		txtProblema.Clear();
    		cmbPrioridade.SelectedIndex = -1; // Reseta o combo box
		}
		
		void TelaCadastroChamadoFormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
		
	}
	
}
