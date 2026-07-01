/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 01/07/2026
 * Time: 08:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RegistrosChamadosTI
{
	partial class TelaLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSenha;
		private System.Windows.Forms.Button btnEntrar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel linkCadastrar;
		private System.Windows.Forms.PictureBox pictureBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.btnEntrar = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.linkCadastrar = new System.Windows.Forms.LinkLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(61, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuário:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(128, 106);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(372, 26);
			this.txtUsuario.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(61, 147);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Senha:";
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(128, 144);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(372, 26);
			this.txtSenha.TabIndex = 3;
			// 
			// btnEntrar
			// 
			this.btnEntrar.Location = new System.Drawing.Point(224, 201);
			this.btnEntrar.Name = "btnEntrar";
			this.btnEntrar.Size = new System.Drawing.Size(125, 33);
			this.btnEntrar.TabIndex = 4;
			this.btnEntrar.Text = "Entrar";
			this.btnEntrar.UseVisualStyleBackColor = true;
			this.btnEntrar.Click += new System.EventHandler(this.BtnEntrarClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(61, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(439, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Login";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// linkCadastrar
			// 
			this.linkCadastrar.ActiveLinkColor = System.Drawing.Color.Blue;
			this.linkCadastrar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkCadastrar.Location = new System.Drawing.Point(224, 255);
			this.linkCadastrar.Name = "linkCadastrar";
			this.linkCadastrar.Size = new System.Drawing.Size(125, 23);
			this.linkCadastrar.TabIndex = 6;
			this.linkCadastrar.TabStop = true;
			this.linkCadastrar.Text = "Cadastrar";
			this.linkCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.linkCadastrar.VisitedLinkColor = System.Drawing.Color.Blue;
			this.linkCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkCadastrarLinkClicked);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(506, 148);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(23, 22);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// TelaLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.linkCadastrar);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnEntrar);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "TelaLogin";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Realizar Login";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaLoginFormClosed);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
