namespace OrdenamientoRapido
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
            this.btnQSAsc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnQSDes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQSAsc
            // 
            this.btnQSAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQSAsc.Location = new System.Drawing.Point(12, 74);
            this.btnQSAsc.Name = "btnQSAsc";
            this.btnQSAsc.Size = new System.Drawing.Size(267, 28);
            this.btnQSAsc.TabIndex = 0;
            this.btnQSAsc.Text = "Ordenar ascendente";
            this.btnQSAsc.UseVisualStyleBackColor = true;
            this.btnQSAsc.Click += new System.EventHandler(this.btnQSAsc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresar números a ordenar separados por comas:";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(12, 46);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(581, 22);
            this.txtNum.TabIndex = 2;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(12, 117);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(581, 228);
            this.txtResultado.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 351);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(581, 28);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnQSDes
            // 
            this.btnQSDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQSDes.Location = new System.Drawing.Point(326, 74);
            this.btnQSDes.Name = "btnQSDes";
            this.btnQSDes.Size = new System.Drawing.Size(267, 28);
            this.btnQSDes.TabIndex = 5;
            this.btnQSDes.Text = "Ordenar descendente";
            this.btnQSDes.UseVisualStyleBackColor = true;
            this.btnQSDes.Click += new System.EventHandler(this.btnQSDes_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(326, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Crear arreglo random";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 390);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnQSDes);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQSAsc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQSAsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnQSDes;
        private System.Windows.Forms.Button button1;
    }
}

