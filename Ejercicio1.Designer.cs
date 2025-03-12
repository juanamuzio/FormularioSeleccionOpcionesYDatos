
namespace TP1_GRUPO_7
{
    partial class Ejercicio1
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
            this.components = new System.ComponentModel.Container();
            this.lblIngreseNombre = new System.Windows.Forms.Label();
            this.txtIngreseNombre = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lbNombres = new System.Windows.Forms.ListBox();
            this.lbNombresRight = new System.Windows.Forms.ListBox();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnMoverTDS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngreseNombre
            // 
            this.lblIngreseNombre.AutoSize = true;
            this.lblIngreseNombre.Font = new System.Drawing.Font("Rockwell Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseNombre.Location = new System.Drawing.Point(124, 124);
            this.lblIngreseNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngreseNombre.Name = "lblIngreseNombre";
            this.lblIngreseNombre.Size = new System.Drawing.Size(265, 35);
            this.lblIngreseNombre.TabIndex = 0;
            this.lblIngreseNombre.Text = "Ingrese un nombre: ";
            this.lblIngreseNombre.Click += new System.EventHandler(this.lblIngreseNombre_Click);
            // 
            // txtIngreseNombre
            // 
            this.txtIngreseNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngreseNombre.Location = new System.Drawing.Point(418, 119);
            this.txtIngreseNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIngreseNombre.Name = "txtIngreseNombre";
            this.txtIngreseNombre.Size = new System.Drawing.Size(394, 40);
            this.txtIngreseNombre.TabIndex = 1;
            this.txtIngreseNombre.TextChanged += new System.EventHandler(this.txtIngreseNombre_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Rockwell Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(841, 118);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(214, 41);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lbNombres
            // 
            this.lbNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.ItemHeight = 29;
            this.lbNombres.Location = new System.Drawing.Point(130, 193);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(282, 439);
            this.lbNombres.TabIndex = 3;
            this.lbNombres.SelectedIndexChanged += new System.EventHandler(this.lbNombres_SelectedIndexChanged);
            // 
            // lbNombresRight
            // 
            this.lbNombresRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombresRight.FormattingEnabled = true;
            this.lbNombresRight.ItemHeight = 29;
            this.lbNombresRight.Location = new System.Drawing.Point(807, 193);
            this.lbNombresRight.Name = "lbNombresRight";
            this.lbNombresRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbNombresRight.Size = new System.Drawing.Size(282, 439);
            this.lbNombresRight.TabIndex = 4;
            // 
            // btnMover
            // 
            this.btnMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMover.Location = new System.Drawing.Point(564, 361);
            this.btnMover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(112, 35);
            this.btnMover.TabIndex = 5;
            this.btnMover.Text = ">";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnMoverTDS
            // 
            this.btnMoverTDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverTDS.Location = new System.Drawing.Point(564, 451);
            this.btnMoverTDS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMoverTDS.Name = "btnMoverTDS";
            this.btnMoverTDS.Size = new System.Drawing.Size(112, 35);
            this.btnMoverTDS.TabIndex = 6;
            this.btnMoverTDS.Text = ">>";
            this.btnMoverTDS.UseVisualStyleBackColor = true;
            this.btnMoverTDS.Click += new System.EventHandler(this.btnMoverTDS_Click);
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnMoverTDS);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.lbNombresRight);
            this.Controls.Add(this.lbNombres);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtIngreseNombre);
            this.Controls.Add(this.lblIngreseNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            this.Load += new System.EventHandler(this.Ejercicio1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreseNombre;
        private System.Windows.Forms.TextBox txtIngreseNombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ListBox lbNombres;
        private System.Windows.Forms.ListBox lbNombresRight;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnMoverTDS;
    }
}