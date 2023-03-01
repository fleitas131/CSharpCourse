using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CursoCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Este es un comentario
        //segunda linea
        //tercer linea
        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Hola mundo");
            Console.ReadLine();
        }
    }
}
