using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Agenda.Entidades;
using Agenda.Negocio;

namespace Agenda.Presentacion
{
    public partial class FrmAgenda : Form
    {
        private readonly ContactoNegocio negocio =
            new ContactoNegocio();

        private int idSeleccionado = 0;

        public FrmAgenda()
        {
            InitializeComponent();

            // ESTILO DE LOS CAMPOS
            TextBox[] campos =
            {
                txtNombre,
                txtTelefono,
                txtCorreo,
                txtDireccion,
                txtBuscar
            };

            foreach (TextBox campo in campos)
            {
                campo.BackColor = Color.FromArgb(248, 247, 250);
                campo.ForeColor = Color.FromArgb(48, 35, 58);
                campo.Font = new Font("Segoe UI", 10);
                campo.BorderStyle = BorderStyle.FixedSingle;
            }

            // ESTILO DE LA TABLA
            dgvContactos.BackgroundColor = Color.White;
            dgvContactos.BorderStyle = BorderStyle.None;
            dgvContactos.GridColor = Color.FromArgb(230, 225, 235);

            dgvContactos.RowHeadersVisible = false;
            dgvContactos.AllowUserToAddRows = false;
            dgvContactos.ReadOnly = true;
            dgvContactos.MultiSelect = false;

            dgvContactos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvContactos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvContactos.EnableHeadersVisualStyles = false;

            // ENCABEZADOS
            dgvContactos.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(112, 44, 145);

            dgvContactos.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvContactos.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            // FILAS
            dgvContactos.DefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Regular);

            dgvContactos.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(225, 207, 238);

            dgvContactos.DefaultCellStyle.SelectionForeColor =
                Color.FromArgb(48, 35, 58);

            dgvContactos.RowTemplate.Height = 35;
            dgvContactos.ColumnHeadersHeight = 40;

            // FONDO GENERAL
            this.BackColor = Color.FromArgb(245, 243, 248);

            // MENU LATERAL
            pnlMenu.BackColor = Color.FromArgb(112, 44, 145);

            // ENCABEZADO
            pnlEncabezado.BackColor = Color.FromArgb(245, 243, 248);

            // PANEL DEL FORMULARIO
            pnlFormulario.BackColor = Color.White;

            // TITULO PRINCIPAL
            lblTitulo.ForeColor = Color.White;
            lblTitulo.BackColor = Color.Transparent;

            // BOTONES
            btnInsertar.BackColor = Color.FromArgb(112, 44, 145);
            btnInsertar.ForeColor = Color.White;

            btnModificar.BackColor = Color.FromArgb(112, 44, 145);
            btnModificar.ForeColor = Color.White;

            btnBuscar.BackColor = Color.FromArgb(112, 44, 145);
            btnBuscar.ForeColor = Color.White;

            btnEliminar.BackColor = Color.FromArgb(190, 65, 85);
            btnEliminar.ForeColor = Color.White;

            btnLimpiar.BackColor = Color.FromArgb(230, 224, 236);
            btnLimpiar.ForeColor = Color.FromArgb(65, 50, 75);

            // ESTILO DE LAS ETIQUETAS
            Label[] etiquetas =
            {
                lblNombre,
                lblTelefono,
                lblCorreo,
                lblDireccion
            };

            foreach (Label etiqueta in etiquetas)
            {
                etiqueta.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                etiqueta.ForeColor = Color.FromArgb(70, 55, 80);
                etiqueta.BackColor = Color.Transparent;
            }

            // Conectar los eventos de los botones
            btnInsertar.Click += btnInsertar_Click;
            btnModificar.Click += btnModificar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
            btnBuscar.Click += btnBuscar_Click;

            // Evento para seleccionar contactos de la tabla
            dgvContactos.CellClick += dgvContactos_CellClick;

            // Cargar contactos al iniciar
            this.Load += FrmAgenda_Load;
        }

        // CARGAR CONTACTOS
        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            CargarContactos();
        }

        private void CargarContactos()
        {
            try
            {
                dgvContactos.DataSource = null;
                dgvContactos.DataSource = negocio.Listar();

                dgvContactos.ClearSelection();
                idSeleccionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los contactos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // INSERTAR CONTACTO
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Contacto contacto = ObtenerContactoFormulario();

                negocio.Insertar(contacto);

                MessageBox.Show(
                    "Contacto registrado correctamente.",
                    "Agenda Electrónica",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarContactos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "No se pudo registrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // MODIFICAR CONTACTO
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSeleccionado <= 0)
                {
                    MessageBox.Show("Seleccione un contacto de la tabla.");
                    return;
                }

                Contacto contacto = ObtenerContactoFormulario();
                contacto.Id = idSeleccionado;

                int resultado = negocio.Modificar(contacto);

                if (resultado > 0)
                {
                    MessageBox.Show("Contacto modificado correctamente.");

                    CargarContactos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al modificar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // ELIMINAR CONTACTO
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (idSeleccionado <= 0)
                {
                    MessageBox.Show("Seleccione un contacto para eliminar.");
                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este contacto?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    negocio.Eliminar(idSeleccionado);

                    MessageBox.Show("Contacto eliminado correctamente.");

                    CargarContactos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // BUSCAR CONTACTO
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtBuscar.Text.Trim();

                dgvContactos.DataSource = null;
                dgvContactos.DataSource = negocio.Buscar(texto);

                dgvContactos.ClearSelection();
                idSeleccionado = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error en la búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // SELECCIONAR CONTACTO DE LA TABLA
        private void dgvContactos_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvContactos.Rows[e.RowIndex];

                idSeleccionado = Convert.ToInt32(
                    fila.Cells["Id"].Value);

                txtNombre.Text = Convert.ToString(
                    fila.Cells["Nombre"].Value);

                txtTelefono.Text = Convert.ToString(
                    fila.Cells["Telefono"].Value);

                txtCorreo.Text = Convert.ToString(
                    fila.Cells["Correo"].Value);

                txtDireccion.Text = Convert.ToString(
                    fila.Cells["Direccion"].Value);
            }
        }

        // OBTENER DATOS DEL FORMULARIO
        private Contacto ObtenerContactoFormulario()
        {
            return new Contacto
            {
                Nombre = txtNombre.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                Direccion = txtDireccion.Text
            };
        }

        // LIMPIAR CAMPOS
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtBuscar.Clear();

            idSeleccionado = 0;

            dgvContactos.ClearSelection();
        }

        private void FrmAgenda_Load_1(object sender, EventArgs e)
        {

        }
    }
}
