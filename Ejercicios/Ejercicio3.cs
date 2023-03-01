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
    public partial class Ejercicio3 : UserControl
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }
        double peso;
        double altura;
        double imc;
        public string titulo;
        private void btncalcular_Click(object sender, EventArgs e)
        {
            Asignardatos();
            ObtenerIMC();
            Condicionar();
        }
        private void Asignardatos()
        {
            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);
        }
        private void ObtenerIMC()
        {
            imc = peso / Math.Pow(altura, 2);
            lblimc.Text = imc.ToString("N2");
        }
        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            lblejercicio.Text = titulo;
        }
        private void Condicionar()
        {
            if(imc<18.5)
            {
                lblcondicion.Text = "Por debajo";
            }
            if(imc>=18.5 && imc <=24.9)
            {
                lblcondicion.Text = "Saludable";

            }
            if(imc >=25 && imc <=29.9)
            {
                lblcondicion.Text = "Sobrepeso";
            }
            if(imc>30)
            {
                lblcondicion.Text = "Obsesidad";
            }
        }
    }
}
