namespace Actividad_2
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbUSUARIO = new System.Windows.Forms.Label();
            this.lbCONTRASEÑA = new System.Windows.Forms.Label();
            this.textcontraseña = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Fuera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(262, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(285, 24);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "WELCOME TO MINECRAFT";
            // 
            // lbUSUARIO
            // 
            this.lbUSUARIO.AutoSize = true;
            this.lbUSUARIO.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUSUARIO.ForeColor = System.Drawing.Color.Purple;
            this.lbUSUARIO.Location = new System.Drawing.Point(472, 81);
            this.lbUSUARIO.Name = "lbUSUARIO";
            this.lbUSUARIO.Size = new System.Drawing.Size(113, 24);
            this.lbUSUARIO.TabIndex = 1;
            this.lbUSUARIO.Text = "USUARIO:";
            // 
            // lbCONTRASEÑA
            // 
            this.lbCONTRASEÑA.AutoSize = true;
            this.lbCONTRASEÑA.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCONTRASEÑA.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbCONTRASEÑA.Location = new System.Drawing.Point(472, 122);
            this.lbCONTRASEÑA.Name = "lbCONTRASEÑA";
            this.lbCONTRASEÑA.Size = new System.Drawing.Size(138, 24);
            this.lbCONTRASEÑA.TabIndex = 2;
            this.lbCONTRASEÑA.Text = "PASSWORD:";
            // 
            // textcontraseña
            // 
            this.textcontraseña.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textcontraseña.Location = new System.Drawing.Point(616, 122);
            this.textcontraseña.Name = "textcontraseña";
            this.textcontraseña.Size = new System.Drawing.Size(172, 20);
            this.textcontraseña.TabIndex = 3;
            this.textcontraseña.TextChanged += new System.EventHandler(this.Textcontraseña_TextChanged);
            // 
            // textNombre
            // 
            this.textNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textNombre.Location = new System.Drawing.Point(615, 83);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(172, 20);
            this.textNombre.TabIndex = 4;
            this.textNombre.TextChanged += new System.EventHandler(this.TextNombre_TextChanged);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(492, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "GO THERE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Fuera
            // 
            this.Fuera.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fuera.Location = new System.Drawing.Point(616, 170);
            this.Fuera.Name = "Fuera";
            this.Fuera.Size = new System.Drawing.Size(125, 30);
            this.Fuera.TabIndex = 6;
            this.Fuera.Text = "SALIR";
            this.Fuera.UseVisualStyleBackColor = true;
            this.Fuera.Click += new System.EventHandler(this.Fuera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fuera);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textcontraseña);
            this.Controls.Add(this.lbCONTRASEÑA);
            this.Controls.Add(this.lbUSUARIO);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbUSUARIO;
        private System.Windows.Forms.Label lbCONTRASEÑA;
        private System.Windows.Forms.TextBox textcontraseña;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Fuera;
    }
}

