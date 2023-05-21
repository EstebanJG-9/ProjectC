namespace Mensaje_form
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
            this.components = new System.ComponentModel.Container();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.txt_dato = new System.Windows.Forms.TextBox();
            this.Textos = new System.Windows.Forms.ToolTip(this.components);
            this.mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.bt_mensaje1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(52, 47);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 0;
            this.btn_registrar.Text = "Registrar";
            this.mensaje.SetToolTip(this.btn_registrar, "Registrar Usuario");
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // txt_dato
            // 
            this.txt_dato.Location = new System.Drawing.Point(174, 47);
            this.txt_dato.Name = "txt_dato";
            this.txt_dato.Size = new System.Drawing.Size(100, 20);
            this.txt_dato.TabIndex = 1;
            this.mensaje.SetToolTip(this.txt_dato, "Ingrese el Dato");
            this.Textos.SetToolTip(this.txt_dato, ",m");
            // 
            // Textos
            // 
            this.Textos.ToolTipTitle = "INGRESAR ACA ";
            // 
            // mensaje
            // 
            this.mensaje.Tag = "INGRESAR";
            this.mensaje.ToolTipTitle = "INGRESAR";
            // 
            // bt_mensaje1
            // 
            this.bt_mensaje1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_mensaje1.Location = new System.Drawing.Point(52, 97);
            this.bt_mensaje1.Name = "bt_mensaje1";
            this.bt_mensaje1.Size = new System.Drawing.Size(75, 23);
            this.bt_mensaje1.TabIndex = 2;
            this.bt_mensaje1.Text = "MENSAJE 1";
            this.bt_mensaje1.UseVisualStyleBackColor = true;
            this.bt_mensaje1.Click += new System.EventHandler(this.bt_mensaje1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(52, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "MENSAJE 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(52, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "MENSAJE 3";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(52, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "MENSAJE 4";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(52, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "MENSAJE 5";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Location = new System.Drawing.Point(52, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "MENSAJE 6";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 369);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_mensaje1);
            this.Controls.Add(this.txt_dato);
            this.Controls.Add(this.btn_registrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.ToolTip mensaje;
        private System.Windows.Forms.TextBox txt_dato;
        private System.Windows.Forms.ToolTip Textos;
        private System.Windows.Forms.Button bt_mensaje1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

