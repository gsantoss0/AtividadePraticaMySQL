/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 30/06/2026
 * Time: 09:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TelaCadastroUsuario
{
	partial class TelaCadastroCliente
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNomeCliente;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTelefone;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.TextBox txtObservacao;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnCadastrarCliente;
		private System.Windows.Forms.Button btnLimpar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNomeCliente = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTelefone = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.txtObservacao = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnCadastrarCliente = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(63, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(540, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cadastro de Cliente";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(63, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nome do cliente:";
			// 
			// txtNomeCliente
			// 
			this.txtNomeCliente.Location = new System.Drawing.Point(192, 103);
			this.txtNomeCliente.Name = "txtNomeCliente";
			this.txtNomeCliente.Size = new System.Drawing.Size(411, 26);
			this.txtNomeCliente.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(63, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Telefone:";
			// 
			// txtTelefone
			// 
			this.txtTelefone.Location = new System.Drawing.Point(192, 143);
			this.txtTelefone.Name = "txtTelefone";
			this.txtTelefone.Size = new System.Drawing.Size(411, 26);
			this.txtTelefone.TabIndex = 4;
			this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(63, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 5;
			this.label4.Text = "E-mail:";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(192, 178);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(411, 26);
			this.txtEmail.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(63, 214);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Endereço:";
			// 
			// txtEndereco
			// 
			this.txtEndereco.Location = new System.Drawing.Point(192, 211);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(411, 26);
			this.txtEndereco.TabIndex = 8;
			// 
			// txtObservacao
			// 
			this.txtObservacao.Location = new System.Drawing.Point(192, 249);
			this.txtObservacao.Name = "txtObservacao";
			this.txtObservacao.Size = new System.Drawing.Size(411, 26);
			this.txtObservacao.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(63, 252);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(123, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Observação:";
			// 
			// btnCadastrarCliente
			// 
			this.btnCadastrarCliente.Location = new System.Drawing.Point(238, 303);
			this.btnCadastrarCliente.Name = "btnCadastrarCliente";
			this.btnCadastrarCliente.Size = new System.Drawing.Size(183, 40);
			this.btnCadastrarCliente.TabIndex = 11;
			this.btnCadastrarCliente.Text = "Cadastrar Cliente";
			this.btnCadastrarCliente.UseVisualStyleBackColor = true;
			this.btnCadastrarCliente.Click += new System.EventHandler(this.BtnCadastrarClienteClick);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(268, 369);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(128, 29);
			this.btnLimpar.TabIndex = 12;
			this.btnLimpar.Text = "Limpar campos";
			this.btnLimpar.UseVisualStyleBackColor = true;
			// 
			// TelaCadastroCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 461);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnCadastrarCliente);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtObservacao);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTelefone);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtNomeCliente);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "TelaCadastroCliente";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tela de cadastro - cliente";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
