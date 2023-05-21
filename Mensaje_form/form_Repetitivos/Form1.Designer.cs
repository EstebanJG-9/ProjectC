namespace form_Repetitivos
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
            this.btn_for = new System.Windows.Forms.Button();
            this.btn_while = new System.Windows.Forms.Button();
            this.btn_do = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_for
            // 
            this.btn_for.Location = new System.Drawing.Point(97, 48);
            this.btn_for.Name = "btn_for";
            this.btn_for.Size = new System.Drawing.Size(75, 23);
            this.btn_for.TabIndex = 0;
            this.btn_for.Text = "ciclo for";
            this.btn_for.UseVisualStyleBackColor = true;
            this.btn_for.Click += new System.EventHandler(this.btn_for_Click);
            // 
            // btn_while
            // 
            this.btn_while.Location = new System.Drawing.Point(219, 47);
            this.btn_while.Name = "btn_while";
            this.btn_while.Size = new System.Drawing.Size(75, 23);
            this.btn_while.TabIndex = 1;
            this.btn_while.Text = "ciclo while";
            this.btn_while.UseVisualStyleBackColor = true;
            this.btn_while.Click += new System.EventHandler(this.btn_while_Click);
            // 
            // btn_do
            // 
            this.btn_do.Location = new System.Drawing.Point(362, 47);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(75, 23);
            this.btn_do.TabIndex = 2;
            this.btn_do.Text = "do while";
            this.btn_do.UseVisualStyleBackColor = true;
            this.btn_do.Click += new System.EventHandler(this.btn_do_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 313);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_do);
            this.Controls.Add(this.btn_while);
            this.Controls.Add(this.btn_for);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_for;
        private System.Windows.Forms.Button btn_while;
        private System.Windows.Forms.Button btn_do;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

