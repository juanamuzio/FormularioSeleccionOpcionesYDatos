
namespace TP1_GRUPO_7
{
    partial class Ejercicio3
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
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.rdbSoltero = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.clbOficios = new System.Windows.Forms.CheckedListBox();
            this.lblseleccion = new System.Windows.Forms.Label();
            this.btnmostrarSeleccion = new System.Windows.Forms.Button();
            this.gbSexo.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.rdbMasculino);
            this.gbSexo.Controls.Add(this.rdbFemenino);
            this.gbSexo.Location = new System.Drawing.Point(92, 21);
            this.gbSexo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSexo.Size = new System.Drawing.Size(267, 123);
            this.gbSexo.TabIndex = 0;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo";
            this.gbSexo.Enter += new System.EventHandler(this.gbSexo_Enter);
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(28, 79);
            this.rdbMasculino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(92, 21);
            this.rdbMasculino.TabIndex = 1;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Checked = true;
            this.rdbFemenino.Location = new System.Drawing.Point(28, 39);
            this.rdbFemenino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(91, 21);
            this.rdbFemenino.TabIndex = 0;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            this.rdbFemenino.CheckedChanged += new System.EventHandler(this.c_CheckedChanged);
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.rdbSoltero);
            this.gbEstado.Controls.Add(this.rdbCasado);
            this.gbEstado.Location = new System.Drawing.Point(575, 21);
            this.gbEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbEstado.Size = new System.Drawing.Size(267, 123);
            this.gbEstado.TabIndex = 1;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado Civil";
            this.gbEstado.Enter += new System.EventHandler(this.gbEstado_Enter);
            // 
            // rdbSoltero
            // 
            this.rdbSoltero.AutoSize = true;
            this.rdbSoltero.Location = new System.Drawing.Point(23, 79);
            this.rdbSoltero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbSoltero.Name = "rdbSoltero";
            this.rdbSoltero.Size = new System.Drawing.Size(74, 21);
            this.rdbSoltero.TabIndex = 3;
            this.rdbSoltero.Text = "Soltero";
            this.rdbSoltero.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Checked = true;
            this.rdbCasado.Location = new System.Drawing.Point(23, 39);
            this.rdbCasado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(77, 21);
            this.rdbCasado.TabIndex = 2;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // clbOficios
            // 
            this.clbOficios.CheckOnClick = true;
            this.clbOficios.FormattingEnabled = true;
            this.clbOficios.Items.AddRange(new object[] {
            "Data entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.clbOficios.Location = new System.Drawing.Point(332, 164);
            this.clbOficios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbOficios.Name = "clbOficios";
            this.clbOficios.Size = new System.Drawing.Size(312, 106);
            this.clbOficios.TabIndex = 2;
            this.clbOficios.Click += new System.EventHandler(this.checkedListBox1_Click);
            this.clbOficios.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lblseleccion
            // 
            this.lblseleccion.AutoSize = true;
            this.lblseleccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblseleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblseleccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblseleccion.Location = new System.Drawing.Point(253, 327);
            this.lblseleccion.Name = "lblseleccion";
            this.lblseleccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblseleccion.Size = new System.Drawing.Size(0, 24);
            this.lblseleccion.TabIndex = 3;
            // 
            // btnmostrarSeleccion
            // 
            this.btnmostrarSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrarSeleccion.Location = new System.Drawing.Point(360, 277);
            this.btnmostrarSeleccion.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnmostrarSeleccion.Name = "btnmostrarSeleccion";
            this.btnmostrarSeleccion.Size = new System.Drawing.Size(247, 32);
            this.btnmostrarSeleccion.TabIndex = 4;
            this.btnmostrarSeleccion.Text = "Mostrar lo que se seleccionó";
            this.btnmostrarSeleccion.UseVisualStyleBackColor = true;
            this.btnmostrarSeleccion.Click += new System.EventHandler(this.btnmostrarSeleccion_Click);
            // 
            // Ejercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnmostrarSeleccion);
            this.Controls.Add(this.lblseleccion);
            this.Controls.Add(this.clbOficios);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.gbSexo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Ejercicio3";
            this.RightToLeftLayout = true;
            this.Text = "Ejercicio3";
            this.Load += new System.EventHandler(this.Ejercicio3_Load);
            this.gbSexo.ResumeLayout(false);
            this.gbSexo.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbSoltero;
        private System.Windows.Forms.CheckedListBox clbOficios;
        private System.Windows.Forms.Label lblseleccion;
        private System.Windows.Forms.Button btnmostrarSeleccion;
    }
}