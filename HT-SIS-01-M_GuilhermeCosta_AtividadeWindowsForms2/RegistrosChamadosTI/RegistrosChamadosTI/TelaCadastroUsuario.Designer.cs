/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 01/07/2026
 * Time: 08:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RegistrosChamadosTI
{
	partial class TelaCadastroUsuario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCadastrar;
		private System.Windows.Forms.LinkLabel linkLogin;
		private System.Windows.Forms.Label label4;
		
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
			this.txtNome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCadastrar = new System.Windows.Forms.Button();
			this.linkLogin = new System.Windows.Forms.LinkLabel();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(41, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Insira seu nome:";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(232, 106);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(303, 26);
			this.txtNome.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(41, 144);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(203, 25);
			this.label2.TabIndex = 2;
			this.label2.Text = "Crie um nome de usuário:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(232, 141);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(303, 26);
			this.txtUsuario.TabIndex = 3;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(232, 179);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(303, 26);
			this.txtSenha.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(41, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(138, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Cria uma senha:";
			// 
			// btnCadastrar
			// 
			this.btnCadastrar.Location = new System.Drawing.Point(232, 230);
			this.btnCadastrar.Name = "btnCadastrar";
			this.btnCadastrar.Size = new System.Drawing.Size(126, 48);
			this.btnCadastrar.TabIndex = 6;
			this.btnCadastrar.Text = "Cadastrar";
			this.btnCadastrar.UseVisualStyleBackColor = true;
			this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrarClick);
			// 
			// linkLogin
			// 
			this.linkLogin.ActiveLinkColor = System.Drawing.Color.Blue;
			this.linkLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLogin.Location = new System.Drawing.Point(232, 293);
			this.linkLogin.Name = "linkLogin";
			this.linkLogin.Size = new System.Drawing.Size(126, 23);
			this.linkLogin.TabIndex = 7;
			this.linkLogin.TabStop = true;
			this.linkLogin.Text = "Fazer login";
			this.linkLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.linkLogin.VisitedLinkColor = System.Drawing.Color.Blue;
			this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLoginLinkClicked);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(41, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(494, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Cadastro de usuário";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// TelaCadastroUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.linkLogin);
			this.Controls.Add(this.btnCadastrar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "TelaCadastroUsuario";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tela de cadastro - usuário";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadastroUsuarioFormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
