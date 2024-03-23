/*
 * Creado por SharpDevelop.
 * Usuario: CodeHorizont
 * Fecha: 23/3/2024
 * Hora: 2:55 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace PracticaImagen23_03_2024
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
			btnImagen.Click += new EventHandler(btnImagen_Click);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

		void btnImagen_Click(object sender, EventArgs e)
		{
			OFDimagenes.Title = "Seleccione una Imagen";
			OFDimagenes.Filter = "solo imagenes(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
			DialogResult resultado = OFDimagenes.ShowDialog();
			if(resultado == DialogResult.OK)
			{
				string RutaOriginal = OFDimagenes.FileName;
				string NombreArchivo = Path.GetFileName(RutaOriginal);
				string RutaDestino = Path.Combine(Application.StartupPath,"imagenes",NombreArchivo);
				string RutaRelativa = Path.Combine("imagenes",NombreArchivo);
				File.Copy(RutaOriginal,RutaDestino,true);
				using(MemoryStream stream = new MemoryStream(File.ReadAllBytes(RutaRelativa)))
				{
					pictureBox1.Image = Image.FromStream(stream);
					pictureBox1.Tag = RutaRelativa;
				}
			}
		}
	}
}
