namespace Reto2RutaTesoro
{
    partial class FrmRutaTesoro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlDatos = new Panel();
            lblId = new Label();
            nudId = new NumericUpDown();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblPista = new Label();
            txtPista = new TextBox();
            lblPeligro = new Label();
            nudPeligro = new NumericUpDown();
            lblTitulo = new Label();
            btnAgregar = new Button();
            btnBuscar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvRuta = new DataGridView();
            lblContador = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPeligro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRuta).BeginInit();
            SuspendLayout();
            // 
            // pnlDatos
            // 
            pnlDatos.BorderStyle = BorderStyle.FixedSingle;
            pnlDatos.Controls.Add(lblId);
            pnlDatos.Controls.Add(nudId);
            pnlDatos.Controls.Add(lblNombre);
            pnlDatos.Controls.Add(txtNombre);
            pnlDatos.Controls.Add(lblPista);
            pnlDatos.Controls.Add(txtPista);
            pnlDatos.Controls.Add(lblPeligro);
            pnlDatos.Controls.Add(nudPeligro);
            pnlDatos.Location = new Point(23, 80);
            pnlDatos.Margin = new Padding(3, 4, 3, 4);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(868, 173);
            pnlDatos.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(17, 27);
            lblId.Name = "lblId";
            lblId.Size = new Size(116, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID de ubicación:";
            // 
            // nudId
            // 
            nudId.Location = new Point(160, 23);
            nudId.Margin = new Padding(3, 4, 3, 4);
            nudId.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudId.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudId.Name = "nudId";
            nudId.Size = new Size(91, 27);
            nudId.TabIndex = 1;
            nudId.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(286, 27);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(377, 23);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(457, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblPista
            // 
            lblPista.AutoSize = true;
            lblPista.Location = new Point(17, 80);
            lblPista.Name = "lblPista";
            lblPista.Size = new Size(43, 20);
            lblPista.TabIndex = 4;
            lblPista.Text = "Pista:";
            // 
            // txtPista
            // 
            txtPista.Location = new Point(160, 76);
            txtPista.Margin = new Padding(3, 4, 3, 4);
            txtPista.Name = "txtPista";
            txtPista.Size = new Size(674, 27);
            txtPista.TabIndex = 5;
            // 
            // lblPeligro
            // 
            lblPeligro.AutoSize = true;
            lblPeligro.Location = new Point(17, 127);
            lblPeligro.Name = "lblPeligro";
            lblPeligro.Size = new Size(163, 20);
            lblPeligro.TabIndex = 6;
            lblPeligro.Text = "Nivel de peligro (1-10):";
            // 
            // nudPeligro
            // 
            nudPeligro.Location = new Point(194, 123);
            nudPeligro.Margin = new Padding(3, 4, 3, 4);
            nudPeligro.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudPeligro.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPeligro.Name = "nudPeligro";
            nudPeligro.Size = new Size(69, 27);
            nudPeligro.TabIndex = 7;
            nudPeligro.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(23, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(320, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "La Ruta del Tesoro Perdido";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(23, 267);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(160, 43);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(194, 267);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(160, 43);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar por ID";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(366, 267);
            btnModificar.Margin = new Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(160, 43);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(537, 267);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 43);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(709, 267);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(183, 43);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvRuta
            // 
            dgvRuta.AllowUserToAddRows = false;
            dgvRuta.AllowUserToDeleteRows = false;
            dgvRuta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRuta.ColumnHeadersHeight = 29;
            dgvRuta.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvRuta.Location = new Point(23, 327);
            dgvRuta.Margin = new Padding(3, 4, 3, 4);
            dgvRuta.MultiSelect = false;
            dgvRuta.Name = "dgvRuta";
            dgvRuta.ReadOnly = true;
            dgvRuta.RowHeadersVisible = false;
            dgvRuta.RowHeadersWidth = 51;
            dgvRuta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRuta.Size = new Size(869, 347);
            dgvRuta.TabIndex = 7;
            dgvRuta.SelectionChanged += dgvRuta_SelectionChanged;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(23, 687);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(134, 20);
            lblContador.TabIndex = 8;
            lblContador.Text = "Nodos en la ruta: 0";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Ubicación";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Pista";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Peligro";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // FrmRutaTesoro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 727);
            Controls.Add(lblTitulo);
            Controls.Add(pnlDatos);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvRuta);
            Controls.Add(lblContador);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmRutaTesoro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reto 2 - La Ruta del Tesoro Perdido";
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudId).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPeligro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRuta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlDatos;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.NumericUpDown nudId;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;

        private System.Windows.Forms.Label lblPista;
        private System.Windows.Forms.TextBox txtPista;

        private System.Windows.Forms.Label lblPeligro;
        private System.Windows.Forms.NumericUpDown nudPeligro;

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;

        private System.Windows.Forms.DataGridView dgvRuta;
        private System.Windows.Forms.Label lblContador;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
