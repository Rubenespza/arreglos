using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArregloRegistro
{
    public partial class DialogBoxExistenciaProducto : Form
    {
        public DialogBoxExistenciaProducto()
        {
            InitializeComponent();
        }

        //Declaracion del metodo get
        public string existenciaproducto
        {
            get { return (textBox1.Text); }
        }

        private void DialogBoxExistenciaProducto_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
