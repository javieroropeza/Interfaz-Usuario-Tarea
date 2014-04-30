/*
 * Created by SharpDevelop.
 * User: Jesus
 * Date: 29/04/2014
 * Time: 02:12 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Interfaz_Usuario
{
	partial class MainForm
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
			this.Tus = new System.Windows.Forms.TextBox();
			this.Lus = new System.Windows.Forms.Label();
			this.LCon = new System.Windows.Forms.Label();
			this.bEnt = new System.Windows.Forms.Button();
			this.TCon = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// Tus
			// 
			this.Tus.Location = new System.Drawing.Point(88, 32);
			this.Tus.Name = "Tus";
			this.Tus.Size = new System.Drawing.Size(176, 20);
			this.Tus.TabIndex = 0;
			this.Tus.TextChanged += new System.EventHandler(this.Tus_TextChanged);
			// 
			// Lus
			// 
			this.Lus.Location = new System.Drawing.Point(88, 56);
			this.Lus.Name = "Lus";
			this.Lus.Size = new System.Drawing.Size(72, 16);
			this.Lus.TabIndex = 2;
			this.Lus.Text = "Usuario";
			this.Lus.Click += new System.EventHandler(this.Lus_Click);
			// 
			// LCon
			// 
			this.LCon.Location = new System.Drawing.Point(88, 120);
			this.LCon.Name = "LCon";
			this.LCon.Size = new System.Drawing.Size(80, 16);
			this.LCon.TabIndex = 3;
			this.LCon.Text = "Contraseña";
			this.LCon.Click += new System.EventHandler(this.LCon_Click);
			// 
			// bEnt
			// 
			this.bEnt.Location = new System.Drawing.Point(160, 160);
			this.bEnt.Name = "bEnt";
			this.bEnt.Size = new System.Drawing.Size(88, 24);
			this.bEnt.TabIndex = 4;
			this.bEnt.Text = "Entrar";
			this.bEnt.UseVisualStyleBackColor = true;
			this.bEnt.Click += new System.EventHandler(this.BEnt_Click);
			// 
			// TCon
			// 
			this.TCon.Location = new System.Drawing.Point(88, 96);
			this.TCon.Name = "TCon";
			this.TCon.PasswordChar = '*';
			this.TCon.Size = new System.Drawing.Size(176, 20);
			this.TCon.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.TCon);
			this.Controls.Add(this.bEnt);
			this.Controls.Add(this.LCon);
			this.Controls.Add(this.Lus);
			this.Controls.Add(this.Tus);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Name = "MainForm";
			this.Text = "Interfaz Usuario";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.MaskedTextBox TCon;
		private System.Windows.Forms.Button bEnt;
		private System.Windows.Forms.Label LCon;
		private System.Windows.Forms.Label Lus;
		private System.Windows.Forms.TextBox Tus;
	}
}
