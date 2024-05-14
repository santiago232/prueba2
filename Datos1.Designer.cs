using System;
using System.Windows.Forms;

namespace ProyectoProgra21
{
    public partial class Formula1 : Form
    {
        private TextBox txtNombre;
        private TextBox txtDPI;
        private TextBox txtDireccion;
        private DateTimePicker dtpFecha;
        private TextBox txtNombreProducto;
        private NumericUpDown numericCosto;
        private NumericUpDown numericMonto;
        private Button btnRegistrar;

        public Formula1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDPI = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.numericCosto = new System.Windows.Forms.NumericUpDown();
            this.numericMonto = new System.Windows.Forms.NumericUpDown();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericCosto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre, txtDPI, txtDireccion, dtpFecha, txtNombreProducto
            // numericCosto, numericMonto y btnRegistrar son controles que puedes
            // configurar en el diseñador de Windows Forms.
            // Asegúrate de asignarles propiedades como Name, Location, Size, Text, etc.
            // 
            // Aquí se incluye el código generado automáticamente al diseñar los controles.
            // 

            // Configuración de los controles
            // ...

            // Configuración del formulario
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.numericMonto);
            this.Controls.Add(this.numericCosto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtDPI);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Manejo de Archivos 2";
            ((System.ComponentModel.ISupportInitialize)(this.numericCosto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMonto)).EndInit();
            this.ResumeLayout(false);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los campos
            string nombre = txtNombre.Text;
            string dpi = txtDPI.Text;
            string direccion = txtDireccion.Text;
            DateTime fecha = dtpFecha.Value;
            string nombreProducto = txtNombreProducto.Text;
            decimal costo = numericCosto.Value;
            decimal monto = numericMonto.Value;
            int id = ObtenerNuevoID(); // Función para obtener un nuevo ID

            // Aquí puedes procesar los datos, como guardarlos en una lista o realizar cálculos
            // Por ahora, simplemente los mostraremos en un MessageBox
            string mensaje = $"Nombre: {nombre}\nDPI: {dpi}\nDirección: {direccion}\nFecha: {fecha.ToShortDateString()}\nNombre del Producto: {nombreProducto}\nCosto: {costo}\nMonto: {monto}\nID: {id}";
            MessageBox.Show(mensaje, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int ObtenerNuevoID()
        {
            // Esta función debería obtener un nuevo ID basado en la lógica de tu aplicación
            // Por ahora, simplemente devolveremos un número aleatorio
            Random rnd = new Random();
            return rnd.Next(1000, 9999);
        }
    }
}


