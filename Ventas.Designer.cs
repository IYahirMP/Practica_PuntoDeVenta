namespace Practica
{
    partial class Ventas
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
            this.FECHA = new System.Windows.Forms.TextBox();
            this.ID_CLIENTE = new System.Windows.Forms.TextBox();
            this.ID_VENTA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.TextBox();
            this.Hora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(186, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FECHA
            // 
            this.FECHA.Location = new System.Drawing.Point(167, 79);
            this.FECHA.Name = "FECHA";
            this.FECHA.Size = new System.Drawing.Size(135, 23);
            this.FECHA.TabIndex = 19;
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.Location = new System.Drawing.Point(167, 50);
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.Size = new System.Drawing.Size(135, 23);
            this.ID_CLIENTE.TabIndex = 18;
            // 
            // ID_VENTA
            // 
            this.ID_VENTA.Location = new System.Drawing.Point(167, 21);
            this.ID_VENTA.Name = "ID_VENTA";
            this.ID_VENTA.Size = new System.Drawing.Size(135, 23);
            this.ID_VENTA.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Clave del cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Clave de la venta";
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(167, 137);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(135, 23);
            this.Total.TabIndex = 27;
            // 
            // Hora
            // 
            this.Hora.Location = new System.Drawing.Point(167, 108);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(135, 23);
            this.Hora.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Total";
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(22, 111);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(33, 15);
            this.labelHora.TabIndex = 24;
            this.labelHora.Text = "Hora";
            this.labelHora.Click += new System.EventHandler(this.label5_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FECHA);
            this.Controls.Add(this.ID_CLIENTE);
            this.Controls.Add(this.ID_VENTA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox FECHA;
        private TextBox ID_CLIENTE;
        private TextBox ID_VENTA;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox Total;
        private TextBox Hora;
        private Label label3;
        private Label labelHora;
    }
}