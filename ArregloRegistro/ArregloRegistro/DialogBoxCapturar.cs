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
    public partial class DialogBoxCapturar : Form
    {
        public DialogBoxCapturar()
        {
            InitializeComponent();
        }
        //Declaracion de metodos
        public string id
        {
            get { return (textBox1.Text); }
        }
            public string precioProducto
        {
            get { return (textBox3.Text); }
        }
        public string nombreProducto
        {
            get { return (textBox2.Text); }
        }
        public string existenciaProducto
        {
            get { return (textBox4.Text); }
        }
        private void DialogBoxCapturar_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox3.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox2.Focus();
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox4.Focus();
            }
        }
    }
}
