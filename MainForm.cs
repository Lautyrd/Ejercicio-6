using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_6
{

	public partial class MainForm : Form
	{
		public class usuario{
			public string nombre = ("Lautaro");
			public string contraseña = ("lauty");
		}
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Btn_loginClick(object sender, EventArgs e)
		{
			usuario objusuario = new usuario();
			if ((txt_usuario.Text == objusuario.nombre) && (txt_contraseña.Text == objusuario.contraseña)){
				string correcto = "Bienvenido";
				string caption = "Accedio Correctamente";
				MessageBox.Show(correcto, caption, MessageBoxButtons.OK, MessageBoxIcon.Question);
			}
			else if ((txt_usuario.Text == objusuario.nombre) && (txt_contraseña.Text != objusuario.contraseña)){
				string continc = "Contraseña incorrecta";
				string caption = "Algo anda mal...";
				MessageBox.Show(continc, caption, MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
			}
			else if ((txt_usuario.Text != objusuario.nombre) && (txt_contraseña.Text == objusuario.contraseña)){
				string nominc = "Nombre incorrecto";
				string caption = "Algo anda mal...";
				MessageBox.Show(nominc, caption, MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
			}
			else if ((txt_usuario.Text != objusuario.nombre) && (txt_contraseña.Text != objusuario.contraseña)){
				string incorrectos = "Ambos datos son incorrectos";
				string caption = "Algo anda mal...";
				MessageBox.Show(incorrectos, caption, MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
			}
		}
	}
}
