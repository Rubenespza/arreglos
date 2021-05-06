using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArregloRegistro
{
    class Producto
    {
        public int ID;
        public string NombreProducto;
        public double PrecioProducto;
        public int ExistenciaProducto;

        //Declaración de metodos get-set
        public int id
        {
            set { value = id; }
            get { return (ID); }
        }
        public string nombreproducto
        {
            set { value = nombreproducto; }
            get { return (NombreProducto); }
        }
        public double precioproducto
        {
            set { value = precioproducto; }
            get { return (PrecioProducto); }
        }
        public int existenciaproducto
        {
            set { value = existenciaproducto; }
            get { return (ExistenciaProducto); }
        }
        //declaracion del constructor
        public Producto()
        {
            ID = 0;
            NombreProducto = "";
            PrecioProducto = 0;
            ExistenciaProducto = 0;
        }
        //Declaración de metodos definidos por el usuario
        public Producto[] AgregarDatos(Producto[] A, int i)
        {
            DialogBoxCapturar captura = new DialogBoxCapturar();
            if (captura.ShowDialog() == DialogResult.OK)
            {
                A[i].ID = int.Parse(captura.id);
                A[i].NombreProducto = captura.nombreProducto;
                A[i].PrecioProducto = double.Parse(captura.precioProducto);
                A[i].ExistenciaProducto = int.Parse(captura.existenciaProducto);
                MessageBox.Show("Los datos se almacenaron en el arreglo", "Arreglos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (A);
        }
        public void MostrarTodos(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            for (int i = 0; i < 50; i++)
            {
                if (A[i].ID != 0)
                {
                    ListViewItem lista = new ListViewItem(A[i].id.ToString());
                    lista.SubItems.Add(A[i].NombreProducto);
                    lista.SubItems.Add(A[i].PrecioProducto.ToString());
                    lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                    caja.Items.Add(lista);
                }
            }
        }
        public void MostrarNombreProducto(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = true;
            DialogBoxBuscarNombre busca = new DialogBoxBuscarNombre();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].NombreProducto.ToUpper() == busca.nombreproducto.ToUpper())
                    {
                        sw = false;
                        ListViewItem lista = new ListViewItem(A[i].ID.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
                if (sw == true)
                {
                    MessageBox.Show("No se encontro el nombre del producto", "Arreglo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        public void MostrarPrecioProducto(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = true;
            DialogBoxPrecioProducto busca = new DialogBoxPrecioProducto();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].PrecioProducto == double.Parse(busca.precioproducto))
                    {
                        sw = false;
                        ListViewItem lista = new ListViewItem(A[i].ID.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
                if (sw == true)
                {
                    MessageBox.Show("No se encontro el precio del producto", "Arreglo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        public void MostrarExistenciaProducto(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = true;
            DialogBoxExistenciaProducto busca = new DialogBoxExistenciaProducto();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].ExistenciaProducto == int.Parse(busca.existenciaproducto))
                    {
                        sw = false;
                        ListViewItem lista = new ListViewItem(A[i].ID.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
                if (sw == true)
                {
                    MessageBox.Show("No se encontro el precio del producto", "Arreglo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }


        public Producto[] EliminarDatos(Producto[] A)
        {
            bool sw = false;
            DialogBoxBuscarNombre busca = new DialogBoxBuscarNombre();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].NombreProducto.ToUpper() == busca.nombreproducto.ToUpper())
                    {
                        sw = true;
                        A[i].ID = 0;
                        A[i].NombreProducto = "";
                        A[i].PrecioProducto = 0;
                        A[i].ExistenciaProducto = 0;
                    }
                }
                if (sw == false)
                {
                    MessageBox.Show("El producto que quiere elimnmar no existe",
                        "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("El producto se elimino de los datos de arreglo"
                 , "Arreglos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return (A);
        }
        public Producto[] ModificarProducto(Producto[] A)
        {
            bool sw = false;
            DialogBoxBuscarNombre busca = new DialogBoxBuscarNombre();
            DialogBoxCapturar captura = new DialogBoxCapturar();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].NombreProducto.ToUpper() == busca.nombreproducto.ToUpper())
                    {
                        sw = true;
                        if (captura.ShowDialog() == DialogResult.OK)
                        {
                            A[i].ID = int.Parse(captura.id);
                            A[i].NombreProducto = captura.nombreProducto;
                            A[i].PrecioProducto = double.Parse(captura.precioProducto);
                            A[i].ExistenciaProducto = int.Parse(captura.existenciaProducto);
                        }
                        if (sw == false)
                        {
                            MessageBox.Show("El producto que deseas modificar no existe", "Arreglos",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Los datos del producto se modificaron", "Arreglos",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                }

            }
            return (A);
        }
        public void ExistenciaPar(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = false;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].ExistenciaProducto != 0)
                {
                    if (A[i].ExistenciaProducto % 2 == 0)
                    {
                        sw = true;
                        ListViewItem lista = new ListViewItem(A[i].id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
            }
            if (sw == false)
            {
                MessageBox.Show("No se encontro números pares", "Arreglo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void ExistenciaImpar(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = true;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].ExistenciaProducto % 2 == 1)
                {
                    sw = false;
                    ListViewItem lista = new ListViewItem(A[i].id.ToString());
                    lista.SubItems.Add(A[i].NombreProducto);
                    lista.SubItems.Add(A[i].PrecioProducto.ToString());
                    lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                    caja.Items.Add(lista);
                }
            }
            if (sw == true)
            {
                MessageBox.Show("No se encontro números pares", "Arreglo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void MayorPrecio(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = true;
            double mayor = A[0].PrecioProducto;
            for (int i = 0; i < A.Length; i++)
            {
                if (mayor < A[i].PrecioProducto)
                {
                    mayor = A[i].PrecioProducto;

                }
                if (A[i].ID != 0)
                {
                    if (A[i].PrecioProducto.ToString() == mayor.ToString())
                    {
                        sw = false;
                        caja.Items.Clear();
                        ListViewItem lista = new ListViewItem(A[i].id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
            }
            if (sw == true)
            {
                MessageBox.Show("No se encontraron productos en existencia", "Arreglo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void MenorPrecio(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = false;
            double menor = A[0].PrecioProducto;
            for (int i = 0; i < A.Length; i++)
            {
                if (menor > A[i].PrecioProducto)
                {
                    menor = A[i].PrecioProducto;

                }
                if (A[i].ID != 0)
                {
                    if (A[i].PrecioProducto.ToString() == menor.ToString())
                    {
                        sw = true;
                        caja.Items.Clear();
                        ListViewItem lista = new ListViewItem(A[i].id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
            }
            if (sw == false)
            {
                MessageBox.Show("No se encontraron productos en existencia", "Arreglo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SumaPromedio(Producto[] A)
        {
            int cont = 0;
            double prom = 0;
            double suma = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].ID != 0)
                {
                    suma = suma + A[i].PrecioProducto;
                    cont++;
                }
            }
            prom = suma / cont;
            MessageBox.Show("La suma de los números de los arreglos es: " + suma + "\n" +
                "El promedio de los numeros del arreglo es: " + prom, "Arreglos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Mayorexistencia(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = false;
            double exitmayor = A[0].ExistenciaProducto;
            for (int i = 0; i < A.Length; i++)
            {
                if (exitmayor < A[i].existenciaproducto)
                {
                    exitmayor = A[i].existenciaproducto;
                }
                if (A[i].ID != 0)
                {
                    if (A[i].ExistenciaProducto.ToString() == exitmayor.ToString())
                    {
                        sw = true;
                        caja.Items.Clear();
                        ListViewItem lista = new ListViewItem(A[i].id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
            }
            if (sw == false)
            {
                MessageBox.Show("No se encontraron productos en existencia", "Arreglo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void MenorExistencia(Producto[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = false;
            double exitmenor = A[0].ExistenciaProducto;
            for (int i = 0; i < A.Length; i++)
            {
                if (exitmenor > A[i].existenciaproducto)
                {
                    exitmenor = A[i].existenciaproducto;
                }
                if (A[i].ID != 0)
                {
                    if (A[i].ExistenciaProducto.ToString() == exitmenor.ToString())
                    {
                        sw = true;
                        caja.Items.Clear();
                        ListViewItem lista = new ListViewItem(A[i].id.ToString());
                        lista.SubItems.Add(A[i].NombreProducto);
                        lista.SubItems.Add(A[i].PrecioProducto.ToString());
                        lista.SubItems.Add(A[i].ExistenciaProducto.ToString());
                        caja.Items.Add(lista);
                    }
                }
            }
            if (sw == false)
            {
                MessageBox.Show("No se encontraron productos en existencia", "Arreglo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

