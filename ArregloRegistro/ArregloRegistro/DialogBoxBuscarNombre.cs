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
    public partial class DialogBoxBuscarNombre : Form
    {
        public DialogBoxBuscarNombre()
        {
            InitializeComponent();
        }

        //Declaracion del metodo get
        public string nombreproducto
        {
            get { return (textBox1.Text); }
        }

        private void DialogBoxBuscarNombre_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
