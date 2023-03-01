using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp.Ejercicios
{
    public partial class Ejercicio2 : UserControl
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }
        double radio;
        double area;
        double pi = Math.PI;
        double longitud;
        public string titulo;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            AsignacionDatos();
            ObtenerRadio();
            ObtenerLongitud();
        }
        private void AsignacionDatos()
        {
            area =Convert.ToDouble( txtarea.Text);
        }
        private void ObtenerRadio()
        {
            radio = Math.Sqrt(area / pi);
            lblradio1.Text = radio.ToString("N2");
            lblradio2.Text = radio.ToString("N2");
            lblradioResul.Text = radio.ToString("N2");
        }
        private void ObtenerLongitud()
        {
            longitud = 2 * pi * radio;
            lbllongitudResul.Text = longitud.ToString("N2");
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            lblejercicio.Text = titulo;
        }
    }
}
