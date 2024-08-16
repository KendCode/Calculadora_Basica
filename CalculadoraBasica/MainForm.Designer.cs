/*
 * Creado por SharpDevelop.
 * Usuario: ASUS
 * Fecha: 08/08/2024
 * Hora: 20:15
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CalculadoraBasica
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_Suma;
		private System.Windows.Forms.TextBox txt_N1;
		private System.Windows.Forms.TextBox txt_N2;
		private System.Windows.Forms.Label lbl_Resultado;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnDividir;
		private System.Windows.Forms.Button btnMultiplicar;
		private System.Windows.Forms.Button btnResta;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btn_Suma = new System.Windows.Forms.Button();
			this.txt_N1 = new System.Windows.Forms.TextBox();
			this.txt_N2 = new System.Windows.Forms.TextBox();
			this.lbl_Resultado = new System.Windows.Forms.Label();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.btnDividir = new System.Windows.Forms.Button();
			this.btnMultiplicar = new System.Windows.Forms.Button();
			this.btnResta = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(201, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(356, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "CALCULADORA BASICA";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label3.Location = new System.Drawing.Point(121, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(146, 26);
			this.label3.TabIndex = 2;
			this.label3.Text = "Número2:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label4.Location = new System.Drawing.Point(121, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(146, 26);
			this.label4.TabIndex = 3;
			this.label4.Text = "Número1:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Suma
			// 
			this.btn_Suma.BackColor = System.Drawing.Color.MintCream;
			this.btn_Suma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btn_Suma.FlatAppearance.BorderSize = 5;
			this.btn_Suma.ForeColor = System.Drawing.Color.RoyalBlue;
			this.btn_Suma.Location = new System.Drawing.Point(121, 269);
			this.btn_Suma.Name = "btn_Suma";
			this.btn_Suma.Size = new System.Drawing.Size(116, 38);
			this.btn_Suma.TabIndex = 4;
			this.btn_Suma.Text = "SUMA";
			this.btn_Suma.UseVisualStyleBackColor = false;
			this.btn_Suma.Click += new System.EventHandler(this.Btn_SumaClick);
			// 
			// txt_N1
			// 
			this.txt_N1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_N1.Location = new System.Drawing.Point(344, 146);
			this.txt_N1.Name = "txt_N1";
			this.txt_N1.Size = new System.Drawing.Size(151, 25);
			this.txt_N1.TabIndex = 5;
			// 
			// txt_N2
			// 
			this.txt_N2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_N2.Location = new System.Drawing.Point(344, 200);
			this.txt_N2.Name = "txt_N2";
			this.txt_N2.Size = new System.Drawing.Size(151, 27);
			this.txt_N2.TabIndex = 6;
			// 
			// lbl_Resultado
			// 
			this.lbl_Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Resultado.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lbl_Resultado.Location = new System.Drawing.Point(184, 392);
			this.lbl_Resultado.Name = "lbl_Resultado";
			this.lbl_Resultado.Size = new System.Drawing.Size(395, 45);
			this.lbl_Resultado.TabIndex = 7;
			this.lbl_Resultado.Text = "Resultado...";
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlText;
			this.btnLimpiar.ForeColor = System.Drawing.Color.Chartreuse;
			this.btnLimpiar.Location = new System.Drawing.Point(314, 329);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(118, 38);
			this.btnLimpiar.TabIndex = 8;
			this.btnLimpiar.Text = "LIMPIAR";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnDividir
			// 
			this.btnDividir.BackColor = System.Drawing.Color.Snow;
			this.btnDividir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnDividir.FlatAppearance.BorderSize = 5;
			this.btnDividir.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnDividir.Location = new System.Drawing.Point(514, 269);
			this.btnDividir.Name = "btnDividir";
			this.btnDividir.Size = new System.Drawing.Size(116, 38);
			this.btnDividir.TabIndex = 9;
			this.btnDividir.Text = "DIVIDIR";
			this.btnDividir.UseVisualStyleBackColor = false;
			this.btnDividir.Click += new System.EventHandler(this.BtnDividirClick);
			// 
			// btnMultiplicar
			// 
			this.btnMultiplicar.BackColor = System.Drawing.Color.PapayaWhip;
			this.btnMultiplicar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnMultiplicar.FlatAppearance.BorderSize = 5;
			this.btnMultiplicar.ForeColor = System.Drawing.Color.DarkBlue;
			this.btnMultiplicar.Location = new System.Drawing.Point(379, 269);
			this.btnMultiplicar.Name = "btnMultiplicar";
			this.btnMultiplicar.Size = new System.Drawing.Size(116, 38);
			this.btnMultiplicar.TabIndex = 10;
			this.btnMultiplicar.Text = "MULTIPLICAR";
			this.btnMultiplicar.UseVisualStyleBackColor = false;
			this.btnMultiplicar.Click += new System.EventHandler(this.BtnMultiplicarClick);
			// 
			// btnResta
			// 
			this.btnResta.BackColor = System.Drawing.Color.OldLace;
			this.btnResta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btnResta.FlatAppearance.BorderSize = 5;
			this.btnResta.ForeColor = System.Drawing.Color.Brown;
			this.btnResta.Location = new System.Drawing.Point(243, 269);
			this.btnResta.Name = "btnResta";
			this.btnResta.Size = new System.Drawing.Size(116, 38);
			this.btnResta.TabIndex = 11;
			this.btnResta.Text = "RESTA";
			this.btnResta.UseVisualStyleBackColor = false;
			this.btnResta.Click += new System.EventHandler(this.Button3Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(760, 466);
			this.Controls.Add(this.btnResta);
			this.Controls.Add(this.btnMultiplicar);
			this.Controls.Add(this.btnDividir);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.lbl_Resultado);
			this.Controls.Add(this.txt_N2);
			this.Controls.Add(this.txt_N1);
			this.Controls.Add(this.btn_Suma);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "CALCULADORA";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
