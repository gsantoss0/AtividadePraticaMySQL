/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 30/06/2026
 * Time: 08:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TelaCadastroUsuario
{
	partial class TelaLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.LinkLabel linkCadastrar;
		private System.Windows.Forms.Label label3;
		
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
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.linkCadastrar = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(169, 125);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(256, 26);
			this.txtUsuario.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(30, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Insira seu usuário:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(30, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Insira sua senha:";
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(169, 175);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(256, 26);
			this.txtSenha.TabIndex = 3;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(169, 229);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(147, 40);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Realizar Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
			// 
			// linkCadastrar
			// 
			this.linkCadastrar.ActiveLinkColor = System.Drawing.Color.Blue;
			this.linkCadastrar.Location = new System.Drawing.Point(169, 285);
			this.linkCadastrar.Name = "linkCadastrar";
			this.linkCadastrar.Size = new System.Drawing.Size(147, 23);
			this.linkCadastrar.TabIndex = 5;
			this.linkCadastrar.TabStop = true;
			this.linkCadastrar.Text = "Cadastrar";
			this.linkCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.linkCadastrar.VisitedLinkColor = System.Drawing.Color.Blue;
			this.linkCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCadastrarLinkClicked);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(30, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(419, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Realizar Login";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// TelaLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 378);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.linkCadastrar);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtUsuario);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "TelaLogin";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tela de login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
