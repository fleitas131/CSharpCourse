﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp.OperadoresAritmeticos
{
    public partial class frmOpAritmeticos : Form
    {
        public frmOpAritmeticos()
        {
            InitializeComponent();
        }
        double numero1;
        double numero2;
        double resultado;
        private void frmOpAritmeticos_Load(object sender, EventArgs e)
        {

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            Suma();
        }
        private void Asignaciondevalores()
        {
            txtnumero1.Text = txtnumero1.Text.Replace(",", ".");
            txtnumero2.Text = txtnumero2.Text.Replace(",", ".");
            numero1 = Convert.ToDouble(txtnumero1.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);
        }
        private void Suma()
        {
            if (!string.IsNullOrEmpty(txtnumero1.Text))
            {
                try
                {
                    Asignaciondevalores();
                    resultado = numero1 + numero2;
                    lblresultado.Text = resultado.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace);
                }
               
            }
            else
            {

                MessageBox.Show("Escriba un valor en el numero 1");
            }

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            Resta();
        }
        private void Resta()
        {
            numero1 = Convert.ToDouble(txtnumero1.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);
            resultado = numero1 - numero2;
            lblresultado.Text = resultado.ToString();
        }
        private void Multiplicar()
        {
            numero1 = Convert.ToDouble(txtnumero1.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);
            resultado = numero1 * numero2;
            lblresultado.Text = resultado.ToString();
        }
        private void Dividir()
        {
            numero1 = Convert.ToDouble(txtnumero1.Text);
            numero2 = Convert.ToDouble(txtnumero2.Text);
            resultado = numero1 / numero2;
            lblresultado.Text = resultado.ToString();
        }
        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            Multiplicar();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            Dividir();
        }



    }
}
