/*
 * Creado por SharpDevelop.
 * Usuario: CodeHorizont
 * Fecha: 23/3/2024
 * Hora: 2:55 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace PracticaImagen23_03_2024
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnImagen = new System.Windows.Forms.Button();
			this.OFDimagenes = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox1.Location = new System.Drawing.Point(55, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(165, 99);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnImagen
			// 
			this.btnImagen.Location = new System.Drawing.Point(67, 142);
			this.btnImagen.Name = "btnImagen";
			this.btnImagen.Size = new System.Drawing.Size(126, 23);
			this.btnImagen.TabIndex = 1;
			this.btnImagen.Text = "Seleccione una imagen";
			this.btnImagen.UseVisualStyleBackColor = true;
			// 
			// OFDimagenes
			// 
			this.OFDimagenes.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 344);
			this.Controls.Add(this.btnImagen);
			this.Controls.Add(this.pictureBox1);
			this.Name = "MainForm";
			this.Text = "PracticaImagen23-03-2024";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.OpenFileDialog OFDimagenes;
		private System.Windows.Forms.Button btnImagen;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
