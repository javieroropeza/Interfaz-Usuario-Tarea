/*
 * Created by SharpDevelop.
 * User: Alumnos
 * Date: 28/04/2014
 * Time: 04:24 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Interfaz_Usuario
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Tus_TextChanged(object sender, EventArgs e)
		{
			// TODO: Implement Tus_TextChanged
		}
		
		void Lus_Click(object sender, EventArgs e)
		{
			// TODO: Implement Lus_Click
		}
		
		void TCon_TextChanged(object sender, EventArgs e)
		{
			// TODO: Implement TCon_TextChanged
		}
		
		void LCon_Click(object sender, EventArgs e)
		{
			// TODO: Implement LCon_Click
		}
		
		void BEnt_Click(object sender, EventArgs e)
		{
			Validacion validacion = new Validacion(this.Tus.Text,this.TCon.Text);
			if( validacion.Accesar()){
				MessageBox.Show("Bienvenido al sistema " +this.Tus.Text);
			}else{
				MessageBox.Show("Datos incorrectos " +this.Tus.Text);
			}
			

		}
		void MainForm_Load(object sender, EventArgs e)
		{
			
		}
		
	}
}
