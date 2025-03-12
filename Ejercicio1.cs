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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void MostrarError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            string nombre = txtIngreseNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtIngreseNombre.Text))
            {
                MostrarError("Debe ingresar un nombre.");
                return;
            }

            if (lbNombres.Items.Cast<string>().Any(item => string.Equals(item, nombre, StringComparison.OrdinalIgnoreCase)) ||
                lbNombresRight.Items.Cast<string>().Any(item => string.Equals(item, nombre, StringComparison.OrdinalIgnoreCase)))
            {
                MostrarError("El nombre ya esta en la lista.");
                return;
            }

            lbNombres.Items.Add(nombre);
            txtIngreseNombre.Text = "";

        } 


        

        private void btnMover_Click(object sender, EventArgs e)
        {
            if(lbNombres.SelectedItems.Count > 1)
            {
                MessageBox.Show("Debe seleccionar solo un nombre de la lista.", "Error");
                lbNombres.SelectedItems.Clear();
            }
            if(lbNombres.SelectedItem != null)
            {
                string nombreSeleccionado = lbNombres.SelectedItem.ToString();
                if(!lbNombresRight.Items.Contains(nombreSeleccionado))
                {
                
                    lbNombresRight.Items.Add(nombreSeleccionado);
                    lbNombres.Items.Remove(nombreSeleccionado);
                }
                else
                {
                    MessageBox.Show("El nombre ya esta en la lista de la derecha.", "Error");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un nombre de la lista.", "Error");
            }

        }

        private void btnMoverTDS_Click(object sender, EventArgs e)
        {
            foreach (string item in lbNombres.Items)
            {
                lbNombresRight.Items.Add(item);
            }

            if(lbNombres.Items.Count == 0)
            {
                MessageBox.Show("No hay nombres en la lista para pasar.", "Error");
            }

            lbNombres.Items.Clear();

        }

        private void lbNombres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIngreseNombre_TextChanged(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(txtIngreseNombre.Text))
            {
                
                btnAceptar.Enabled = true;
            }
            else
            {
               
                btnAceptar.Enabled = false;
            }
        }

        private void lblIngreseNombre_Click(object sender, EventArgs e)
        {

        }
    }
}
