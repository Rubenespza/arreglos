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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Producto[] A;
        Producto x = new Producto();
        int cont = 0;
        int[] array = new int[50];
    
        private void agregarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = x.AgregarDatos(A, cont);
            cont++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            array = new int[50];
            A = new Producto[50];
            for (int i = 0; i < 50; i++)
            {
                A[i] = new Producto();   
            }
        }

        private void todosLosDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarTodos(A, listView1);
        }

        private void porNombreDelProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarNombreProducto(A, listView1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void porPrecioDelProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarPrecioProducto(A, listView1);
        }

        private void porExistenciaDeLosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarExistenciaProducto(A, listView1);
        }

        private void eliminarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            A = x.EliminarDatos(A);
            x.MostrarTodos(A, listView1);
        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            A = x.ModificarProducto(A);
            x.MostrarTodos(A,listView1);
        }


        private void mostrarElProductoDeMayorExistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.Mayorexistencia(A, listView1);
        }

        private void mostrarElProductoConMayorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MayorPrecio(A, listView1);
        }

        private void mostrarElProductoConMenorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MenorExistencia(A, listView1);
        }

        private void mostrarSumaYPromedioDeTodosLosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.SumaPromedio(A);
        }

        private void mostrarElProductoDeMenorrExistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MenorExistencia(A, listView1);
        }

        private void mostrarLosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.ExistenciaPar(A, listView1);
        }

        private void mostrarLosProductosConExistenciaImparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.ExistenciaImpar(A, listView1);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
