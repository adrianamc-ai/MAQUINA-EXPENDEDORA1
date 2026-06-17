using System;
using System.Windows.Forms; 

namespace MAQUINA_EXPENDEDORA
{
    internal class Producto
    {
        // Atributos privados 
        private string nombre;
        private double costo;
        private int existencia;
        private int codigo;

        //Propiedades publicas get (lectura)
        public int Codigo
        {
            get { return codigo; }

        }
        public string Nombre
        {
            get { return nombre; }

        }

        public double Costo
        {
            get { return costo; }

        }

        public int Existencia
        {
            get { return existencia; }

        }

        // Constructor para inicializar cada producto 
        public Producto(int codigo, string nombre, double costo, int existencia)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.costo = costo;
            this.existencia = existencia;
        }

        // Lógica de negocio:

        // Método procesarCompra
        public void ProcesarCompra(int cantidadAPedir)
        {
            //Validación 1: primero mostrar un error porque el cliente no puede pedir cantidades 0 o menores a 0
            if (cantidadAPedir <= 0)
            {                                                                          //nombre de ventana,  boton de aceptar   , icono que representa un mensaje de peligro
                MessageBox.Show("La cantidad " + cantidadAPedir + " no es válida.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validación 2: Stock suficiente
            if (existencia >= cantidadAPedir)
            {
                double totalCobro = costo * cantidadAPedir;
                existencia = existencia - cantidadAPedir; // Reducir inventario

                // Mensaje en ventana de éxito                                                                                                          //nombre de ventana,       boton de aceptar ,     icono que representa una compra exitosa
                MessageBox.Show("¡Compra exitosa!\n\nUsted adquirió: " + cantidadAPedir + " unidad(es) de " + nombre + "\nTotal a pagar: $" + totalCobro," Despachando Producto ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Validación 3: Stock insuficiente                                                                                            //nombre de ventana,   boton de aceptar , icono que representa un error                             
                MessageBox.Show("Transacción rechazada.\nNo hay suficiente cantidad de " + nombre + "\n\nDisponible en máquina: " + existencia , "Sin Inventario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método Abastecer
        public void Abastecer(int cantNuevosProductos)
        {
            //cuando un operador externo quiera aumentar al inventario disponible
            if (cantNuevosProductos > 0)
            {
                existencia = existencia + cantNuevosProductos;                                                                                         //nombre de ventana,   boton de aceptar , icono que representa una compra exitosa       
                MessageBox.Show("Se añadieron " + cantNuevosProductos + " piezas "+ "\n\nNueva cantidad disponible de " + nombre + " : " +  existencia ,"Modo Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                                                                            // nombre de ventana,    boton de aceptar    ,    mensaje de peligro
                MessageBox.Show("La cantidad a abastecer debe ser mayor a 0", "Error de Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
