
namespace Prueba2
{
    partial class frmEstantes
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dtgEstantes = new System.Windows.Forms.DataGridView();
            this.codCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNumEstante = new System.Windows.Forms.TextBox();
            this.lblNumEstante = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstantes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.dtgEstantes);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(303, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(740, 594);
            this.panel4.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 63);
            this.panel1.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.Location = new System.Drawing.Point(608, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 30);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(19, 20);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(571, 30);
            this.txtBuscar.TabIndex = 32;
            // 
            // dtgEstantes
            // 
            this.dtgEstantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEstantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCategoria,
            this.categoria,
            this.descripcion});
            this.dtgEstantes.Location = new System.Drawing.Point(19, 73);
            this.dtgEstantes.Name = "dtgEstantes";
            this.dtgEstantes.Size = new System.Drawing.Size(718, 495);
            this.dtgEstantes.TabIndex = 0;
            // 
            // codCategoria
            // 
            this.codCategoria.HeaderText = "Número de estante";
            this.codCategoria.Name = "codCategoria";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(303, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 66);
            this.panel3.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCategoria);
            this.panel2.Controls.Add(this.cboCategorias);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.lblDescripcion);
            this.panel2.Controls.Add(this.txtNumEstante);
            this.panel2.Controls.Add(this.lblNumEstante);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 594);
            this.panel2.TabIndex = 19;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(26, 132);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(75, 17);
            this.lblCategoria.TabIndex = 31;
            this.lblCategoria.Text = "Categoría";
            // 
            // cboCategorias
            // 
            this.cboCategorias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Items.AddRange(new object[] {
            "Ropa",
            "Zapatos",
            "Juguetes"});
            this.cboCategorias.Location = new System.Drawing.Point(27, 152);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(158, 25);
            this.cboCategorias.TabIndex = 30;
            this.cboCategorias.Text = "Seleccione...";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(27, 222);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(237, 101);
            this.txtDescripcion.TabIndex = 29;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(26, 202);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(83, 17);
            this.lblDescripcion.TabIndex = 28;
            this.lblDescripcion.Text = "Descripción";
            // 
            // txtNumEstante
            // 
            this.txtNumEstante.Location = new System.Drawing.Point(29, 86);
            this.txtNumEstante.Name = "txtNumEstante";
            this.txtNumEstante.Size = new System.Drawing.Size(235, 20);
            this.txtNumEstante.TabIndex = 27;
            // 
            // lblNumEstante
            // 
            this.lblNumEstante.AutoSize = true;
            this.lblNumEstante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumEstante.Location = new System.Drawing.Point(26, 66);
            this.lblNumEstante.Name = "lblNumEstante";
            this.lblNumEstante.Size = new System.Drawing.Size(133, 17);
            this.lblNumEstante.TabIndex = 26;
            this.lblNumEstante.Text = "Numero de estante";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminar.IconColor = System.Drawing.Color.Black;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.Location = new System.Drawing.Point(29, 538);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(235, 30);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnModificar.IconColor = System.Drawing.Color.Black;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.Location = new System.Drawing.Point(29, 502);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(235, 30);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGuardar.IconColor = System.Drawing.Color.Black;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.Location = new System.Drawing.Point(29, 465);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(235, 31);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // frmEstantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 594);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "frmEstantes";
            this.Text = "frmEstantes";
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEstantes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgEstantes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboCategorias;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtNumEstante;
        private System.Windows.Forms.Label lblNumEstante;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}