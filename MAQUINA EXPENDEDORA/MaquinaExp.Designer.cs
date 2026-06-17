namespace CAFFETERIA.MAQUINA_EXPENDEDORA
{
    partial class MaquinaExp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpOperaciones = new System.Windows.Forms.GroupBox();
            this.btnAbastecer = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpVitrina = new System.Windows.Forms.GroupBox();
            this.lstVitrina = new System.Windows.Forms.ListBox();
            this.grpOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            this.grpVitrina.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOperaciones
            // 
            this.grpOperaciones.BackColor = System.Drawing.Color.SteelBlue;
            this.grpOperaciones.Controls.Add(this.btnAbastecer);
            this.grpOperaciones.Controls.Add(this.btnComprar);
            this.grpOperaciones.Controls.Add(this.txtCantidad);
            this.grpOperaciones.Controls.Add(this.label2);
            this.grpOperaciones.Controls.Add(this.cmbProductos);
            this.grpOperaciones.Controls.Add(this.label1);
            this.grpOperaciones.Location = new System.Drawing.Point(12, 12);
            this.grpOperaciones.Name = "grpOperaciones";
            this.grpOperaciones.Size = new System.Drawing.Size(260, 426);
            this.grpOperaciones.TabIndex = 0;
            this.grpOperaciones.TabStop = false;
            this.grpOperaciones.Text = "Panel de control de  venta";
            // 
            // btnAbastecer
            // 
            this.btnAbastecer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAbastecer.Location = new System.Drawing.Point(26, 323);
            this.btnAbastecer.Name = "btnAbastecer";
            this.btnAbastecer.Size = new System.Drawing.Size(200, 55);
            this.btnAbastecer.TabIndex = 4;
            this.btnAbastecer.Text = "Surtir Inventario";
            this.btnAbastecer.UseVisualStyleBackColor = false;
            this.btnAbastecer.Click += new System.EventHandler(this.btnAbastecer_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnComprar.Location = new System.Drawing.Point(26, 251);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(200, 46);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(25, 175);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(201, 22);
            this.txtCantidad.TabIndex = 3;
            this.txtCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCantidad.ValueChanged += new System.EventHandler(this.txtCantidad_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de Unidades: ";
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(26, 82);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(200, 24);
            this.cmbProductos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el producto";
            // 
            // grpVitrina
            // 
            this.grpVitrina.BackColor = System.Drawing.Color.SteelBlue;
            this.grpVitrina.Controls.Add(this.lstVitrina);
            this.grpVitrina.Location = new System.Drawing.Point(278, 12);
            this.grpVitrina.Name = "grpVitrina";
            this.grpVitrina.Size = new System.Drawing.Size(510, 426);
            this.grpVitrina.TabIndex = 1;
            this.grpVitrina.TabStop = false;
            this.grpVitrina.Text = "Vitrina de la máquina";
            // 
            // lstVitrina
            // 
            this.lstVitrina.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lstVitrina.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVitrina.FormattingEnabled = true;
            this.lstVitrina.ItemHeight = 20;
            this.lstVitrina.Location = new System.Drawing.Point(21, 29);
            this.lstVitrina.Name = "lstVitrina";
            this.lstVitrina.Size = new System.Drawing.Size(470, 384);
            this.lstVitrina.TabIndex = 0;
            // 
            // MaquinaExp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpVitrina);
            this.Controls.Add(this.grpOperaciones);
            this.Name = "MaquinaExp";
            this.Text = "Máquina Expendedora de Snacks";
            this.Load += new System.EventHandler(this.MaquinaExp_Load);
            this.grpOperaciones.ResumeLayout(false);
            this.grpOperaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            this.grpVitrina.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOperaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Button btnAbastecer;
        private System.Windows.Forms.GroupBox grpVitrina;
        private System.Windows.Forms.ListBox lstVitrina;
    }
}