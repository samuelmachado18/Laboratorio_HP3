using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoClase
{
    public partial class formularioHijo1 : Form
    {
        public formularioHijo1()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
         
            
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            
           
        }
    }
}
