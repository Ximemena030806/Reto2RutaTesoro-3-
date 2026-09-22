using System;
using System.Windows.Forms;

namespace Reto2RutaTesoro
{
    public partial class FrmRutaTesoro : Form
    {
        // Única fuente de verdad de los datos: la lista enlazada.
        private readonly ListaSimple _ruta = new ListaSimple();

        public FrmRutaTesoro()
        {
            InitializeComponent();
            ActualizarGrid();
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out string nombre, out string pista))
            {
                return;
            }

            int id = (int)nudId.Value;
            int peligro = (int)nudPeligro.Value;

            Nodo nuevoNodo = new Nodo(id, nombre, pista, peligro, null);

            bool agregado = _ruta.Insertar(nuevoNodo);

            if (!agregado)
            {
                MessageBox.Show(
                    $"Ya existe una ubicación con el ID {id}. Usa otro ID o el botón Modificar.",
                    "ID duplicado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ActualizarGrid();
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = (int)nudId.Value;

            Nodo? encontrado = _ruta.Buscar(id);

            if (encontrado == null)
            {
                MessageBox.Show(
                    $"No se encontró ninguna ubicación con el ID {id}.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            txtNombre.Text = encontrado.Nombre;
            txtPista.Text = encontrado.Pista;
            nudPeligro.Value = encontrado.Peligro;

            SeleccionarFilaEnGrid(id);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out string nombre, out string pista))
            {
                return;
            }

            int id = (int)nudId.Value;
            int peligro = (int)nudPeligro.Value;

            bool modificado = _ruta.Modificar(id, nombre, pista, peligro);

            if (!modificado)
            {
                MessageBox.Show(
                    $"No existe ninguna ubicación con el ID {id} para modificar.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ActualizarGrid();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = (int)nudId.Value;

            DialogResult confirmacion = MessageBox.Show(
                $"¿Eliminar la ubicación con ID {id} de la ruta?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            bool eliminado = _ruta.Eliminar(id);

            if (!eliminado)
            {
                MessageBox.Show(
                    $"No existe ninguna ubicación con el ID {id}.",
                    "Sin resultados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            ActualizarGrid();
            LimpiarCampos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvRuta_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRuta.CurrentRow == null)
            {
                return;
            }

            
            var fila = dgvRuta.CurrentRow;
            nudId.Value = Convert.ToDecimal(fila.Cells["Id"].Value);
            txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
            txtPista.Text = fila.Cells["Pista"].Value?.ToString() ?? "";
            nudPeligro.Value = Convert.ToDecimal(fila.Cells["Peligro"].Value);
        }

        
        private void ActualizarGrid()
        {
            dgvRuta.Rows.Clear();

            foreach (Nodo nodo in _ruta.Recorrer())
            {
                dgvRuta.Rows.Add(nodo.Id, nodo.Nombre, nodo.Pista, nodo.Peligro);
            }

            lblContador.Text = $"Nodos en la ruta: {_ruta.Contar()}";
        }

        private void SeleccionarFilaEnGrid(int id)
        {
            foreach (DataGridViewRow fila in dgvRuta.Rows)
            {
                if (Convert.ToInt32(fila.Cells["Id"].Value) == id)
                {
                    dgvRuta.ClearSelection();
                    fila.Selected = true;
                    dgvRuta.CurrentCell = fila.Cells[0];
                    break;
                }
            }
        }

        private bool ValidarCampos(out string nombre, out string pista)
        {
            nombre = txtNombre.Text.Trim();
            pista = txtPista.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show(
                    "El nombre de la ubicación es obligatorio.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(pista))
            {
                MessageBox.Show(
                    "La pista es obligatoria.",
                    "Datos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            nudId.Value = nudId.Minimum;
            txtNombre.Clear();
            txtPista.Clear();
            nudPeligro.Value = nudPeligro.Minimum;
            txtNombre.Focus();
        }
    }
}
