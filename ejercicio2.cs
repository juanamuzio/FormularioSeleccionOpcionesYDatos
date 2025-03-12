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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void borrar_nombre_apellido(TextBox nombre, TextBox apellido)
        {
            nombre.Text = "";
            apellido.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNombre2.Text) && !string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                string nombre = txtNombre2.Text.Trim();
                string apellido = txtApellido.Text.Trim();

                if (!lbNombreApellido.Items.Cast<string>()
                    .Any(item => string.Equals(item, nombre + " " + apellido, StringComparison.OrdinalIgnoreCase)))
                {
                    lbNombreApellido.Items.Add(nombre + " " + apellido);
                    borrar_nombre_apellido(txtNombre2, txtApellido);
                    ordenarLista();
                }
                else
                {
                    MessageBox.Show("El nombre ya está en la lista.", "Error");
                }
            }
            else
            {
                borrar_nombre_apellido(txtNombre2, txtApellido);
                MessageBox.Show("Debe ingresar un nombre y un apellido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        private void ordenarLista()
        {
            lbNombreApellido.Sorted = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if(lbNombreApellido.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un elemnto para borrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lbNombreApellido.Items.RemoveAt(lbNombreApellido.SelectedIndex);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
