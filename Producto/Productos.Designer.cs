namespace Practica
{
    partial class Productos
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
            this.DESCRIPCION = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_PROD = new System.Windows.Forms.TextBox();
            this.ID_PROV = new System.Windows.Forms.ComboBox();
            this.Precio = new System.Windows.Forms.TextBox();
            this.StockMinimo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StockMaximo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.Location = new System.Drawing.Point(173, 78);
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.Size = new System.Drawing.Size(250, 23);
            this.DESCRIPCION.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Clave del proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Clave del producto";
            // 
            // ID_PROD
            // 
            this.ID_PROD.Location = new System.Drawing.Point(173, 23);
            this.ID_PROD.Name = "ID_PROD";
            this.ID_PROD.Size = new System.Drawing.Size(250, 23);
            this.ID_PROD.TabIndex = 1;
            // 
            // ID_PROV
            // 
            this.ID_PROV.FormattingEnabled = true;
            this.ID_PROV.Location = new System.Drawing.Point(173, 49);
            this.ID_PROV.Name = "ID_PROV";
            this.ID_PROV.Size = new System.Drawing.Size(250, 23);
            this.ID_PROV.TabIndex = 2;
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(173, 107);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(250, 23);
            this.Precio.TabIndex = 4;
            // 
            // StockMinimo
            // 
            this.StockMinimo.Location = new System.Drawing.Point(173, 162);
            this.StockMinimo.Name = "StockMinimo";
            this.StockMinimo.Size = new System.Drawing.Size(250, 23);
            this.StockMinimo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Stock mínimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Stock máximo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Precio";
            // 
            // StockMaximo
            // 
            this.StockMaximo.Location = new System.Drawing.Point(173, 136);
            this.StockMaximo.Name = "StockMaximo";
            this.StockMaximo.Size = new System.Drawing.Size(250, 23);
            this.StockMaximo.TabIndex = 5;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 234);
            this.Controls.Add(this.StockMaximo);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.StockMinimo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ID_PROV);
            this.Controls.Add(this.ID_PROD);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DESCRIPCION);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Productos";
            this.Text = "Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox DESCRIPCION;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox ID_PROD;
        private ComboBox ID_PROV;
        private TextBox Precio;
        private TextBox StockMinimo;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox StockMaximo;
    }
}