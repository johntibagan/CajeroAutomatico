using CajeroAutomatico.cs;
using System;
using System.Windows.Forms;

namespace CajeroAutomatico
{
    public partial class Login : Form
    {
        private CajeroService service;
        public Login()
        {
            InitializeComponent();
            this.Service = CajeroService.instanceOf(lblErrors, lblOk);
            reset();
        }

        internal CajeroService Service { get => service; set => service = value; }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            reset();
            bool autenticado = this.Service.autenticar(usuarioSelect(), txtContrasena.Text);
            if (autenticado)
                using (FClienteOperaciones form = new FClienteOperaciones())
                    form.ShowDialog();
        }

        private int usuarioSelect()
        {
            if (rbUser1.Checked)
                return service.Banco.Clientes[0].Codigo;
            if (rbUser2.Checked)
                return service.Banco.Clientes[1].Codigo;
            if (rbUser3.Checked)
                return service.Banco.Clientes[2].Codigo;
            return 0;
        }

        void reset()
        {
            lblErrors.Visible = false;
            lblOk.Visible = false;
        }
    }
}