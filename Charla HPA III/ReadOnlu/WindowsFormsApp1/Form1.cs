using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // 1. Campo readonly a nivel de clase
        private readonly string mensajePredeterminado = "Este texto es solo de lectura";

        public Form1()
        {
            InitializeComponent();

            // 2. Hacer que el TextBox de la ventana sea de solo lectura (no editable por el usuario)
            textBox1.ReadOnly = true;
            textBox1.Text = mensajePredeterminado;
        }
    }
}