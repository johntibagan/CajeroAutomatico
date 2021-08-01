
namespace CajeroAutomatico
{
    partial class Login
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
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.Ingresar = new System.Windows.Forms.Button();
            this.rbUser1 = new System.Windows.Forms.RadioButton();
            this.rbUser2 = new System.Windows.Forms.RadioButton();
            this.rbUser3 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.lblOk = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cajero Automático";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(283, 195);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(100, 20);
            this.txtContrasena.TabIndex = 2;
            // 
            // Ingresar
            // 
            this.Ingresar.BackColor = System.Drawing.Color.Lime;
            this.Ingresar.Location = new System.Drawing.Point(105, 195);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.Size = new System.Drawing.Size(81, 30);
            this.Ingresar.TabIndex = 3;
            this.Ingresar.Text = "Ingresar";
            this.Ingresar.UseVisualStyleBackColor = false;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // rbUser1
            // 
            this.rbUser1.AutoSize = true;
            this.rbUser1.Location = new System.Drawing.Point(537, 210);
            this.rbUser1.Name = "rbUser1";
            this.rbUser1.Size = new System.Drawing.Size(66, 17);
            this.rbUser1.TabIndex = 4;
            this.rbUser1.TabStop = true;
            this.rbUser1.Text = "Cliente 1";
            this.rbUser1.UseVisualStyleBackColor = true;
            // 
            // rbUser2
            // 
            this.rbUser2.AutoSize = true;
            this.rbUser2.Location = new System.Drawing.Point(537, 245);
            this.rbUser2.Name = "rbUser2";
            this.rbUser2.Size = new System.Drawing.Size(66, 17);
            this.rbUser2.TabIndex = 5;
            this.rbUser2.TabStop = true;
            this.rbUser2.Text = "Cliente 2";
            this.rbUser2.UseVisualStyleBackColor = true;
            // 
            // rbUser3
            // 
            this.rbUser3.AutoSize = true;
            this.rbUser3.Location = new System.Drawing.Point(537, 283);
            this.rbUser3.Name = "rbUser3";
            this.rbUser3.Size = new System.Drawing.Size(66, 17);
            this.rbUser3.TabIndex = 6;
            this.rbUser3.TabStop = true;
            this.rbUser3.Text = "Cliente 3";
            this.rbUser3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña";
            // 
            // lblErrors
            // 
            this.lblErrors.ForeColor = System.Drawing.Color.Red;
            this.lblErrors.Location = new System.Drawing.Point(83, 144);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(137, 26);
            this.lblErrors.TabIndex = 8;
            this.lblErrors.Text = "Errores";
            this.lblErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOk
            // 
            this.lblOk.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblOk.Location = new System.Drawing.Point(83, 168);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(137, 26);
            this.lblOk.TabIndex = 9;
            this.lblOk.Text = "Ok";
            this.lblOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Datos de clientes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre / Contraseña / Codigo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblOk);
            this.panel1.Controls.Add(this.lblErrors);
            this.panel1.Controls.Add(this.Ingresar);
            this.panel1.Location = new System.Drawing.Point(188, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 288);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(609, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "123 / 10101";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "123 / 20202";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(609, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "123 / 30303";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbUser3);
            this.Controls.Add(this.rbUser2);
            this.Controls.Add(this.rbUser1);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Autenticación";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button Ingresar;
        private System.Windows.Forms.RadioButton rbUser1;
        private System.Windows.Forms.RadioButton rbUser2;
        private System.Windows.Forms.RadioButton rbUser3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Label lblOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

