namespace WindowsFormsArbolesBinariosBusqueda
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btninsertarnodos = new System.Windows.Forms.Button();
            this.txthijo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpreorden = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtposorden = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtentreorden = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(48, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARBOLES BINARIOS BUSQUEDA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btninsertarnodos);
            this.groupBox1.Controls.Add(this.txthijo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btninsertarnodos
            // 
            this.btninsertarnodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btninsertarnodos.Location = new System.Drawing.Point(114, 62);
            this.btninsertarnodos.Name = "btninsertarnodos";
            this.btninsertarnodos.Size = new System.Drawing.Size(160, 35);
            this.btninsertarnodos.TabIndex = 3;
            this.btninsertarnodos.Text = "Insertar en el Arbol";
            this.btninsertarnodos.UseVisualStyleBackColor = true;
            this.btninsertarnodos.Click += new System.EventHandler(this.btninsertarnodos_Click);
            // 
            // txthijo
            // 
            this.txthijo.Location = new System.Drawing.Point(126, 36);
            this.txthijo.Name = "txthijo";
            this.txthijo.Size = new System.Drawing.Size(139, 20);
            this.txthijo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(168, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Elemento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(17, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "RECORRIDOS DEL ARBOL BINARIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(19, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "PreOrden";
            // 
            // txtpreorden
            // 
            this.txtpreorden.Location = new System.Drawing.Point(104, 218);
            this.txtpreorden.Name = "txtpreorden";
            this.txtpreorden.Size = new System.Drawing.Size(294, 20);
            this.txtpreorden.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(19, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "PosOrden";
            // 
            // txtposorden
            // 
            this.txtposorden.Location = new System.Drawing.Point(104, 244);
            this.txtposorden.Name = "txtposorden";
            this.txtposorden.Size = new System.Drawing.Size(294, 20);
            this.txtposorden.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(19, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "EntreOrden";
            // 
            // txtentreorden
            // 
            this.txtentreorden.Location = new System.Drawing.Point(104, 270);
            this.txtentreorden.Name = "txtentreorden";
            this.txtentreorden.Size = new System.Drawing.Size(294, 20);
            this.txtentreorden.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 309);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtentreorden);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtposorden);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtpreorden);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btninsertarnodos;
        private System.Windows.Forms.TextBox txthijo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpreorden;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtposorden;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtentreorden;
    }
}

