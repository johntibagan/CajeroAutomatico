using CajeroAutomatico.cs;
using System;
using System.Drawing;
using System.Windows.Forms;
/**
 * @author  John Tibagan
 * @code    1002709915
 * @socialización: https://youtu.be/Y6Vzx8Sh58Q
 */
namespace CajeroAutomatico
{
    public partial class FClienteOperaciones : Form
    {
        private CajeroService service;
        public FClienteOperaciones()
        {
            InitializeComponent();
            this.service = CajeroService.instanceOf(lblErrors, lblOk);
            reset();
        }


        private void FClienteOperaciones_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido: " + service.Autenticado.Usuario;
        }
        private void btnSaldo_Click(object sender, EventArgs e)
        {
            reset();
            lblSaldo.Text = String.Format("{0:C}", service.Autenticado.Saldo);
            verPanel(panelSaldo);
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            reset();
            verPanel(panelRetiro);
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            reset();
            verPanel(panelTransferir);
        }

        private void btnConsultaPuntos_Click(object sender, EventArgs e)
        {
            reset();
            lblPuntos.Text = service.Autenticado.Puntos + "";
            verPanel(panelPuntos);
        }

        private void btnCanje_Click(object sender, EventArgs e)
        {
            reset();
            verPanel(panelPuntosCanje);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (panelRetiro.Visible)
                this.retirar();
            else if (panelTransferir.Visible)
                this.transferir();
            else if (panelPuntosCanje.Visible)
                this.canjePuntos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void retirar()
        {
            double valor = this.service.getNumber<double>(txtRetiro.Text);
            bool isNumber = false == double.IsNaN(valor);
            if (isNumber)
            {
                if (this.service.retirar(valor))
                {
                    reset();
                    service.addOk("Retiro Exitoso");
                }
            }
        }

        public void transferir()
        {
            int cuenta = this.service.getNumber<int>(txtCuentaTransferir.Text);
            double monto = this.service.getNumber<double>(txtMontoTransferir.Text);
            bool isNumber = monto > 0 && cuenta > 0;
            if (isNumber)
            {
                if (this.service.transferir(cuenta, monto))
                {
                    reset();
                    service.addOk("Transferencia Exitosa");
                }
            }
        }

        public void canjePuntos()
        {
            int puntos = this.service.getNumber<int>(txtPuntos.Text);
            bool isNumber = false == double.IsNaN(puntos);
            if (isNumber)
            {
                if (this.service.canjePuntos(puntos))
                {
                    reset();
                    service.addOk("Canje puntos exitoso!");
                }
            }
        }

        public async void verPanel(Panel panel)
        {
            Point cScreen = panelBase.PointToScreen(panelBase.Location);
            Point fScreen = this.Location;
            Point cFormRel = new Point(cScreen.X - fScreen.X - 12, cScreen.Y - fScreen.Y - 70);
            panel.Location = cFormRel;
            panel.Visible = true;
            //  await Task.Delay(2000);
            //lblErrors.Visible = false;
        }

        public void ocultarPanel(Panel panel)
        {
            panel.Visible = false;
        }

        void reset()
        {
            ocultarPanel(panelSaldo);
            ocultarPanel(panelRetiro);
            ocultarPanel(panelTransferir);
            ocultarPanel(panelPuntos);
            ocultarPanel(panelPuntosCanje);
            lblOk.Visible = false;
            lblErrors.Visible = false;
        }
    }
}
