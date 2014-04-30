/*
 * Created by SharpDevelop.
 * User: Jesus
 * Date: 30/04/2014
 * Time: 12:50 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Interfaz_Usuario
{
	/// <summary>
	/// Description of Validacion.
	/// </summary>
	public class Validacion
	{
		private String Usuario;
		private String Contraseña;
		
		public Validacion( String Usuario, String Contraseña)
		{
			this.Usuario = Usuario;
			this.Contraseña = Contraseña;
		}
		public bool Accesar (){
			return(this.Usuario=="Javier" && this.Contraseña=="Potter");
		}
	}
}
