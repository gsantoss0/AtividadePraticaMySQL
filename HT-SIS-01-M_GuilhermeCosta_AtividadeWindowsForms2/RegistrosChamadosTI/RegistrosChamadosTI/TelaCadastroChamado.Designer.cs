/*
 * Created by SharpDevelop.
 * User: aluno_iot
 * Date: 01/07/2026
 * Time: 08:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RegistrosChamadosTI
{
	partial class TelaCadastroChamado
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbPrioridade;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnRegistrarChamado;
		private System.Windows.Forms.Button btnLimpar;
		private System.Windows.Forms.TextBox txtSolicitante;
		private System.Windows.Forms.TextBox txtEquipamento;
		private System.Windows.Forms.TextBox txtProblema;
		
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
			this.label3 = new System.Windows.Forms.Label();
			this.cmbPrioridade = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnRegistrarChamado = new System.Windows.Forms.Button();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.txtSolicitante = new System.Windows.Forms.TextBox();
			this.txtEquipamento = new System.Windows.Forms.TextBox();
			this.txtProblema = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(48, 95);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Solicitante:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(48, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Equipamento:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(48, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Problema:";
			// 
			// cmbPrioridade
			// 
			this.cmbPrioridade.FormattingEnabled = true;
			this.cmbPrioridade.Items.AddRange(new object[] {
			"Baixa",
			"Média",
			"Alta",
			"Urgente"});
			this.cmbPrioridade.Location = new System.Drawing.Point(222, 209);
			this.cmbPrioridade.Name = "cmbPrioridade";
			this.cmbPrioridade.Size = new System.Drawing.Size(151, 26);
			this.cmbPrioridade.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(48, 212);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(173, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Selecione a prioridade: ";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(48, 37);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(484, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Cadastro de chamados TI";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// btnRegistrarChamado
			// 
			this.btnRegistrarChamado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegistrarChamado.Location = new System.Drawing.Point(222, 257);
			this.btnRegistrarChamado.Name = "btnRegistrarChamado";
			this.btnRegistrarChamado.Size = new System.Drawing.Size(151, 35);
			this.btnRegistrarChamado.TabIndex = 6;
			this.btnRegistrarChamado.Text = "Registrar chamado";
			this.btnRegistrarChamado.UseVisualStyleBackColor = true;
			this.btnRegistrarChamado.Click += new System.EventHandler(this.BtnRegistrarChamadoClick);
			// 
			// btnLimpar
			// 
			this.btnLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(412, 257);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(106, 35);
			this.btnLimpar.TabIndex = 7;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			this.btnLimpar.Click += new System.EventHandler(this.BtnLimparClick);
			// 
			// txtSolicitante
			// 
			this.txtSolicitante.Location = new System.Drawing.Point(158, 92);
			this.txtSolicitante.Name = "txtSolicitante";
			this.txtSolicitante.Size = new System.Drawing.Size(360, 26);
			this.txtSolicitante.TabIndex = 8;
			// 
			// txtEquipamento
			// 
			this.txtEquipamento.Location = new System.Drawing.Point(158, 129);
			this.txtEquipamento.Name = "txtEquipamento";
			this.txtEquipamento.Size = new System.Drawing.Size(360, 26);
			this.txtEquipamento.TabIndex = 9;
			// 
			// txtProblema
			// 
			this.txtProblema.Location = new System.Drawing.Point(158, 168);
			this.txtProblema.Name = "txtProblema";
			this.txtProblema.Size = new System.Drawing.Size(360, 26);
			this.txtProblema.TabIndex = 10;
			// 
			// TelaCadastroChamado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 361);
			this.Controls.Add(this.txtProblema);
			this.Controls.Add(this.txtEquipamento);
			this.Controls.Add(this.txtSolicitante);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.btnRegistrarChamado);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cmbPrioridade);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "TelaCadastroChamado";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadastro de chamados";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaCadastroChamadoFormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
