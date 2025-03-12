using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_GRUPO_7
{
    public partial class Fprincipal : Form
    {
        public Fprincipal()
        {
            InitializeComponent();
        }

        private void btnEJERCICIO1_Click(object sender, EventArgs e)
        {
            Form ejercicio1 = new Ejercicio1();
            ejercicio1.Show();
        }

        private void btnEJERCICIO2_Click(object sender, EventArgs e)
        {
            Form ejercicio2 = new Ejercicio2();
            ejercicio2.Show();
        }

        private void btnEJERCICIO3_Click(object sender, EventArgs e)
        {
            Form ejercicio3 = new Ejercicio3();
            ejercicio3.Show();
        }
    }
}
