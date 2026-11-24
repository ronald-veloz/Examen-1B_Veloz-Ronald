using System.Windows.Forms;
using System.Drawing;
namespace GestorPedidosCafeteria
{
    partial class frmPedidoCafeteria
    {
    
        private System.ComponentModel.IContainer components = null;

     
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.grpDetalles = new System.Windows.Forms.GroupBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblProductoCap = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblCantidadCap = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpCatalogo = new System.Windows.Forms.GroupBox();
            this.lvCatalogo = new System.Windows.Forms.ListView();
            this.colCatProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCatPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.rbtnMostrador = new System.Windows.Forms.RadioButton();
            this.rbtnEntrega = new System.Windows.Forms.RadioButton();
            this.chkPostre = new System.Windows.Forms.CheckBox();
            this.chkServilletas = new System.Windows.Forms.CheckBox();
            this.grpPedido = new System.Windows.Forms.GroupBox();
            this.lvPedido = new System.Windows.Forms.ListView();
            this.colPedProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPedCant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPedSubtotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.grpDetalles.SuspendLayout();
            this.grpCatalogo.SuspendLayout();
            this.grpOpciones.SuspendLayout();
            this.grpPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDetalles
            // 
            this.grpDetalles.Controls.Add(this.lblCliente);
            this.grpDetalles.Controls.Add(this.txtCliente);
            this.grpDetalles.Controls.Add(this.lblProductoCap);
            this.grpDetalles.Controls.Add(this.txtProducto);
            this.grpDetalles.Controls.Add(this.lblCantidadCap);
            this.grpDetalles.Controls.Add(this.txtCantidad);
            this.grpDetalles.Controls.Add(this.btnAgregar);
            this.grpDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetalles.Location = new System.Drawing.Point(10, 7);
            this.grpDetalles.Name = "grpDetalles";
            this.grpDetalles.Size = new System.Drawing.Size(614, 73);
            this.grpDetalles.TabIndex = 0;
            this.grpDetalles.TabStop = false;
            this.grpDetalles.Text = "Detalles del Pedido";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(10, 19);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(50, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(10, 36);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(215, 20);
            this.txtCliente.TabIndex = 0;
            // 
            // lblProductoCap
            // 
            this.lblProductoCap.AutoSize = true;
            this.lblProductoCap.Location = new System.Drawing.Point(244, 19);
            this.lblProductoCap.Name = "lblProductoCap";
            this.lblProductoCap.Size = new System.Drawing.Size(62, 13);
            this.lblProductoCap.TabIndex = 1;
            this.lblProductoCap.Text = "Producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(244, 36);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(202, 20);
            this.txtProducto.TabIndex = 2;
            this.txtProducto.TabStop = false;
            // 
            // lblCantidadCap
            // 
            this.lblCantidadCap.AutoSize = true;
            this.lblCantidadCap.Location = new System.Drawing.Point(463, 19);
            this.lblCantidadCap.Name = "lblCantidadCap";
            this.lblCantidadCap.Size = new System.Drawing.Size(61, 13);
            this.lblCantidadCap.TabIndex = 3;
            this.lblCantidadCap.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(463, 36);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(52, 20);
            this.txtCantidad.TabIndex = 1;
            this.txtCantidad.Text = "1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(525, 35);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar Ítem";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // grpCatalogo
            // 
            this.grpCatalogo.Controls.Add(this.lvCatalogo);
            this.grpCatalogo.Location = new System.Drawing.Point(10, 87);
            this.grpCatalogo.Name = "grpCatalogo";
            this.grpCatalogo.Size = new System.Drawing.Size(180, 231);
            this.grpCatalogo.TabIndex = 1;
            this.grpCatalogo.TabStop = false;
            this.grpCatalogo.Text = "Catálogo de Productos";
            // 
            // lvCatalogo
            // 
            this.lvCatalogo.CausesValidation = false;
            this.lvCatalogo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCatProducto,
            this.colCatPrecio});
            this.lvCatalogo.FullRowSelect = true;
            this.lvCatalogo.GridLines = true;
            this.lvCatalogo.HideSelection = false;
            this.lvCatalogo.Location = new System.Drawing.Point(6, 11);
            this.lvCatalogo.MultiSelect = false;
            this.lvCatalogo.Name = "lvCatalogo";
            this.lvCatalogo.Size = new System.Drawing.Size(168, 206);
            this.lvCatalogo.TabIndex = 0;
            this.lvCatalogo.UseCompatibleStateImageBehavior = false;
            this.lvCatalogo.View = System.Windows.Forms.View.Details;
            this.lvCatalogo.SelectedIndexChanged += new System.EventHandler(this.lvCatalogo_SelectedIndexChanged);
            // 
            // colCatProducto
            // 
            this.colCatProducto.Text = "Producto";
            this.colCatProducto.Width = 129;
            // 
            // colCatPrecio
            // 
            this.colCatPrecio.Text = "Precio";
            this.colCatPrecio.Width = 70;
            // 
            // grpOpciones
            // 
            this.grpOpciones.Controls.Add(this.rbtnMostrador);
            this.grpOpciones.Controls.Add(this.rbtnEntrega);
            this.grpOpciones.Controls.Add(this.chkPostre);
            this.grpOpciones.Controls.Add(this.chkServilletas);
            this.grpOpciones.Location = new System.Drawing.Point(196, 87);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Size = new System.Drawing.Size(164, 178);
            this.grpOpciones.TabIndex = 2;
            this.grpOpciones.TabStop = false;
            this.grpOpciones.Text = "Opciones y Extras";
            // 
            // rbtnMostrador
            // 
            this.rbtnMostrador.AutoSize = true;
            this.rbtnMostrador.Checked = true;
            this.rbtnMostrador.Location = new System.Drawing.Point(12, 28);
            this.rbtnMostrador.Name = "rbtnMostrador";
            this.rbtnMostrador.Size = new System.Drawing.Size(117, 17);
            this.rbtnMostrador.TabIndex = 0;
            this.rbtnMostrador.TabStop = true;
            this.rbtnMostrador.Text = "Retiro en mostrador";
            this.rbtnMostrador.UseVisualStyleBackColor = true;
            // 
            // rbtnEntrega
            // 
            this.rbtnEntrega.AutoSize = true;
            this.rbtnEntrega.Location = new System.Drawing.Point(12, 54);
            this.rbtnEntrega.Name = "rbtnEntrega";
            this.rbtnEntrega.Size = new System.Drawing.Size(142, 17);
            this.rbtnEntrega.TabIndex = 1;
            this.rbtnEntrega.Text = "Entrega en aula (+$0.50)";
            this.rbtnEntrega.UseVisualStyleBackColor = true;
            // 
            // chkPostre
            // 
            this.chkPostre.AutoSize = true;
            this.chkPostre.Location = new System.Drawing.Point(12, 105);
            this.chkPostre.Name = "chkPostre";
            this.chkPostre.Size = new System.Drawing.Size(134, 17);
            this.chkPostre.TabIndex = 2;
            this.chkPostre.Text = "Postre del día (+$1.00)";
            this.chkPostre.UseVisualStyleBackColor = true;
            // 
            // chkServilletas
            // 
            this.chkServilletas.AutoSize = true;
            this.chkServilletas.Location = new System.Drawing.Point(12, 142);
            this.chkServilletas.Name = "chkServilletas";
            this.chkServilletas.Size = new System.Drawing.Size(129, 17);
            this.chkServilletas.TabIndex = 3;
            this.chkServilletas.Text = "Servilletas / Cubiertos";
            this.chkServilletas.UseVisualStyleBackColor = true;
            // 
            // grpPedido
            // 
            this.grpPedido.Controls.Add(this.lvPedido);
            this.grpPedido.Location = new System.Drawing.Point(366, 87);
            this.grpPedido.Name = "grpPedido";
            this.grpPedido.Size = new System.Drawing.Size(258, 217);
            this.grpPedido.TabIndex = 3;
            this.grpPedido.TabStop = false;
            this.grpPedido.Text = "Pedido Actual";
            // 
            // lvPedido
            // 
            this.lvPedido.CausesValidation = false;
            this.lvPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPedProducto,
            this.colPedCant,
            this.colPedSubtotal});
            this.lvPedido.FullRowSelect = true;
            this.lvPedido.GridLines = true;
            this.lvPedido.HideSelection = false;
            this.lvPedido.Location = new System.Drawing.Point(7, 19);
            this.lvPedido.MultiSelect = false;
            this.lvPedido.Name = "lvPedido";
            this.lvPedido.Size = new System.Drawing.Size(243, 191);
            this.lvPedido.TabIndex = 0;
            this.lvPedido.UseCompatibleStateImageBehavior = false;
            this.lvPedido.View = System.Windows.Forms.View.Details;
            // 
            // colPedProducto
            // 
            this.colPedProducto.Text = "Producto";
            this.colPedProducto.Width = 120;
            // 
            // colPedCant
            // 
            this.colPedCant.Text = "Cant.";
            this.colPedCant.Width = 45;
            // 
            // colPedSubtotal
            // 
            this.colPedSubtotal.Text = "Subtotal";
            this.colPedSubtotal.Width = 70;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(401, 307);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(223, 26);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total: $0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEstado
            // 
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(6, 334);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(255, 30);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado: Seleccione un producto.";
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.SystemColors.Info;
            this.btnQuitar.CausesValidation = false;
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Location = new System.Drawing.Point(401, 340);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(107, 24);
            this.btnQuitar.TabIndex = 4;
            this.btnQuitar.Text = "Quitar Seleccionado";
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.CausesValidation = false;
            this.btnLimpiar.Location = new System.Drawing.Point(517, 340);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 24);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar Pedido";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // frmPedidoCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 376);
            this.Controls.Add(this.grpDetalles);
            this.Controls.Add(this.grpCatalogo);
            this.Controls.Add(this.grpOpciones);
            this.Controls.Add(this.grpPedido);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnLimpiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPedidoCafeteria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Rápido de Pedidos - Cafetería Universitaria";
            this.grpDetalles.ResumeLayout(false);
            this.grpDetalles.PerformLayout();
            this.grpCatalogo.ResumeLayout(false);
            this.grpOpciones.ResumeLayout(false);
            this.grpOpciones.PerformLayout();
            this.grpPedido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpDetalles;
        private GroupBox grpCatalogo;
        private GroupBox grpOpciones;
        private GroupBox grpPedido;
        private Label lblCliente;
        private Label lblProductoCap;
        private Label lblCantidadCap;
        private ColumnHeader colCatProducto;
        private ColumnHeader colCatPrecio;
        private ColumnHeader colPedProducto;
        private ColumnHeader colPedCant;
        private ColumnHeader colPedSubtotal;

        private ListView lvCatalogo;
        private TextBox txtCliente;
        private TextBox txtProducto;
        private TextBox txtCantidad;
        private RadioButton rbtnMostrador;
        private RadioButton rbtnEntrega;
        private CheckBox chkPostre;
        private CheckBox chkServilletas;
        private ListView lvPedido;
        private Button btnAgregar;
        private Button btnQuitar;
        private Button btnLimpiar;
        private Label lblEstado;
        private Label lblTotal;
    }
}
