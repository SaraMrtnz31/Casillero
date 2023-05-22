
namespace Prueba2
{
    partial class frmUsuarios
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
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtgUsuarios);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(303, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(740, 528);
            this.panel4.TabIndex = 15;
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario,
            this.nombre,
            this.apellidos,
            this.correo,
            this.telefono,
            this.cargo,
            this.rol,
            this.contra});
            this.dtgUsuarios.Location = new System.Drawing.Point(22, 6);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.Size = new System.Drawing.Size(715, 509);
            this.dtgUsuarios.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.txtBuscar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(303, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(740, 66);
            this.panel3.TabIndex = 14;
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
            this.btnBuscar.Location = new System.Drawing.Point(611, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 30);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(22, 18);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(571, 30);
            this.txtBuscar.TabIndex = 34;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.Location = new System.Drawing.Point(31, 14);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(66, 17);
            this.lblNombres.TabIndex = 3;
            this.lblNombres.Text = "Nombres";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(27, 35);
            this.txtNombres.Multiline = true;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(235, 30);
            this.txtNombres.TabIndex = 16;
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
            this.btnGuardar.Location = new System.Drawing.Point(29, 480);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(235, 30);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
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
            this.btnModificar.Location = new System.Drawing.Point(28, 515);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(235, 30);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
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
            this.btnEliminar.Location = new System.Drawing.Point(29, 550);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(235, 30);
            this.btnEliminar.TabIndex = 25;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cboRol);
            this.panel2.Controls.Add(this.lblRol);
            this.panel2.Controls.Add(this.txtContra);
            this.panel2.Controls.Add(this.cboCargo);
            this.panel2.Controls.Add(this.lblContra);
            this.panel2.Controls.Add(this.lblCargo);
            this.panel2.Controls.Add(this.txtUsuario);
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.txtTelefono);
            this.panel2.Controls.Add(this.lblTelefono);
            this.panel2.Controls.Add(this.txtCorreo);
            this.panel2.Controls.Add(this.lblCorreo);
            this.panel2.Controls.Add(this.txtApellidos);
            this.panel2.Controls.Add(this.lblApellidos);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.txtNombres);
            this.panel2.Controls.Add(this.lblNombres);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 594);
            this.panel2.TabIndex = 13;
            // 
            // cboRol
            // 
            this.cboRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.cboRol.Location = new System.Drawing.Point(29, 324);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(233, 25);
            this.cboRol.TabIndex = 36;
            this.cboRol.Text = "Seleccione...";
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.Location = new System.Drawing.Point(28, 304);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(28, 17);
            this.lblRol.TabIndex = 37;
            this.lblRol.Text = "Rol";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(28, 438);
            this.txtContra.Multiline = true;
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(235, 30);
            this.txtContra.TabIndex = 39;
            // 
            // cboCargo
            // 
            this.cboCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Vendedor",
            "Jefe"});
            this.cboCargo.Location = new System.Drawing.Point(29, 270);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(233, 25);
            this.cboCargo.TabIndex = 34;
            this.cboCargo.Text = "Seleccione...";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(31, 418);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(84, 17);
            this.lblContra.TabIndex = 38;
            this.lblContra.Text = "Contraseña";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(28, 250);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(50, 17);
            this.lblCargo.TabIndex = 35;
            this.lblCargo.Text = "Cargo";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(34, 378);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(235, 30);
            this.txtUsuario.TabIndex = 33;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(31, 358);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 17);
            this.lblUsuario.TabIndex = 32;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(27, 211);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(235, 30);
            this.txtTelefono.TabIndex = 31;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(30, 190);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(62, 17);
            this.lblTelefono.TabIndex = 30;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(27, 151);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(235, 30);
            this.txtCorreo.TabIndex = 29;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(29, 130);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(53, 17);
            this.lblCorreo.TabIndex = 28;
            this.lblCorreo.Text = "Correo";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(27, 92);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(235, 30);
            this.txtApellidos.TabIndex = 27;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(30, 71);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(66, 17);
            this.lblApellidos.TabIndex = 26;
            this.lblApellidos.Text = "Apellidos";
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // apellidos
            // 
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.Name = "apellidos";
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            // 
            // cargo
            // 
            this.cargo.HeaderText = "Cargo";
            this.cargo.Name = "cargo";
            // 
            // rol
            // 
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            // 
            // contra
            // 
            this.contra.HeaderText = "Contraseña";
            this.contra.Name = "contra";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 594);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "frmUsuarios";
            this.Text = "frmUsuarios";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblCargo;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn contra;
    }
}