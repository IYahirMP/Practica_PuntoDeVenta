namespace Practica
{
    partial class DetalleVentas
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CANTIDAD = new System.Windows.Forms.TextBox();
            this.ID_PROD = new System.Windows.Forms.TextBox();
            this.ID_VENTA = new System.Windows.Forms.TextBox();
            this.ID_DV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.Location = new System.Drawing.Point(167, 107);
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Size = new System.Drawing.Size(135, 23);
            this.CANTIDAD.TabIndex = 20;
            // 
            // ID_PROD
            // 
            this.ID_PROD.Location = new System.Drawing.Point(167, 78);
            this.ID_PROD.Name = "ID_PROD";
            this.ID_PROD.Size = new System.Drawing.Size(135, 23);
            this.ID_PROD.TabIndex = 19;
            // 
            // ID_VENTA
            // 
            this.ID_VENTA.Location = new System.Drawing.Point(167, 49);
            this.ID_VENTA.Name = "ID_VENTA";
            this.ID_VENTA.Size = new System.Drawing.Size(135, 23);
            this.ID_VENTA.TabIndex = 18;
            // 
            // ID_DV
            // 
            this.ID_DV.Location = new System.Drawing.Point(167, 20);
            this.ID_DV.Name = "ID_DV";
            this.ID_DV.Size = new System.Drawing.Size(135, 23);
            this.ID_DV.TabIndex = 17;
            this.ID_DV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Clave del producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Clave de la venta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Clave del detalle";
            // 
            // DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 224);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CANTIDAD);
            this.Controls.Add(this.ID_PROD);
            this.Controls.Add(this.ID_VENTA);
            this.Controls.Add(this.ID_DV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DetalleVenta";
            this.Text = "DetalleVenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox CANTIDAD;
        private TextBox ID_PROD;
        private TextBox ID_VENTA;
        private TextBox ID_DV;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}