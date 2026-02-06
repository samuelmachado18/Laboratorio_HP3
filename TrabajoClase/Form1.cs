using TrabajoClase.formularios;

namespace TrabajoClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            FrmAyuda frmAyuda = new FrmAyuda();
            frmAyuda.MdiParent = this;
            frmAyuda.Show();

        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cerrarFormularios();
            FrmAyuda1 ayuda = new FrmAyuda1();
            ayuda.MdiParent = this;
            ayuda.Show();
        }
        private void cerrarFormularios()
        {
            
            foreach (Form hijo in this.MdiChildren)
            {
               
                if (!hijo.IsDisposed)
                    hijo.Close();
            }
        }
    }
}
