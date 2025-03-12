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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }

        private void gbSexo_Enter(object sender, EventArgs e)
        {

        }

        private void c_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbEstado_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnmostrarSeleccion_Click(object sender, EventArgs e)
        {

            string selecciones = " ";
            foreach (object itemChecked in clbOficios.CheckedItems)
            {
                selecciones += " - " + itemChecked.ToString() + "\n";
            }


            //Es la misma idea pero reutilizamos la funcion ObtenerSeleccionRadioBtn
            string seleccionRbSexo = ObtenerSeleccionRadioBtn(gbSexo);
            string seleccionRbEstado = ObtenerSeleccionRadioBtn(gbEstado);

            //Validacion por las dudas
            if (clbOficios.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un elemento.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string elementosSelec = "Usted seleccionó los siguientes elementos:\nSexo: " + seleccionRbSexo +
                "\nEstado: " + seleccionRbEstado + "\nOficio: \n" + selecciones;

            lblseleccion.Text = elementosSelec;
        }

        private string ObtenerSeleccionRadioBtn(GroupBox groupBox)
        {
            string seleccion = "";
            foreach(Control control in groupBox.Controls)
            {
                if(control is RadioButton && ((RadioButton)control).Checked)
                {
                    seleccion = ((RadioButton)control).Text;
                    break;
                }
            }
            return seleccion;
        }

        private void checkedListBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
