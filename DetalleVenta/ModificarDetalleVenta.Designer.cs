namespace Practica.DetalleVenta
{
    partial class ModificarDetalleVenta
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
            this.Limpiar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.CANTIDAD = new System.Windows.Forms.TextBox();
            this.ID_PROD = new System.Windows.Forms.TextBox();
            this.ID_VENTA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.ID_DV = new System.Windows.Forms.ComboBox();
            this.Eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(304, 125);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 33;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(107, 125);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 32;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.Location = new System.Drawing.Point(157, 93);
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Size = new System.Drawing.Size(211, 23);
            this.CANTIDAD.TabIndex = 31;
            // 
            // ID_PROD
            // 
            this.ID_PROD.Location = new System.Drawing.Point(157, 64);
            this.ID_PROD.Name = "ID_PROD";
            this.ID_PROD.Size = new System.Drawing.Size(211, 23);
            this.ID_PROD.TabIndex = 30;
            // 
            // ID_VENTA
            // 
            this.ID_VENTA.Location = new System.Drawing.Point(157, 35);
            this.ID_VENTA.Name = "ID_VENTA";
            this.ID_VENTA.Size = new System.Drawing.Size(211, 23);
            this.ID_VENTA.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Clave del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Clave de la venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Clave del detalle";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(11, 125);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 34;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // ID_DV
            // 
            this.ID_DV.FormattingEnabled = true;
            this.ID_DV.Location = new System.Drawing.Point(157, 6);
            this.ID_DV.Name = "ID_DV";
            this.ID_DV.Size = new System.Drawing.Size(211, 23);
            this.ID_DV.TabIndex = 35;
            this.ID_DV.SelectedIndexChanged += new System.EventHandler(this.ID_DV_SelectedIndexChanged);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(205, 125);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 36;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // ModificarDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 153);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.ID_DV);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.CANTIDAD);
            this.Controls.Add(this.ID_PROD);
            this.Controls.Add(this.ID_VENTA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarDetalleVenta";
            this.Text = "ModificarDetalleVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Limpiar;
        private Button Actualizar;
        private TextBox CANTIDAD;
        private TextBox ID_PROD;
        private TextBox ID_VENTA;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button Buscar;
        private ComboBox ID_DV;
        private Button Eliminar;
    }
}