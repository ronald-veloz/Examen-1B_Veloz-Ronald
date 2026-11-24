//Realizado Por Veloz Quiñonez Ronald Leandro

using System;
using System.Globalization;
using System.Windows.Forms;

namespace GestorPedidosCafeteria
{
    public partial class frmPedidoCafeteria : Form
    {

        private const decimal RECARGO_ENTREGA = 0.50m;
        private const decimal EXTRA_POSTRE = 1.00m;


        private static readonly CultureInfo Cultura = CultureInfo.InvariantCulture;

        //Creacion del menú de productos
        private static readonly (string Nombre, decimal Precio)[] Catalogo =
        {
            ("Empanada de queso",           1.25m),
            ("Sánduche de pollo",           2.50m),
            ("Bolón de verde mixto",        2.25m),
            ("Humita tradicional",          1.50m),
            ("Tostada con queso",           1.00m),
            ("Café pasado",                 0.85m),
            ("Chocolate caliente",          1.35m),
            ("Jugo natural (naranja/mora)", 1.50m),
            ("Batido de fruta",             2.00m),
            ("Botella de agua",             0.75m),
        };

        public frmPedidoCafeteria()
        {
            InitializeComponent();
        }

        private static string FormatoDinero(decimal monto) => "$" + monto.ToString("0.00", Cultura);

        //seteo de la cantidad de inicio de un p`roducto sea 1 y si es menor a eso, lanzar una advertencia.
        private bool CantidadValida(out int cantidad)
        {
            return int.TryParse(txtCantidad.Text.Trim(), NumberStyles.None, Cultura, out cantidad)
                   && cantidad >= 1;
        }

        private void ActualizarEstadoBotonAgregar()
        {
            btnAgregar.Enabled = !string.IsNullOrWhiteSpace(txtProducto.Text) && CantidadValida(out _);
        }

        //Obtener el precio del producto 
        private bool TryObtenerPrecio(string producto, out decimal precio)
        {
            foreach (ListViewItem fila in lvCatalogo.Items)
            {
                if (fila.Text == producto && fila.Tag is decimal p)
                {
                    precio = p;
                    return true;
                }
            }
            precio = 0m;
            return false;
        }

        //Luego de tener el precio lee si agrego otra opcion de las extras para calcular su total   
        private void ActualizarTotal()
        {
            decimal total = 0m;

            foreach (ListViewItem fila in lvPedido.Items)
            {
                if (fila.Tag is decimal subtotal)
                    total += subtotal;
            }

            if (rbtnEntrega.Checked) total += RECARGO_ENTREGA;
            if (chkPostre.Checked) total += EXTRA_POSTRE;

            lblTotal.Text = "Total: " + FormatoDinero(total);
        }

        //Carga los items de los porductos    
        private void frmPedidoCafeteria_Load(object sender, EventArgs e)
        {

            lvCatalogo.Items.Clear();
            lvPedido.Items.Clear();


            foreach (var (nombre, precio) in Catalogo)
            {
                var item = new ListViewItem(nombre) { Tag = precio };
                item.SubItems.Add(FormatoDinero(precio));
                lvCatalogo.Items.Add(item);
            }


            rbtnMostrador.Checked = true;
            chkPostre.Checked = false;
            chkServilletas.Checked = false;
            txtProducto.Clear();
            txtCantidad.Text = "1";
            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;

            lblTotal.Text = "Total: $0.00";
            lblEstado.Text = "Estado: Seleccione un producto.";
        }


        private void lvCatalogo_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lvCatalogo.SelectedItems.Count == 0) return;

            ListViewItem fila = lvCatalogo.SelectedItems[0];
            txtProducto.Text = fila.Text;                    
            decimal precio = fila.Tag is decimal p ? p : 0m; 

            ActualizarEstadoBotonAgregar();                  
            lblEstado.Text = $"Estado: Producto seleccionado: {fila.Text} ({FormatoDinero(precio)}).";
        }

        private void lvPedido_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnQuitar.Enabled = lvPedido.SelectedItems.Count > 0;
        }


        private void txtCantidad_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!CantidadValida(out _))
            {
                e.Cancel = true; 
                lblEstado.Text = "Error: La cantidad debe ser un entero mayor o igual a 1.";
                txtCantidad.SelectAll();
            }
        }


        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonAgregar();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotonAgregar();
        }


        private void rbtnEntrega_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal(); 
            lblEstado.Text = rbtnEntrega.Checked
                ? "Estado: Opción aplicada: Entrega en aula (+$0.50)."
                : "Estado: Opción aplicada: Retiro en mostrador.";
        }

        private void chkPostre_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal(); 
            lblEstado.Text = chkPostre.Checked
                ? "Estado: Opción aplicada: Postre del día (+$1.00)."
                : "Estado: Opción retirada: Postre del día.";
        }

        private void chkServilletas_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotal();
            lblEstado.Text = chkServilletas.Checked
                ? "Estado: Opción aplicada: Servilletas / Cubiertos (sin costo)."
                : "Estado: Opción retirada: Servilletas / Cubiertos.";
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
         
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                lblEstado.Text = "Error: Ingrese el nombre del cliente.";
                txtCliente.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                lblEstado.Text = "Error: Seleccione un producto del catálogo.";
                return;
            }

            if (!CantidadValida(out int cantidad))
            {
                lblEstado.Text = "Error: La cantidad debe ser un entero mayor o igual a 1.";
                txtCantidad.Focus();
                txtCantidad.SelectAll();
                return;
            }

            if (!TryObtenerPrecio(txtProducto.Text, out decimal precio))
            {
                lblEstado.Text = "Error: El producto no existe en el catálogo.";
                return;
            }

            decimal subtotal = cantidad * precio;

            var fila = new ListViewItem(txtProducto.Text) { Tag = subtotal };
            fila.SubItems.Add(cantidad.ToString(Cultura));
            fila.SubItems.Add(FormatoDinero(subtotal));
            lvPedido.Items.Add(fila);

            ActualizarTotal();
            txtCantidad.Text = "1";
            lblEstado.Text = $"Estado: '{txtProducto.Text}' agregado (Cant: {cantidad}, Subtotal: {FormatoDinero(subtotal)}).";
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (lvPedido.SelectedItems.Count == 0)
            {
                lblEstado.Text = "Error: Seleccione una fila del pedido para quitar.";
                return;
            }

            ListViewItem fila = lvPedido.SelectedItems[0];
            string nombre = fila.Text;
            lvPedido.Items.Remove(fila);

            ActualizarTotal();
            btnQuitar.Enabled = lvPedido.SelectedItems.Count > 0;
            lblEstado.Text = $"Estado: '{nombre}' eliminado del pedido.";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lvPedido.Items.Clear();
            txtCliente.Clear();
            txtProducto.Clear();
            lvCatalogo.SelectedItems.Clear();
            txtCantidad.Text = "1";

            rbtnMostrador.Checked = true;
            chkPostre.Checked = false;
            chkServilletas.Checked = false;

            btnAgregar.Enabled = false;
            btnQuitar.Enabled = false;

            ActualizarTotal(); 
            lblEstado.Text = "Estado: Pedido reiniciado."; 
        }

        private void lvCatalogo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //No se borra, da error en el Diseño
        }
   
}
    }

