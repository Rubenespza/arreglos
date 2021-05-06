namespace ArregloRegistro
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreDelProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porPrecioDelProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porExistenciaDeLosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarLosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarElProductoConMayorPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarElProductoConMenorPrecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarSumaYPromedioDeTodosLosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarElProductoDeMenorrExistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(570, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarDatosToolStripMenuItem,
            this.mostrarDatosToolStripMenuItem,
            this.eliminarDatosToolStripMenuItem,
            this.modificarDatosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal ";
            // 
            // agregarDatosToolStripMenuItem
            // 
            this.agregarDatosToolStripMenuItem.Name = "agregarDatosToolStripMenuItem";
            this.agregarDatosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.agregarDatosToolStripMenuItem.Text = "Agregar Datos ";
            this.agregarDatosToolStripMenuItem.Click += new System.EventHandler(this.agregarDatosToolStripMenuItem_Click);
            // 
            // mostrarDatosToolStripMenuItem
            // 
            this.mostrarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosLosDatosToolStripMenuItem,
            this.porNombreDelProductoToolStripMenuItem,
            this.porPrecioDelProductoToolStripMenuItem,
            this.porExistenciaDeLosProductosToolStripMenuItem});
            this.mostrarDatosToolStripMenuItem.Name = "mostrarDatosToolStripMenuItem";
            this.mostrarDatosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.mostrarDatosToolStripMenuItem.Text = "Mostrar Datos...";
            // 
            // todosLosDatosToolStripMenuItem
            // 
            this.todosLosDatosToolStripMenuItem.Name = "todosLosDatosToolStripMenuItem";
            this.todosLosDatosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.todosLosDatosToolStripMenuItem.Text = "Todos los datos";
            this.todosLosDatosToolStripMenuItem.Click += new System.EventHandler(this.todosLosDatosToolStripMenuItem_Click);
            // 
            // porNombreDelProductoToolStripMenuItem
            // 
            this.porNombreDelProductoToolStripMenuItem.Name = "porNombreDelProductoToolStripMenuItem";
            this.porNombreDelProductoToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.porNombreDelProductoToolStripMenuItem.Text = "Por nombre del producto";
            this.porNombreDelProductoToolStripMenuItem.Click += new System.EventHandler(this.porNombreDelProductoToolStripMenuItem_Click);
            // 
            // porPrecioDelProductoToolStripMenuItem
            // 
            this.porPrecioDelProductoToolStripMenuItem.Name = "porPrecioDelProductoToolStripMenuItem";
            this.porPrecioDelProductoToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.porPrecioDelProductoToolStripMenuItem.Text = "Por precio del producto";
            this.porPrecioDelProductoToolStripMenuItem.Click += new System.EventHandler(this.porPrecioDelProductoToolStripMenuItem_Click);
            // 
            // porExistenciaDeLosProductosToolStripMenuItem
            // 
            this.porExistenciaDeLosProductosToolStripMenuItem.Name = "porExistenciaDeLosProductosToolStripMenuItem";
            this.porExistenciaDeLosProductosToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.porExistenciaDeLosProductosToolStripMenuItem.Text = "Por existencia de los productos";
            this.porExistenciaDeLosProductosToolStripMenuItem.Click += new System.EventHandler(this.porExistenciaDeLosProductosToolStripMenuItem_Click);
            // 
            // eliminarDatosToolStripMenuItem
            // 
            this.eliminarDatosToolStripMenuItem.Name = "eliminarDatosToolStripMenuItem";
            this.eliminarDatosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.eliminarDatosToolStripMenuItem.Text = "Eliminar Datos";
            this.eliminarDatosToolStripMenuItem.Click += new System.EventHandler(this.eliminarDatosToolStripMenuItem_Click);
            // 
            // modificarDatosToolStripMenuItem
            // 
            this.modificarDatosToolStripMenuItem.Name = "modificarDatosToolStripMenuItem";
            this.modificarDatosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.modificarDatosToolStripMenuItem.Text = "Modificar Datos";
            this.modificarDatosToolStripMenuItem.Click += new System.EventHandler(this.modificarDatosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarLosProductosToolStripMenuItem,
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem,
            this.mostrarElProductoConMayorPrecioToolStripMenuItem,
            this.mostrarElProductoConMenorPrecioToolStripMenuItem,
            this.mostrarSumaYPromedioDeTodosLosProductosToolStripMenuItem,
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem,
            this.mostrarElProductoDeMenorrExistenciaToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // mostrarLosProductosToolStripMenuItem
            // 
            this.mostrarLosProductosToolStripMenuItem.Name = "mostrarLosProductosToolStripMenuItem";
            this.mostrarLosProductosToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.mostrarLosProductosToolStripMenuItem.Text = "Mostrar los productos con existencia par";
            this.mostrarLosProductosToolStripMenuItem.Click += new System.EventHandler(this.mostrarLosProductosToolStripMenuItem_Click);
            // 
            // mostrarLosProductosConExistenciaImparToolStripMenuItem
            // 
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem.Name = "mostrarLosProductosConExistenciaImparToolStripMenuItem";
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem.Text = "Mostrar los productos con existencia impar";
            this.mostrarLosProductosConExistenciaImparToolStripMenuItem.Click += new System.EventHandler(this.mostrarLosProductosConExistenciaImparToolStripMenuItem_Click);
            // 
            // mostrarElProductoConMayorPrecioToolStripMenuItem
            // 
            this.mostrarElProductoConMayorPrecioToolStripMenuItem.Name = "mostrarElProductoConMayorPrecioToolStripMenuItem";
            this.mostrarElProductoConMayorPrecioToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.mostrarElProductoConMayorPrecioToolStripMenuItem.Text = "Mostrar el producto con mayor precio";
            this.mostrarElProductoConMayorPrecioToolStripMenuItem.Click += new System.EventHandler(this.mostrarElProductoConMayorPrecioToolStripMenuItem_Click);
            // 
            // mostrarElProductoConMenorPrecioToolStripMenuItem
            // 
            this.mostrarElProductoConMenorPrecioToolStripMenuItem.Name = "mostrarElProductoConMenorPrecioToolStripMenuItem";
            this.mostrarElProductoConMenorPrecioToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.mostrarElProductoConMenorPrecioToolStripMenuItem.Text = "Mostrar el producto con menor precio";
            this.mostrarElProductoConMenorPrecioToolStripMenuItem.Click += new System.EventHandler(this.mostrarElProductoConMenorPrecioToolStripMenuItem_Click);
            // 
            // mostrarSumaYPromedioDeTodosLosProductosToolStripMenuItem
            // 
            this.mostrarSumaYPromedioDeTodosLosProductosToolStripMenuItem.Name = "mostrarSumaYPromedioDeTodosLosProductosToolStripMenuItem";
            this.mostrarSumaYPromedioDeTodosLosProductosToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.mostrarSumaYPromedioDeTodosLosProductosToolStripMenuItem.Text = "Mostrar suma y promedio de todos los productos";
            this.mostrarSumaYPromedioDeTodosLosProductosToolStripMenuItem.Click += new System.EventHandler(this.mostrarSumaYPromedioDeTodosLosProductosToolStripMenuItem_Click);
            // 
            // mostrarElProductoDeMayorExistenciaToolStripMenuItem
            // 
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem.Name = "mostrarElProductoDeMayorExistenciaToolStripMenuItem";
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem.Text = "Mostrar el producto de mayor existencia";
            this.mostrarElProductoDeMayorExistenciaToolStripMenuItem.Click += new System.EventHandler(this.mostrarElProductoDeMayorExistenciaToolStripMenuItem_Click);
            // 
            // mostrarElProductoDeMenorrExistenciaToolStripMenuItem
            // 
            this.mostrarElProductoDeMenorrExistenciaToolStripMenuItem.Name = "mostrarElProductoDeMenorrExistenciaToolStripMenuItem";
            this.mostrarElProductoDeMenorrExistenciaToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.mostrarElProductoDeMenorrExistenciaToolStripMenuItem.Text = "Mostrar el producto de menor existencia";
            this.mostrarElProductoDeMenorrExistenciaToolStripMenuItem.Click += new System.EventHandler(this.mostrarElProductoDeMenorrExistenciaToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(123, 40);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(420, 158);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 55;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre del producto";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio del producto";
            this.columnHeader3.Width = 111;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Existencia del producto";
            this.columnHeader4.Width = 132;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 261);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombreDelProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porPrecioDelProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porExistenciaDeLosProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarLosProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarLosProductosConExistenciaImparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarElProductoConMayorPrecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarElProductoConMenorPrecioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarSumaYPromedioDeTodosLosProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarElProductoDeMayorExistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarElProductoDeMenorrExistenciaToolStripMenuItem;
    }
}

