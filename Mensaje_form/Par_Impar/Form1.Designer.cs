namespace Par_Impar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.bt_calcularN = new System.Windows.Forms.Button();
            this.txt_calcular = new System.Windows.Forms.TextBox();
            this.MENSAJE = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un Numero ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(153, 59);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 1;
            // 
            // bt_calcularN
            // 
            this.bt_calcularN.Location = new System.Drawing.Point(33, 146);
            this.bt_calcularN.Name = "bt_calcularN";
            this.bt_calcularN.Size = new System.Drawing.Size(75, 23);
            this.bt_calcularN.TabIndex = 2;
            this.bt_calcularN.Text = "CALCULAR";
            this.bt_calcularN.UseVisualStyleBackColor = true;
            this.bt_calcularN.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_calcular
            // 
            this.txt_calcular.Enabled = false;
            this.txt_calcular.Location = new System.Drawing.Point(153, 148);
            this.txt_calcular.Name = "txt_calcular";
            this.txt_calcular.Size = new System.Drawing.Size(142, 20);
            this.txt_calcular.TabIndex = 3;
            // 
            // MENSAJE
            // 
            this.MENSAJE.ToolTipTitle = "MENSAJE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 397);
            this.Controls.Add(this.txt_calcular);
            this.Controls.Add(this.bt_calcularN);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Button bt_calcularN;
        private System.Windows.Forms.TextBox txt_calcular;
        private System.Windows.Forms.ToolTip MENSAJE;
    }
}

