using MAQUINA_EXPENDEDORA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFFETERIA.MAQUINA_EXPENDEDORA
{
    public partial class MaquinaExp : Form
    {
        private Producto[] vitrina = new Producto[4];
        public MaquinaExp()
        {
            InitializeComponent();
            InicializarProductos();
            ActualizarVitrinaVisual();
        }

        // 1. Cargar el inventario iy el menú al abrir la app
        private void InicializarProductos()
        {
            vitrina[0] = new Producto(1, "Agua", 15.00, 10);
            vitrina[1] = new Producto(2, "Chips", 18.00, 10);
            vitrina[2] = new Producto(3, "Gansito", 12.50, 10);
            vitrina[3] = new Producto(4, "CocaCola", 20.00, 10);

            // opciones del ComboBox con los nombress
            cmbProductos.Items.Clear();
            foreach (Producto prod in vitrina)
            {
                cmbProductos.Items.Add(prod.Nombre);
            }

            // Dejar el primer producto seleccionado para que no haya errores
            if (cmbProductos.Items.Count > 0)
            {
                cmbProductos.SelectedIndex = 0;
            }
        }

        // 2. generar otra vez la lista cada cuando cambien las exist
        private void ActualizarVitrinaVisual()
        {
            lstVitrina.Items.Clear();
            lstVitrina.Items.Add("CODIGO| PRODUCTO   | PRECIO   | EXISTENCIA");
            lstVitrina.Items.Add("------------------------------------------------");

            for (int i = 0; i < vitrina.Length; i++)
            { 
                string renglon = $"{vitrina[i].Codigo,-5} | {vitrina[i].Nombre,-10} | ${vitrina[i].Costo,-7} | {vitrina[i].Existencia,-5}";
                lstVitrina.Items.Add(renglon);
            }
        }

        // 3. BOTÓN COMPRAR
        private void btnComprar_Click(object sender, EventArgs e)
        {
            int posicionSeleccionada = cmbProductos.SelectedIndex;

            if (posicionSeleccionada >= 0)
            {
                // valor numérico
                int cantidad = (int)txtCantidad.Value;

                // método encapsulado de la cla se
                vitrina[posicionSeleccionada].ProcesarCompra(cantidad);

                // actualización de la pantalla
                ActualizarVitrinaVisual();
            }
        }

        // 4. BOTÓN SURTIR
        private void btnAbastecer_Click(object sender, EventArgs e)
        {
            int posicionSeleccionada = cmbProductos.SelectedIndex;

            if (posicionSeleccionada >= 0)
            {
                int piezasNuevas = (int)txtCantidad.Value;

                // método de abastecimiento
                vitrina[posicionSeleccionada].Abastecer(piezasNuevas);

                // actualización de la pantalla
                ActualizarVitrinaVisual();
            }
        }

        private void MaquinaExp_Load(object sender, EventArgs e)
        {

        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

