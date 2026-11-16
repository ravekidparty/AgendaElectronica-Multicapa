namespace Agenda.Presentacion
{
    partial class FrmAgenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            lblTitulo = new Label();
            pnlEncabezado = new Panel();
            lblEncabezado = new Label();
            pnlFormulario = new Panel();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            lblTelefono = new Label();
            lblCorreo = new Label();
            lblDireccion = new Label();
            lblNombre = new Label();
            btnInsertar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            dgvContactos = new DataGridView();
            txtBuscar = new TextBox();
            lbl = new Label();
            pnlMenu.SuspendLayout();
            pnlEncabezado.SuspendLayout();
            pnlFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Purple;
            pnlMenu.Controls.Add(lblTitulo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.ForeColor = SystemColors.ButtonHighlight;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 653);
            pnlMenu.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(40, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(143, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "AGENDA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlEncabezado
            // 
            pnlEncabezado.BackColor = SystemColors.ButtonFace;
            pnlEncabezado.Controls.Add(lblEncabezado);
            pnlEncabezado.Dock = DockStyle.Top;
            pnlEncabezado.Location = new Point(220, 0);
            pnlEncabezado.Name = "pnlEncabezado";
            pnlEncabezado.Size = new Size(922, 80);
            pnlEncabezado.TabIndex = 1;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.BackColor = Color.Transparent;
            lblEncabezado.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEncabezado.Location = new Point(314, 24);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(314, 38);
            lblEncabezado.TabIndex = 0;
            lblEncabezado.Text = "Gestion de contactos";
            // 
            // pnlFormulario
            // 
            pnlFormulario.BackColor = SystemColors.ButtonHighlight;
            pnlFormulario.BorderStyle = BorderStyle.FixedSingle;
            pnlFormulario.Controls.Add(txtDireccion);
            pnlFormulario.Controls.Add(txtTelefono);
            pnlFormulario.Controls.Add(txtCorreo);
            pnlFormulario.Controls.Add(txtNombre);
            pnlFormulario.Controls.Add(lblTelefono);
            pnlFormulario.Controls.Add(lblCorreo);
            pnlFormulario.Controls.Add(lblDireccion);
            pnlFormulario.Controls.Add(lblNombre);
            pnlFormulario.Location = new Point(249, 122);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(881, 205);
            pnlFormulario.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(542, 55);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(300, 27);
            txtDireccion.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(542, 159);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(300, 27);
            txtTelefono.TabIndex = 6;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(41, 159);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(300, 27);
            txtCorreo.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(41, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(300, 27);
            txtNombre.TabIndex = 4;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.Transparent;
            lblTelefono.Location = new Point(542, 22);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.BackColor = Color.Transparent;
            lblCorreo.Location = new Point(41, 115);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(132, 20);
            lblCorreo.TabIndex = 2;
            lblCorreo.Text = "Correo electrónico";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.Transparent;
            lblDireccion.Location = new Point(542, 115);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Location = new Point(41, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(132, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre completo";
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.Purple;
            btnInsertar.Cursor = Cursors.Hand;
            btnInsertar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.ForeColor = SystemColors.ButtonFace;
            btnInsertar.Location = new Point(624, 601);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(115, 40);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Purple;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = SystemColors.ButtonHighlight;
            btnModificar.Location = new Point(459, 601);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(115, 40);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Purple;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonFace;
            btnEliminar.Location = new Point(977, 600);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 40);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Purple;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ButtonFace;
            btnLimpiar.Location = new Point(291, 601);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(115, 40);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Purple;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ButtonFace;
            btnBuscar.Location = new Point(792, 600);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(115, 40);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // dgvContactos
            // 
            dgvContactos.AllowUserToAddRows = false;
            dgvContactos.AllowUserToDeleteRows = false;
            dgvContactos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContactos.BackgroundColor = SystemColors.ButtonFace;
            dgvContactos.BorderStyle = BorderStyle.None;
            dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.GridColor = Color.Orchid;
            dgvContactos.Location = new Point(249, 333);
            dgvContactos.MultiSelect = false;
            dgvContactos.Name = "dgvContactos";
            dgvContactos.ReadOnly = true;
            dgvContactos.RowHeadersVisible = false;
            dgvContactos.RowHeadersWidth = 51;
            dgvContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContactos.Size = new Size(881, 250);
            dgvContactos.TabIndex = 8;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(880, 86);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(250, 30);
            txtBuscar.TabIndex = 9;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.BackColor = Color.Plum;
            lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.ForeColor = SystemColors.ButtonHighlight;
            lbl.Location = new Point(758, 91);
            lbl.Name = "lbl";
            lbl.Size = new Size(123, 20);
            lbl.TabIndex = 10;
            lbl.Text = "Buscar Contacto";
            // 
            // FrmAgenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1142, 653);
            Controls.Add(lbl);
            Controls.Add(txtBuscar);
            Controls.Add(dgvContactos);
            Controls.Add(btnBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnInsertar);
            Controls.Add(pnlFormulario);
            Controls.Add(pnlEncabezado);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agenda Electronica";
            Load += FrmAgenda_Load_1;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlEncabezado.ResumeLayout(false);
            pnlEncabezado.PerformLayout();
            pnlFormulario.ResumeLayout(false);
            pnlFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenu;
        private Label lblTitulo;
        private Panel pnlEncabezado;
        private Label lblEncabezado;
        private Panel pnlFormulario;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Label lblTelefono;
        private Label lblCorreo;
        private Label lblDireccion;
        private Label lblNombre;
        private Button btnInsertar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private Button btnBuscar;
        private DataGridView dgvContactos;
        private TextBox txtBuscar;
        private Label lbl;
    }
}
