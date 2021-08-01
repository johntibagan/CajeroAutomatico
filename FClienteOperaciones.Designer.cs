
namespace CajeroAutomatico
{
    partial class FClienteOperaciones
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
            this.btnSaldo = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCanje = new System.Windows.Forms.Button();
            this.btnConsultaPuntos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblOk = new System.Windows.Forms.Label();
            this.panelBase = new System.Windows.Forms.Panel();
            this.lblErrors = new System.Windows.Forms.Label();
            this.panelSaldo = new System.Windows.Forms.Panel();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRetiro = new System.Windows.Forms.Panel();
            this.txtRetiro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTransferir = new System.Windows.Forms.Panel();
            this.txtCuentaTransferir = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMontoTransferir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPuntos = new System.Windows.Forms.Panel();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelPuntosCanje = new System.Windows.Forms.Panel();
            this.txtPuntos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panelSaldo.SuspendLayout();
            this.panelRetiro.SuspendLayout();
            this.panelTransferir.SuspendLayout();
            this.panelPuntos.SuspendLayout();
            this.panelPuntosCanje.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaldo
            // 
            this.btnSaldo.Location = new System.Drawing.Point(44, 55);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(75, 37);
            this.btnSaldo.TabIndex = 0;
            this.btnSaldo.Text = "Consultar Saldo";
            this.btnSaldo.UseVisualStyleBackColor = true;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(44, 121);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(75, 37);
            this.btnRetirar.TabIndex = 1;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(44, 185);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(75, 37);
            this.btnTransferir.TabIndex = 2;
            this.btnTransferir.Text = "Transferir";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(390, 185);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnCanje
            // 
            this.btnCanje.Location = new System.Drawing.Point(390, 121);
            this.btnCanje.Name = "btnCanje";
            this.btnCanje.Size = new System.Drawing.Size(75, 37);
            this.btnCanje.TabIndex = 4;
            this.btnCanje.Text = "Canje Puntos";
            this.btnCanje.UseVisualStyleBackColor = true;
            this.btnCanje.Click += new System.EventHandler(this.btnCanje_Click);
            // 
            // btnConsultaPuntos
            // 
            this.btnConsultaPuntos.Location = new System.Drawing.Point(390, 55);
            this.btnConsultaPuntos.Name = "btnConsultaPuntos";
            this.btnConsultaPuntos.Size = new System.Drawing.Size(75, 37);
            this.btnConsultaPuntos.TabIndex = 3;
            this.btnConsultaPuntos.Text = "Consulta Puntos";
            this.btnConsultaPuntos.UseVisualStyleBackColor = true;
            this.btnConsultaPuntos.Click += new System.EventHandler(this.btnConsultaPuntos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnCanje);
            this.panel1.Controls.Add(this.panelPrincipal);
            this.panel1.Controls.Add(this.btnConsultaPuntos);
            this.panel1.Controls.Add(this.btnTransferir);
            this.panel1.Controls.Add(this.btnSaldo);
            this.panel1.Controls.Add(this.btnRetirar);
            this.panel1.Location = new System.Drawing.Point(127, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 293);
            this.panel1.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOk.Location = new System.Drawing.Point(147, 228);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 37);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Confirmar";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCancelar.Location = new System.Drawing.Point(228, 228);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 37);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar / Volver";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Location = new System.Drawing.Point(309, 228);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 37);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Salir";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelPrincipal.Controls.Add(this.lblBienvenido);
            this.panelPrincipal.Controls.Add(this.lblOk);
            this.panelPrincipal.Controls.Add(this.panelBase);
            this.panelPrincipal.Controls.Add(this.lblErrors);
            this.panelPrincipal.Location = new System.Drawing.Point(156, 28);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(219, 194);
            this.panelPrincipal.TabIndex = 7;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.Teal;
            this.lblBienvenido.Location = new System.Drawing.Point(11, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(197, 41);
            this.lblBienvenido.TabIndex = 10;
            this.lblBienvenido.Text = "Bienvenido :  ";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOk
            // 
            this.lblOk.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblOk.Location = new System.Drawing.Point(8, 147);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(208, 28);
            this.lblOk.TabIndex = 9;
            this.lblOk.Text = "Ok";
            this.lblOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBase
            // 
            this.panelBase.Location = new System.Drawing.Point(3, 44);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(213, 100);
            this.panelBase.TabIndex = 8;
            // 
            // lblErrors
            // 
            this.lblErrors.ForeColor = System.Drawing.Color.Red;
            this.lblErrors.Location = new System.Drawing.Point(0, 161);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(208, 28);
            this.lblErrors.TabIndex = 0;
            this.lblErrors.Text = "Errores";
            this.lblErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSaldo
            // 
            this.panelSaldo.Controls.Add(this.lblSaldo);
            this.panelSaldo.Controls.Add(this.label1);
            this.panelSaldo.Location = new System.Drawing.Point(0, 338);
            this.panelSaldo.Name = "panelSaldo";
            this.panelSaldo.Size = new System.Drawing.Size(213, 100);
            this.panelSaldo.TabIndex = 7;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(91, 42);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(43, 13);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "$ Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo:";
            // 
            // panelRetiro
            // 
            this.panelRetiro.Controls.Add(this.txtRetiro);
            this.panelRetiro.Controls.Add(this.label3);
            this.panelRetiro.Location = new System.Drawing.Point(214, 338);
            this.panelRetiro.Name = "panelRetiro";
            this.panelRetiro.Size = new System.Drawing.Size(213, 100);
            this.panelRetiro.TabIndex = 8;
            // 
            // txtRetiro
            // 
            this.txtRetiro.Location = new System.Drawing.Point(99, 39);
            this.txtRetiro.Name = "txtRetiro";
            this.txtRetiro.Size = new System.Drawing.Size(100, 20);
            this.txtRetiro.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Monto Retiro: ";
            // 
            // panelTransferir
            // 
            this.panelTransferir.Controls.Add(this.txtCuentaTransferir);
            this.panelTransferir.Controls.Add(this.label4);
            this.panelTransferir.Controls.Add(this.txtMontoTransferir);
            this.panelTransferir.Controls.Add(this.label2);
            this.panelTransferir.Location = new System.Drawing.Point(430, 338);
            this.panelTransferir.Name = "panelTransferir";
            this.panelTransferir.Size = new System.Drawing.Size(213, 100);
            this.panelTransferir.TabIndex = 9;
            // 
            // txtCuentaTransferir
            // 
            this.txtCuentaTransferir.Location = new System.Drawing.Point(108, 28);
            this.txtCuentaTransferir.Name = "txtCuentaTransferir";
            this.txtCuentaTransferir.Size = new System.Drawing.Size(100, 20);
            this.txtCuentaTransferir.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cuenta a trasnferir:";
            // 
            // txtMontoTransferir
            // 
            this.txtMontoTransferir.Location = new System.Drawing.Point(108, 54);
            this.txtMontoTransferir.Name = "txtMontoTransferir";
            this.txtMontoTransferir.Size = new System.Drawing.Size(100, 20);
            this.txtMontoTransferir.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto a transferir: ";
            // 
            // panelPuntos
            // 
            this.panelPuntos.Controls.Add(this.lblPuntos);
            this.panelPuntos.Controls.Add(this.label6);
            this.panelPuntos.Location = new System.Drawing.Point(649, 338);
            this.panelPuntos.Name = "panelPuntos";
            this.panelPuntos.Size = new System.Drawing.Size(213, 100);
            this.panelPuntos.TabIndex = 8;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(91, 42);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(13, 13);
            this.lblPuntos.TabIndex = 1;
            this.lblPuntos.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Puntos:";
            // 
            // panelPuntosCanje
            // 
            this.panelPuntosCanje.Controls.Add(this.txtPuntos);
            this.panelPuntosCanje.Controls.Add(this.label7);
            this.panelPuntosCanje.Location = new System.Drawing.Point(649, 221);
            this.panelPuntosCanje.Name = "panelPuntosCanje";
            this.panelPuntosCanje.Size = new System.Drawing.Size(213, 100);
            this.panelPuntosCanje.TabIndex = 9;
            // 
            // txtPuntos
            // 
            this.txtPuntos.Location = new System.Drawing.Point(61, 41);
            this.txtPuntos.Name = "txtPuntos";
            this.txtPuntos.Size = new System.Drawing.Size(100, 20);
            this.txtPuntos.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Puntos a canjear:";
            // 
            // FClienteOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPuntosCanje);
            this.Controls.Add(this.panelPuntos);
            this.Controls.Add(this.panelTransferir);
            this.Controls.Add(this.panelSaldo);
            this.Controls.Add(this.panelRetiro);
            this.Controls.Add(this.panel1);
            this.Name = "FClienteOperaciones";
            this.Text = "FClienteOperaciones";
            this.Load += new System.EventHandler(this.FClienteOperaciones_Load);
            this.panel1.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelSaldo.ResumeLayout(false);
            this.panelSaldo.PerformLayout();
            this.panelRetiro.ResumeLayout(false);
            this.panelRetiro.PerformLayout();
            this.panelTransferir.ResumeLayout(false);
            this.panelTransferir.PerformLayout();
            this.panelPuntos.ResumeLayout(false);
            this.panelPuntos.PerformLayout();
            this.panelPuntosCanje.ResumeLayout(false);
            this.panelPuntosCanje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCanje;
        private System.Windows.Forms.Button btnConsultaPuntos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.Panel panelSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Panel panelRetiro;
        private System.Windows.Forms.TextBox txtRetiro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOk;
        private System.Windows.Forms.Panel panelTransferir;
        private System.Windows.Forms.TextBox txtCuentaTransferir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMontoTransferir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPuntos;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelPuntosCanje;
        private System.Windows.Forms.TextBox txtPuntos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBienvenido;
    }
}