namespace Practica.Cliente
{
    partial class ModificarCliente
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
            this.RFC = new System.Windows.Forms.TextBox();
            this.NOMBRE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.ID_CLIENTE = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(291, 113);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 31;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(104, 113);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 30;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // RFC
            // 
            this.RFC.Location = new System.Drawing.Point(153, 70);
            this.RFC.Name = "RFC";
            this.RFC.Size = new System.Drawing.Size(213, 23);
            this.RFC.TabIndex = 29;
            // 
            // NOMBRE
            // 
            this.NOMBRE.Location = new System.Drawing.Point(153, 41);
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Size = new System.Drawing.Size(213, 23);
            this.NOMBRE.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "RFC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Clave del cliente";
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(198, 113);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 32;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(12, 113);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 33;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.FormattingEnabled = true;
            this.ID_CLIENTE.Location = new System.Drawing.Point(152, 12);
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            this.ID_CLIENTE.Size = new System.Drawing.Size(214, 23);
            this.ID_CLIENTE.TabIndex = 34;
            // 
            // ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 162);
            this.Controls.Add(this.ID_CLIENTE);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.RFC);
            this.Controls.Add(this.NOMBRE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificarCliente";
            this.Text = "ModificarCliente";
            this.Load += new System.EventHandler(this.ModificarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Limpiar;
        private Button Actualizar;
        private TextBox RFC;
        private TextBox NOMBRE;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button Eliminar;
        private Button Buscar;
        private ComboBox ID_CLIENTE;
    }
}