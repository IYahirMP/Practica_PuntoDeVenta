namespace Practica.Venta
{
    partial class ModificarVenta
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
            this.SEGUNDO = new System.Windows.Forms.NumericUpDown();
            this.MINUTO = new System.Windows.Forms.NumericUpDown();
            this.HORA = new System.Windows.Forms.NumericUpDown();
            this.FECHA = new System.Windows.Forms.DateTimePicker();
            this.TOTAL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Actualizar = new System.Windows.Forms.Button();
            this.ID_VENTA = new System.Windows.Forms.ComboBox();
            this.ID_CLIENTE = new System.Windows.Forms.TextBox();
            this.Eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SEGUNDO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MINUTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HORA)).BeginInit();
            this.SuspendLayout();
            // 
            // SEGUNDO
            // 
            this.SEGUNDO.Location = new System.Drawing.Point(304, 93);
            this.SEGUNDO.Name = "SEGUNDO";
            this.SEGUNDO.Size = new System.Drawing.Size(57, 23);
            this.SEGUNDO.TabIndex = 45;
            // 
            // MINUTO
            // 
            this.MINUTO.Location = new System.Drawing.Point(229, 93);
            this.MINUTO.Name = "MINUTO";
            this.MINUTO.Size = new System.Drawing.Size(57, 23);
            this.MINUTO.TabIndex = 44;
            // 
            // HORA
            // 
            this.HORA.Location = new System.Drawing.Point(157, 93);
            this.HORA.Name = "HORA";
            this.HORA.Size = new System.Drawing.Size(57, 23);
            this.HORA.TabIndex = 43;
            // 
            // FECHA
            // 
            this.FECHA.Location = new System.Drawing.Point(157, 64);
            this.FECHA.Name = "FECHA";
            this.FECHA.Size = new System.Drawing.Size(204, 23);
            this.FECHA.TabIndex = 42;
            // 
            // TOTAL
            // 
            this.TOTAL.Location = new System.Drawing.Point(157, 122);
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.Size = new System.Drawing.Size(204, 23);
            this.TOTAL.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 40;
            this.label3.Text = "Total";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(12, 96);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(73, 15);
            this.labelHora.TabIndex = 39;
            this.labelHora.Text = "Hora(H:M:S)";
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(286, 171);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 38;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(1, 171);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 37;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Clave del cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Clave de la venta";
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(95, 171);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 46;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // ID_VENTA
            // 
            this.ID_VENTA.FormattingEnabled = true;
            this.ID_VENTA.Location = new System.Drawing.Point(157, 9);
            this.ID_VENTA.Name = "ID_VENTA";
            this.ID_VENTA.Size = new System.Drawing.Size(204, 23);
            this.ID_VENTA.TabIndex = 47;
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.Location = new System.Drawing.Point(157, 38);
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.Size = new System.Drawing.Size(204, 23);
            this.ID_CLIENTE.TabIndex = 48;
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(192, 171);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 49;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // ModificarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 198);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.ID_CLIENTE);
            this.Controls.Add(this.ID_VENTA);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.SEGUNDO);
            this.Controls.Add(this.MINUTO);
            this.Controls.Add(this.HORA);
            this.Controls.Add(this.FECHA);
            this.Controls.Add(this.TOTAL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarVenta";
            this.Text = "ModificarVenta";
            ((System.ComponentModel.ISupportInitialize)(this.SEGUNDO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MINUTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HORA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown SEGUNDO;
        private NumericUpDown MINUTO;
        private NumericUpDown HORA;
        private DateTimePicker FECHA;
        private TextBox TOTAL;
        private Label label3;
        private Label labelHora;
        private Button Limpiar;
        private Button Buscar;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button Actualizar;
        private ComboBox ID_VENTA;
        private TextBox ID_CLIENTE;
        private Button Eliminar;
    }
}