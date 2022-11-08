namespace Practica.Producto
{
    partial class ModificarProducto
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
            this.StockMaximo = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.TextBox();
            this.StockMinimo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ID_PROV = new System.Windows.Forms.ComboBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.DESCRIPCION = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_PROD = new System.Windows.Forms.ComboBox();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StockMaximo
            // 
            this.StockMaximo.Location = new System.Drawing.Point(157, 122);
            this.StockMaximo.Name = "StockMaximo";
            this.StockMaximo.Size = new System.Drawing.Size(250, 23);
            this.StockMaximo.TabIndex = 33;
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(157, 93);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(250, 23);
            this.Precio.TabIndex = 32;
            // 
            // StockMinimo
            // 
            this.StockMinimo.Location = new System.Drawing.Point(157, 148);
            this.StockMinimo.Name = "StockMinimo";
            this.StockMinimo.Size = new System.Drawing.Size(250, 23);
            this.StockMinimo.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Stock mínimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Stock máximo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 40;
            this.label6.Text = "Precio";
            // 
            // ID_PROV
            // 
            this.ID_PROV.FormattingEnabled = true;
            this.ID_PROV.Location = new System.Drawing.Point(157, 35);
            this.ID_PROV.Name = "ID_PROV";
            this.ID_PROV.Size = new System.Drawing.Size(250, 23);
            this.ID_PROV.TabIndex = 30;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(333, 185);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 36;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(144, 185);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 35;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.Location = new System.Drawing.Point(157, 64);
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.Size = new System.Drawing.Size(250, 23);
            this.DESCRIPCION.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Clave del proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Clave del producto";
            // 
            // ID_PROD
            // 
            this.ID_PROD.FormattingEnabled = true;
            this.ID_PROD.Location = new System.Drawing.Point(157, 6);
            this.ID_PROD.Name = "ID_PROD";
            this.ID_PROD.Size = new System.Drawing.Size(251, 23);
            this.ID_PROD.TabIndex = 43;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(238, 185);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 44;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(20, 185);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 45;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // ModificarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 217);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.ID_PROD);
            this.Controls.Add(this.StockMaximo);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.StockMinimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ID_PROV);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.DESCRIPCION);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarProducto";
            this.Text = "ModificarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox StockMaximo;
        private TextBox Precio;
        private TextBox StockMinimo;
        private Label label3;
        private Label label5;
        private Label label6;
        private ComboBox ID_PROV;
        private Button Limpiar;
        private Button Actualizar;
        private TextBox DESCRIPCION;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox ID_PROD;
        private Button Eliminar;
        private Button Buscar;
    }
}