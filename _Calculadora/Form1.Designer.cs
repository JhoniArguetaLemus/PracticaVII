namespace _Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.cbSuma = new System.Windows.Forms.CheckBox();
            this.cbResta = new System.Windows.Forms.CheckBox();
            this.cbDivision = new System.Windows.Forms.CheckBox();
            this.cbMultiplicacion = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 1: ";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(162, 35);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(135, 25);
            this.txt1.TabIndex = 2;
            this.txt1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validacionTxt1);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(162, 86);
            this.txt2.Multiline = true;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(135, 25);
            this.txt2.TabIndex = 3;
            this.txt2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validacionTxt2);
            // 
            // cbSuma
            // 
            this.cbSuma.AutoSize = true;
            this.cbSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuma.Location = new System.Drawing.Point(351, 37);
            this.cbSuma.Name = "cbSuma";
            this.cbSuma.Size = new System.Drawing.Size(74, 24);
            this.cbSuma.TabIndex = 4;
            this.cbSuma.Text = "Suma";
            this.cbSuma.UseVisualStyleBackColor = true;
            this.cbSuma.CheckedChanged += new System.EventHandler(this.cbSuma_CheckedChanged);
            // 
            // cbResta
            // 
            this.cbResta.AutoSize = true;
            this.cbResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResta.Location = new System.Drawing.Point(445, 38);
            this.cbResta.Name = "cbResta";
            this.cbResta.Size = new System.Drawing.Size(76, 24);
            this.cbResta.TabIndex = 5;
            this.cbResta.Text = "Resta";
            this.cbResta.UseVisualStyleBackColor = true;
            this.cbResta.CheckedChanged += new System.EventHandler(this.cbResta_CheckedChanged);
            // 
            // cbDivision
            // 
            this.cbDivision.AutoSize = true;
            this.cbDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDivision.Location = new System.Drawing.Point(351, 87);
            this.cbDivision.Name = "cbDivision";
            this.cbDivision.Size = new System.Drawing.Size(90, 24);
            this.cbDivision.TabIndex = 6;
            this.cbDivision.Text = "División";
            this.cbDivision.UseVisualStyleBackColor = true;
            this.cbDivision.CheckedChanged += new System.EventHandler(this.cbDivision_CheckedChanged);
            // 
            // cbMultiplicacion
            // 
            this.cbMultiplicacion.AutoSize = true;
            this.cbMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMultiplicacion.Location = new System.Drawing.Point(447, 87);
            this.cbMultiplicacion.Name = "cbMultiplicacion";
            this.cbMultiplicacion.Size = new System.Drawing.Size(136, 24);
            this.cbMultiplicacion.TabIndex = 7;
            this.cbMultiplicacion.Text = "Multiplicación";
            this.cbMultiplicacion.UseVisualStyleBackColor = true;
            this.cbMultiplicacion.CheckedChanged += new System.EventHandler(this.cbMultiplicacion_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(228, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Operar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado: ";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(162, 132);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(135, 25);
            this.txtResultado.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(405, 136);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 28);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 264);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbMultiplicacion);
            this.Controls.Add(this.cbDivision);
            this.Controls.Add(this.cbResta);
            this.Controls.Add(this.cbSuma);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.CheckBox cbSuma;
        private System.Windows.Forms.CheckBox cbResta;
        private System.Windows.Forms.CheckBox cbDivision;
        private System.Windows.Forms.CheckBox cbMultiplicacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

