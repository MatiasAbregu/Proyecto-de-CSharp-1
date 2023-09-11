/*
 2) Formulario de carga de datos de una persona con datos: nombre, apellido, fecha de nacimiento.
Al agregar debe anexarse (nombre, apellido, edad) a los demás dados de alta, visualizados en una
Label.

Trabajo desarrollado por Nicolás Nuñez Deheza y Matías Abregú.

-Diseño:Nicolás Nuñez Deheza y Matías Abregú.

-Funcionamiento principal:Nicolás Nuñez Deheza.

-Validación y comprobación:Matías Abregú.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_LP1__Abregú_Matías_Nicolás_Nuñez_Deheza_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B1_Click(object sender, EventArgs e)
        {
            String nombre = TB1.Text;
            String apellido = TB2.Text;
            int edad=DateTime.Now.Year-DTP.Value.Year;
            //TB3.Text+=$"Nombre: {nombre}, Apellido: {apellido}, Edad: {edad} \n\n";
            TB3.AppendText($"-Nombre: {nombre}, Apellido: {apellido}, Edad: {edad}\r\n\r\n");
        }
    }
}
