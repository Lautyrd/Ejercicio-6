/*
 * Created by SharpDevelop.
 * User: LAB-02
 * Date: 11/11/2021
 * Time: 8:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio_6
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.TextBox txt_usuario;
		private System.Windows.Forms.TextBox txt_contraseña;
		private System.Windows.Forms.Label lbl_usuario;
		private System.Windows.Forms.Label lbl_contraseña;
		private System.Windows.Forms.Label lbl_acceso;
		
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
			this.btn_login = new System.Windows.Forms.Button();
			this.txt_usuario = new System.Windows.Forms.TextBox();
			this.txt_contraseña = new System.Windows.Forms.TextBox();
			this.lbl_usuario = new System.Windows.Forms.Label();
			this.lbl_contraseña = new System.Windows.Forms.Label();
			this.lbl_acceso = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_login
			// 
			this.btn_login.Location = new System.Drawing.Point(175, 112);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(75, 23);
			this.btn_login.TabIndex = 0;
			this.btn_login.Text = "Login";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.Btn_loginClick);
			// 
			// txt_usuario
			// 
			this.txt_usuario.Location = new System.Drawing.Point(162, 49);
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(100, 20);
			this.txt_usuario.TabIndex = 1;
			// 
			// txt_contraseña
			// 
			this.txt_contraseña.Location = new System.Drawing.Point(162, 86);
			this.txt_contraseña.Name = "txt_contraseña";
			this.txt_contraseña.Size = new System.Drawing.Size(100, 20);
			this.txt_contraseña.TabIndex = 2;
			this.txt_contraseña.UseSystemPasswordChar = true;
			// 
			// lbl_usuario
			// 
			this.lbl_usuario.Location = new System.Drawing.Point(65, 49);
			this.lbl_usuario.Name = "lbl_usuario";
			this.lbl_usuario.Size = new System.Drawing.Size(91, 20);
			this.lbl_usuario.TabIndex = 3;
			this.lbl_usuario.Text = "Usuario";
			this.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_contraseña
			// 
			this.lbl_contraseña.Location = new System.Drawing.Point(65, 86);
			this.lbl_contraseña.Name = "lbl_contraseña";
			this.lbl_contraseña.Size = new System.Drawing.Size(94, 20);
			this.lbl_contraseña.TabIndex = 4;
			this.lbl_contraseña.Text = "Contraseña";
			this.lbl_contraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_acceso
			// 
			this.lbl_acceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_acceso.Location = new System.Drawing.Point(162, 9);
			this.lbl_acceso.Name = "lbl_acceso";
			this.lbl_acceso.Size = new System.Drawing.Size(100, 23);
			this.lbl_acceso.TabIndex = 5;
			this.lbl_acceso.Text = "Acceso";
			this.lbl_acceso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(400, 182);
			this.Controls.Add(this.lbl_acceso);
			this.Controls.Add(this.lbl_contraseña);
			this.Controls.Add(this.lbl_usuario);
			this.Controls.Add(this.txt_contraseña);
			this.Controls.Add(this.txt_usuario);
			this.Controls.Add(this.btn_login);
			this.Name = "MainForm";
			this.Text = "Ejercicio 6";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
