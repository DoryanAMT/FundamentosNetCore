using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;


namespace FundamentosNetCore
{
    public partial class Form21Files : Form
    {
        private string Path { get; set; }
        private HelperFiles helper;
        public Form21Files()
        {
            InitializeComponent();

            //CUANDO HABLAMOS DE RUTAS DE FICHEROS, CON CARACTERES 
            //ESPECIALES: \ TENEMOS DOS POSIBILIDADES
            //C:\carpeta\file1.txt
            //1) UTILIZAR DOBLE CONTRABARRA
            this.Path = "C:\\carpeta\\file1.txt";
            //2) INDICAR QUE EL STRING SERA LITERAL: @
            this.Path = @"C:\carpeta\file1.txt";

            this.Path = "file1.txt";
        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
        }

        public string GetNombreListBox()
        {
            string data = "";
            foreach (string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            #region sin el helper
            ////  TENEMOS UNA CLASE LLAMADA FileInfo NOS DEVUELVE UN FILE
            ////  Y PODEMOS GENERAR WRITTER O READER
            //FileInfo file = new FileInfo(this.path);
            ////  CREAMOS EL FICHERO
            //using (TextWriter writer = file.CreateText())
            //{
            //    //  RECUPERAMOS LOS NOMBRE DEL LISTBOX
            //    string conenido = this.GetNombreListBox();
            //    //  ESCRIBIMOS DENTRO DEL FICHERO
            //    await writer.WriteAsync(conenido);
            //    //  DESPUES DE ESCRIBIR EN CUALQUIER FICHERO
            //    //  SE DEBE APLICAR EL METODO Flush()
            //    await writer.FlushAsync();
            //    //  CERRAMOS EL FICHERO
            //    writer.Close();
            //    MessageBox.Show("Datos almacenados");
            //};
            #endregion
            HelperFiles helper = new HelperFiles();
            string data = this.GetNombreListBox();
            await helper.WriteFileAsync(this.Path, data);
            MessageBox.Show("Datos guardados");


        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            #region sin el helper
            //FileInfo file = new FileInfo(this.path);
            //using (TextReader reader = file.OpenText())
            //{
            //    string contenido = await reader.ReadToEndAsync();
            //    //  SIMPRE SE LIBERAN LOS FICHEROS CON Close
            //    reader.Close();
            //    this.txtContenidoFile.Text = contenido;
            //    this.RellenarListBox(contenido);
            //}
            #endregion
            HelperFiles helper = new HelperFiles();
            string data = await helper.ReadFileAsync(this.Path);
            this.RellenarListBox(data);
            this.txtContenidoFile.Text = data;

        }

        public void RellenarListBox(string nombres)
        {
            string[] data = nombres.Split(',');
            this.lstNombres.Items.Clear();
            foreach (string name in data)
            {
                this.lstNombres.Items.Add(name);
            }
        }
    }
}
