namespace Presentacion
{
    partial class fm_usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_nombre = new System.Windows.Forms.TextBox();
            this.tx_apellido = new System.Windows.Forms.TextBox();
            this.tx_documento = new System.Windows.Forms.TextBox();
            this.tx_telefono = new System.Windows.Forms.TextBox();
            this.tx_usuario = new System.Windows.Forms.TextBox();
            this.tx_contraseña = new System.Windows.Forms.TextBox();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Usuario";
            // 
            // tx_nombre
            // 
            this.tx_nombre.Location = new System.Drawing.Point(102, 15);
            this.tx_nombre.Name = "tx_nombre";
            this.tx_nombre.Size = new System.Drawing.Size(164, 20);
            this.tx_nombre.TabIndex = 6;
            // 
            // tx_apellido
            // 
            this.tx_apellido.Location = new System.Drawing.Point(350, 15);
            this.tx_apellido.Name = "tx_apellido";
            this.tx_apellido.Size = new System.Drawing.Size(179, 20);
            this.tx_apellido.TabIndex = 7;
            // 
            // tx_documento
            // 
            this.tx_documento.Location = new System.Drawing.Point(104, 60);
            this.tx_documento.Name = "tx_documento";
            this.tx_documento.Size = new System.Drawing.Size(109, 20);
            this.tx_documento.TabIndex = 8;
            // 
            // tx_telefono
            // 
            this.tx_telefono.Location = new System.Drawing.Point(350, 57);
            this.tx_telefono.Name = "tx_telefono";
            this.tx_telefono.Size = new System.Drawing.Size(99, 20);
            this.tx_telefono.TabIndex = 9;
            // 
            // tx_usuario
            // 
            this.tx_usuario.Location = new System.Drawing.Point(102, 99);
            this.tx_usuario.Name = "tx_usuario";
            this.tx_usuario.Size = new System.Drawing.Size(111, 20);
            this.tx_usuario.TabIndex = 10;
            // 
            // tx_contraseña
            // 
            this.tx_contraseña.Location = new System.Drawing.Point(350, 106);
            this.tx_contraseña.Name = "tx_contraseña";
            this.tx_contraseña.Size = new System.Drawing.Size(99, 20);
            this.tx_contraseña.TabIndex = 11;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(39, 142);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 12;
            this.btn_registrar.Text = "REGISTRAR";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(138, 142);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 13;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(269, 142);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 14;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(394, 142);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 15;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(507, 146);
            this.dataGridView1.TabIndex = 16;
            // 
            // fm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 329);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.tx_contraseña);
            this.Controls.Add(this.tx_usuario);
            this.Controls.Add(this.tx_telefono);
            this.Controls.Add(this.tx_documento);
            this.Controls.Add(this.tx_apellido);
            this.Controls.Add(this.tx_nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fm_usuarios";
            this.Text = "fm_usuarios";
            this.Load += new System.EventHandler(this.fm_usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_nombre;
        private System.Windows.Forms.TextBox tx_apellido;
        private System.Windows.Forms.TextBox tx_documento;
        private System.Windows.Forms.TextBox tx_telefono;
        private System.Windows.Forms.TextBox tx_usuario;
        private System.Windows.Forms.TextBox tx_contraseña;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}