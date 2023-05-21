namespace _6_Formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_horasTrabajadas = new System.Windows.Forms.TextBox();
            this.txt_horasExtras = new System.Windows.Forms.TextBox();
            this.txt_vhoraTrabajo = new System.Windows.Forms.TextBox();
            this.txt_vhoraExtra = new System.Windows.Forms.TextBox();
            this.txt_thorasTrabajadas = new System.Windows.Forms.TextBox();
            this.txt_thorasExtras = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.txt_neto = new System.Windows.Forms.TextBox();
            this.txt_nombreP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad Horas Trabajadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de Horas Extras";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor de Hora Trabajo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor de hora Extra";
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.DarkKhaki;
            this.btn_calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_calcular.Location = new System.Drawing.Point(321, 347);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 5;
            this.btn_calcular.Text = "CALCULAR";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Transparent;
            this.btn_limpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_limpiar.Location = new System.Drawing.Point(321, 402);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 6;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.Transparent;
            this.btn_salir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_salir.Location = new System.Drawing.Point(321, 454);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Horas Trabajadas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Horas Extras";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Sub Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 459);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Descuento  del 5%";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 494);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "NETO";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(213, 70);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(158, 20);
            this.txt_nombre.TabIndex = 13;
            // 
            // txt_horasTrabajadas
            // 
            this.txt_horasTrabajadas.Location = new System.Drawing.Point(213, 121);
            this.txt_horasTrabajadas.Name = "txt_horasTrabajadas";
            this.txt_horasTrabajadas.Size = new System.Drawing.Size(80, 20);
            this.txt_horasTrabajadas.TabIndex = 14;
            // 
            // txt_horasExtras
            // 
            this.txt_horasExtras.Location = new System.Drawing.Point(213, 175);
            this.txt_horasExtras.Name = "txt_horasExtras";
            this.txt_horasExtras.Size = new System.Drawing.Size(80, 20);
            this.txt_horasExtras.TabIndex = 15;
            // 
            // txt_vhoraTrabajo
            // 
            this.txt_vhoraTrabajo.Location = new System.Drawing.Point(213, 219);
            this.txt_vhoraTrabajo.Name = "txt_vhoraTrabajo";
            this.txt_vhoraTrabajo.Size = new System.Drawing.Size(77, 20);
            this.txt_vhoraTrabajo.TabIndex = 16;
            // 
            // txt_vhoraExtra
            // 
            this.txt_vhoraExtra.Location = new System.Drawing.Point(213, 263);
            this.txt_vhoraExtra.Name = "txt_vhoraExtra";
            this.txt_vhoraExtra.Size = new System.Drawing.Size(77, 20);
            this.txt_vhoraExtra.TabIndex = 17;
            // 
            // txt_thorasTrabajadas
            // 
            this.txt_thorasTrabajadas.BackColor = System.Drawing.SystemColors.Window;
            this.txt_thorasTrabajadas.Enabled = false;
            this.txt_thorasTrabajadas.Location = new System.Drawing.Point(168, 347);
            this.txt_thorasTrabajadas.Name = "txt_thorasTrabajadas";
            this.txt_thorasTrabajadas.Size = new System.Drawing.Size(100, 20);
            this.txt_thorasTrabajadas.TabIndex = 18;
            // 
            // txt_thorasExtras
            // 
            this.txt_thorasExtras.Enabled = false;
            this.txt_thorasExtras.Location = new System.Drawing.Point(168, 382);
            this.txt_thorasExtras.Name = "txt_thorasExtras";
            this.txt_thorasExtras.Size = new System.Drawing.Size(100, 20);
            this.txt_thorasExtras.TabIndex = 19;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Enabled = false;
            this.txt_subtotal.Location = new System.Drawing.Point(168, 421);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(100, 20);
            this.txt_subtotal.TabIndex = 20;
            // 
            // txt_descuento
            // 
            this.txt_descuento.Enabled = false;
            this.txt_descuento.Location = new System.Drawing.Point(168, 459);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(100, 20);
            this.txt_descuento.TabIndex = 21;
            // 
            // txt_neto
            // 
            this.txt_neto.Enabled = false;
            this.txt_neto.Location = new System.Drawing.Point(168, 491);
            this.txt_neto.Name = "txt_neto";
            this.txt_neto.Size = new System.Drawing.Size(100, 20);
            this.txt_neto.TabIndex = 22;
            // 
            // txt_nombreP
            // 
            this.txt_nombreP.Enabled = false;
            this.txt_nombreP.Location = new System.Drawing.Point(39, 305);
            this.txt_nombreP.Name = "txt_nombreP";
            this.txt_nombreP.Size = new System.Drawing.Size(189, 20);
            this.txt_nombreP.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 523);
            this.Controls.Add(this.txt_nombreP);
            this.Controls.Add(this.txt_neto);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.txt_subtotal);
            this.Controls.Add(this.txt_thorasExtras);
            this.Controls.Add(this.txt_thorasTrabajadas);
            this.Controls.Add(this.txt_vhoraExtra);
            this.Controls.Add(this.txt_vhoraTrabajo);
            this.Controls.Add(this.txt_horasExtras);
            this.Controls.Add(this.txt_horasTrabajadas);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_horasTrabajadas;
        private System.Windows.Forms.TextBox txt_horasExtras;
        private System.Windows.Forms.TextBox txt_vhoraTrabajo;
        private System.Windows.Forms.TextBox txt_vhoraExtra;
        private System.Windows.Forms.TextBox txt_thorasTrabajadas;
        private System.Windows.Forms.TextBox txt_thorasExtras;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.TextBox txt_neto;
        private System.Windows.Forms.TextBox txt_nombreP;
    }
}

