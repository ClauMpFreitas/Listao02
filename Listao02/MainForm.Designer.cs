/*
 * Created by SharpDevelop.
 * User: POLIMIG
 * Date: 13/03/2023
 * Time: 15:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Listao02
{
	partial class FrmSorveteria
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbespecial = new System.Windows.Forms.RadioButton();
			this.rbcomum = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbamendoim = new System.Windows.Forms.CheckBox();
			this.cbcobertura = new System.Windows.Forms.CheckBox();
			this.cbchocolate = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtpeso = new System.Windows.Forms.TextBox();
			this.btncalcular = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtsorvete = new System.Windows.Forms.TextBox();
			this.txtopcionais = new System.Windows.Forms.TextBox();
			this.txttotal = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rbespecial);
			this.groupBox1.Controls.Add(this.rbcomum);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(14, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(183, 92);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tipo de sorvete";
			// 
			// rbespecial
			// 
			this.rbespecial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbespecial.Location = new System.Drawing.Point(15, 52);
			this.rbespecial.Name = "rbespecial";
			this.rbespecial.Size = new System.Drawing.Size(124, 24);
			this.rbespecial.TabIndex = 1;
			this.rbespecial.TabStop = true;
			this.rbespecial.Text = "Especial";
			this.rbespecial.UseVisualStyleBackColor = true;
			// 
			// rbcomum
			// 
			this.rbcomum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rbcomum.Location = new System.Drawing.Point(15, 32);
			this.rbcomum.Name = "rbcomum";
			this.rbcomum.Size = new System.Drawing.Size(124, 24);
			this.rbcomum.TabIndex = 0;
			this.rbcomum.TabStop = true;
			this.rbcomum.Text = "Comum";
			this.rbcomum.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbamendoim);
			this.groupBox2.Controls.Add(this.cbcobertura);
			this.groupBox2.Controls.Add(this.cbchocolate);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(14, 134);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 125);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Opcionais";
			// 
			// cbamendoim
			// 
			this.cbamendoim.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbamendoim.Location = new System.Drawing.Point(6, 87);
			this.cbamendoim.Name = "cbamendoim";
			this.cbamendoim.Size = new System.Drawing.Size(177, 24);
			this.cbamendoim.TabIndex = 2;
			this.cbamendoim.Text = "Amendoim - R$ 5,50";
			this.cbamendoim.UseVisualStyleBackColor = true;
			// 
			// cbcobertura
			// 
			this.cbcobertura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbcobertura.Location = new System.Drawing.Point(6, 56);
			this.cbcobertura.Name = "cbcobertura";
			this.cbcobertura.Size = new System.Drawing.Size(177, 24);
			this.cbcobertura.TabIndex = 1;
			this.cbcobertura.Text = "Cobertura - R$ 3,00";
			this.cbcobertura.UseVisualStyleBackColor = true;
			// 
			// cbchocolate
			// 
			this.cbchocolate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbchocolate.Location = new System.Drawing.Point(6, 25);
			this.cbchocolate.Name = "cbchocolate";
			this.cbchocolate.Size = new System.Drawing.Size(177, 24);
			this.cbchocolate.TabIndex = 0;
			this.cbchocolate.Text = "Chocolate - R$ 7,00";
			this.cbchocolate.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(264, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(216, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Peso do sorvete (Em KG):";
			// 
			// txtpeso
			// 
			this.txtpeso.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtpeso.Location = new System.Drawing.Point(274, 53);
			this.txtpeso.Name = "txtpeso";
			this.txtpeso.Size = new System.Drawing.Size(165, 26);
			this.txtpeso.TabIndex = 3;
			// 
			// btncalcular
			// 
			this.btncalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btncalcular.Location = new System.Drawing.Point(288, 100);
			this.btncalcular.Name = "btncalcular";
			this.btncalcular.Size = new System.Drawing.Size(135, 33);
			this.btncalcular.TabIndex = 4;
			this.btncalcular.Text = "Calcular total";
			this.btncalcular.UseVisualStyleBackColor = true;
			this.btncalcular.Click += new System.EventHandler(this.BtncalcularClick);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(249, 159);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(149, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Valor do sorvete";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(249, 210);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Valor dos opcionais";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(249, 260);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Total";
			// 
			// txtsorvete
			// 
			this.txtsorvete.Enabled = false;
			this.txtsorvete.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtsorvete.Location = new System.Drawing.Point(380, 156);
			this.txtsorvete.Name = "txtsorvete";
			this.txtsorvete.Size = new System.Drawing.Size(132, 26);
			this.txtsorvete.TabIndex = 8;
			// 
			// txtopcionais
			// 
			this.txtopcionais.Enabled = false;
			this.txtopcionais.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtopcionais.Location = new System.Drawing.Point(404, 210);
			this.txtopcionais.Name = "txtopcionais";
			this.txtopcionais.Size = new System.Drawing.Size(100, 26);
			this.txtopcionais.TabIndex = 9;
			// 
			// txttotal
			// 
			this.txttotal.Enabled = false;
			this.txttotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txttotal.Location = new System.Drawing.Point(301, 260);
			this.txttotal.Name = "txttotal";
			this.txttotal.Size = new System.Drawing.Size(100, 26);
			this.txttotal.TabIndex = 10;
			// 
			// FrmSorveteria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(533, 303);
			this.Controls.Add(this.txttotal);
			this.Controls.Add(this.txtopcionais);
			this.Controls.Add(this.txtsorvete);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btncalcular);
			this.Controls.Add(this.txtpeso);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FrmSorveteria";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sorveteria X";
			this.Shown += new System.EventHandler(this.FrmSorveteriaShown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.TextBox txttotal;
		private System.Windows.Forms.TextBox txtopcionais;
		private System.Windows.Forms.TextBox txtsorvete;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btncalcular;
		private System.Windows.Forms.TextBox txtpeso;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox cbchocolate;
		private System.Windows.Forms.CheckBox cbcobertura;
		private System.Windows.Forms.CheckBox cbamendoim;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton rbcomum;
		private System.Windows.Forms.RadioButton rbespecial;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
