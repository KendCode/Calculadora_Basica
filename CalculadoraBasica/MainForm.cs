/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 08/08/2024
 * Hora: 20:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;//DIBUJO INTERFAZ GRAFICA
using System.Windows.Forms;//FORMULARIO DE VENTANAS

namespace CalculadoraBasica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		// atributos
		// int n1;
		public MainForm()
		{
			InitializeComponent();
			
		}
		void Btn_SumaClick(object sender, EventArgs e)
		{
			int n1 = int.Parse(txt_N1.Text);
			int n2 = Convert.ToInt32(txt_N2.Text);
			int r = n1 + n2;
			lbl_Resultado.Text = r.ToString();
				
		}
		void Button1Click(object sender, EventArgs e)
		{
			txt_N1.Text="";
			txt_N2.Clear();
			txt_N1.Focus();//cursor en la caja 1
		}
		void Button3Click(object sender, EventArgs e)
		{
			int n1 = int.Parse(txt_N1.Text);
			int n2 = Convert.ToInt32(txt_N2.Text);
			int r = n1 - n2;
			lbl_Resultado.Text = r.ToString();
		}
		void BtnMultiplicarClick(object sender, EventArgs e)
		{
			int n1 = int.Parse(txt_N1.Text);
			int n2 = Convert.ToInt32(txt_N2.Text);
			int r = n1 * n2;
			lbl_Resultado.Text = r.ToString();
		}
		void BtnDividirClick(object sender, EventArgs e)
		{
			int n1 = int.Parse(txt_N1.Text);
			int n2 = Convert.ToInt32(txt_N2.Text);
			int r;
			string no = "ERROR!!!!";
			if(n2 != 0){
				r = n1 / n2;
				lbl_Resultado.Text = r.ToString();
			}
			else{
				//MessageBox.Show("Error!...."+x.Message);
				lbl_Resultado.Text = no.ToString();
			}
		}
	}
}
