/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 30/06/2026
 * Time: 08:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TelaCadastroUsuario
{
	partial class TelaCadastroUsuario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.Label caption;
		private System.Windows.Forms.LinkLabel linkLogin;
		
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
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.caption = new System.Windows.Forms.Label();
			this.linkLogin = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(64, 115);
			this.txtNome.Margin = new System.Windows.Forms.Padding(4);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(353, 26);
			this.txtNome.TabIndex = 0;
			// 
			// lblNome
			// 
			this.lblNome.Location = new System.Drawing.Point(64, 88);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(132, 23);
			this.lblNome.TabIndex = 1;
			this.lblNome.Text = "Insira seu nome:";
			// 
			// lblUsuario
			// 
			this.lblUsuario.Location = new System.Drawing.Point(64, 160);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(192, 23);
			this.lblUsuario.TabIndex = 2;
			this.lblUsuario.Text = "Crie um nome de usuário:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(64, 186);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(353, 26);
			this.txtUsuario.TabIndex = 3;
			// 
			// lblSenha
			// 
			this.lblSenha.Location = new System.Drawing.Point(64, 237);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(132, 23);
			this.lblSenha.TabIndex = 4;
			this.lblSenha.Text = "Crie uma senha:";
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(64, 263);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(353, 26);
			this.txtSenha.TabIndex = 5;
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Location = new System.Drawing.Point(180, 295);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(124, 42);
			this.btnCadastrar.TabIndex = 6;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrarClick);
			// 
			// caption
			// 
			this.caption.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.caption.Location = new System.Drawing.Point(64, 27);
			this.caption.Name = "caption";
			this.caption.Size = new System.Drawing.Size(353, 23);
			this.caption.TabIndex = 7;
			this.caption.Text = "Cadastro de usuário";
			this.caption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// linkLogin
			// 
			this.linkLogin.ActiveLinkColor = System.Drawing.Color.Blue;
			this.linkLogin.Location = new System.Drawing.Point(193, 340);
			this.linkLogin.Name = "linkLogin";
			this.linkLogin.Size = new System.Drawing.Size(100, 23);
			this.linkLogin.TabIndex = 8;
			this.linkLogin.TabStop = true;
			this.linkLogin.Text = "Fazer login";
			this.linkLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.linkLogin.VisitedLinkColor = System.Drawing.Color.Blue;
			this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLoginLinkClicked);
			// 
			// TelaCadastroUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 378);
			this.Controls.Add(this.linkLogin);
			this.Controls.Add(this.caption);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.lblUsuario);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.txtNome);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "TelaCadastroUsuario";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tela de cadastro - Usuário";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
