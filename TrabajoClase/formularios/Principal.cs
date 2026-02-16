using TrabajoClase.formularios;

namespace TrabajoClase
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            FrmAcercaDe FrmAcercaDe = new FrmAcercaDe();
            FrmAcercaDe.MdiParent = this;
            FrmAcercaDe.Show();

        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            FrmAyuda FrmAyuda = new FrmAyuda();
            FrmAyuda.MdiParent = this;
            FrmAyuda.Show();
        }
        private void cerrarFormularios()
        {

            foreach (Form hijo in this.MdiChildren)
            {

                if (!hijo.IsDisposed)
                    hijo.Close();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            Clientes Clientes = new Clientes();
            Clientes.MdiParent = this;
            Clientes.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            Productos Productos = new Productos();
            Productos.MdiParent = this;
            Productos.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            Categoria Categoria = new Categoria();
            Categoria.MdiParent = this;
            Categoria.Show();

        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            frmFacturas frmFacturas = new frmFacturas();
            frmFacturas.MdiParent = this;
            frmFacturas.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            frmImformes frmImformes = new frmImformes();
            frmImformes.MdiParent = this;
            frmImformes.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            FrmEmpleados FrmEmpleados = new FrmEmpleados();
            FrmEmpleados.MdiParent = this;
            FrmEmpleados.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            FrmRol FrmRol = new FrmRol();
            FrmRol.MdiParent = this;
            FrmRol.Show();
        }

        private void seguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            FrmSeguridad FrmSeguridad = new FrmSeguridad();
            FrmSeguridad.MdiParent = this;
            FrmSeguridad.Show();
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
           FrmPrincipal FrmPrincipal = new FrmPrincipal();
            FrmPrincipal.MdiParent = this;
            FrmPrincipal.Show();
        }
    }
}
