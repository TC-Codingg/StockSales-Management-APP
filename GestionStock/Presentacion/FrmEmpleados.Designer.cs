namespace GestionStock.Presentacion
{
    partial class FrmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleados));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            toolStrip1 = new ToolStrip();
            btnVentas = new ToolStripButton();
            txtPrecioLista = new TextBox();
            label11 = new Label();
            label10 = new Label();
            numGanancia = new NumericUpDown();
            txtDireccion = new NumericUpDown();
            cmbCargo = new ComboBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            dgvLista = new DataGridView();
            txtBuscar = new TextBox();
            cmbDepartamento = new ComboBox();
            txtSalario = new TextBox();
            txtTelefono = new TextBox();
            dtpNacimiento = new DateTimePicker();
            txtNombre = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnNuevo = new Button();
            panel4 = new Panel();
            labelAdvertencia = new Label();
            pictureBox3 = new PictureBox();
            stockMin = new NumericUpDown();
            stockMax = new NumericUpDown();
            label12 = new Label();
            label13 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGanancia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtDireccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockMax).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 1, 4);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1448, 100);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 28);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Hotel De Paris", 38F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(437, 19);
            label1.Name = "label1";
            label1.Size = new Size(389, 51);
            label1.TabIndex = 0;
            label1.Text = "Stock Managing";
            // 
            // panel3
            // 
            panel3.Controls.Add(toolStrip1);
            panel3.Location = new Point(0, 102);
            panel3.Name = "panel3";
            panel3.Size = new Size(84, 353);
            panel3.TabIndex = 35;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.Transparent;
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnVentas });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.Professional;
            toolStrip1.Size = new Size(84, 353);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnVentas
            // 
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageTransparentColor = Color.Magenta;
            btnVentas.Name = "btnVentas";
            btnVentas.RightToLeft = RightToLeft.No;
            btnVentas.Size = new Size(82, 20);
            btnVentas.Text = "VENTAS";
            btnVentas.Click += btnVentas_Click;
            // 
            // txtPrecioLista
            // 
            txtPrecioLista.Enabled = false;
            txtPrecioLista.Location = new Point(759, 202);
            txtPrecioLista.Name = "txtPrecioLista";
            txtPrecioLista.Size = new Size(202, 26);
            txtPrecioLista.TabIndex = 59;
            txtPrecioLista.TextChanged += txtPrecioLista_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(946, 250);
            label11.Name = "label11";
            label11.Size = new Size(90, 18);
            label11.TabIndex = 58;
            label11.Text = "Precio final:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1102, 181);
            label10.Name = "label10";
            label10.Size = new Size(107, 18);
            label10.TabIndex = 57;
            label10.Text = "Ganancia (%):";
            // 
            // numGanancia
            // 
            numGanancia.Enabled = false;
            numGanancia.Location = new Point(1093, 202);
            numGanancia.Name = "numGanancia";
            numGanancia.Size = new Size(124, 26);
            numGanancia.TabIndex = 56;
            numGanancia.Value = new decimal(new int[] { 21, 0, 0, 0 });
            numGanancia.ValueChanged += numGanancia_ValueChanged;
            // 
            // txtDireccion
            // 
            txtDireccion.Enabled = false;
            txtDireccion.Location = new Point(165, 202);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(124, 26);
            txtDireccion.TabIndex = 55;
            // 
            // cmbCargo
            // 
            cmbCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCargo.Enabled = false;
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Location = new Point(752, 303);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(266, 26);
            cmbCargo.TabIndex = 54;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.MidnightBlue;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleRight;
            btnCancelar.Location = new Point(641, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Padding = new Padding(0, 0, 4, 0);
            btnCancelar.Size = new Size(137, 44);
            btnCancelar.TabIndex = 52;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleLeft;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.MidnightBlue;
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ButtonHighlight;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.Location = new Point(467, 351);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Padding = new Padding(0, 0, 4, 0);
            btnGuardar.Size = new Size(137, 44);
            btnGuardar.TabIndex = 53;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleLeft;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvLista
            // 
            dgvLista.AllowUserToAddRows = false;
            dgvLista.AllowUserToDeleteRows = false;
            dgvLista.AllowUserToOrderColumns = true;
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(32, 457);
            dgvLista.Name = "dgvLista";
            dgvLista.ReadOnly = true;
            dgvLista.Size = new Size(1177, 303);
            dgvLista.TabIndex = 51;
            dgvLista.CellClick += dgvLista_CellClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(158, 415);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(504, 26);
            txtBuscar.TabIndex = 50;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // cmbDepartamento
            // 
            cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartamento.Enabled = false;
            cmbDepartamento.FormattingEnabled = true;
            cmbDepartamento.Location = new Point(165, 303);
            cmbDepartamento.Name = "cmbDepartamento";
            cmbDepartamento.Size = new Size(286, 26);
            cmbDepartamento.TabIndex = 49;
            // 
            // txtSalario
            // 
            txtSalario.Enabled = false;
            txtSalario.Location = new Point(1039, 247);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(178, 26);
            txtSalario.TabIndex = 48;
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new Point(165, 157);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(286, 26);
            txtTelefono.TabIndex = 47;
            // 
            // dtpNacimiento
            // 
            dtpNacimiento.Enabled = false;
            dtpNacimiento.Format = DateTimePickerFormat.Short;
            dtpNacimiento.Location = new Point(871, 115);
            dtpNacimiento.Name = "dtpNacimiento";
            dtpNacimiento.Size = new Size(179, 26);
            dtpNacimiento.TabIndex = 46;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(165, 251);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(487, 26);
            txtNombre.TabIndex = 45;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(91, 418);
            label9.Name = "label9";
            label9.Size = new Size(61, 18);
            label9.TabIndex = 44;
            label9.Text = "Buscar:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(809, 118);
            label8.Name = "label8";
            label8.Size = new Size(56, 18);
            label8.TabIndex = 43;
            label8.Text = "Fecha:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(641, 205);
            label7.Name = "label7";
            label7.Size = new Size(112, 18);
            label7.TabIndex = 42;
            label7.Text = "Precio de lista:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(624, 306);
            label6.Name = "label6";
            label6.Size = new Size(129, 18);
            label6.TabIndex = 41;
            label6.Text = "Tipo de repuesto:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(87, 205);
            label5.Name = "label5";
            label5.Size = new Size(76, 18);
            label5.TabIndex = 40;
            label5.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 160);
            label4.Name = "label4";
            label4.Size = new Size(64, 18);
            label4.TabIndex = 39;
            label4.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 306);
            label3.Name = "label3";
            label3.Size = new Size(56, 18);
            label3.TabIndex = 38;
            label3.Text = "Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 254);
            label2.Name = "label2";
            label2.Size = new Size(68, 18);
            label2.TabIndex = 37;
            label2.Text = "Nombre:";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnNuevo);
            panel1.Location = new Point(1249, 0);
            panel1.MinimumSize = new Size(200, 768);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 768);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(83, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 30);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.MidnightBlue;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = ContentAlignment.MiddleRight;
            btnSalir.Location = new Point(36, 611);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(0, 0, 4, 0);
            btnSalir.Size = new Size(137, 49);
            btnSalir.TabIndex = 24;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.MidnightBlue;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ButtonHighlight;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleRight;
            btnEliminar.Location = new Point(36, 275);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(0, 0, 4, 0);
            btnEliminar.Size = new Size(137, 49);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.MidnightBlue;
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = SystemColors.ButtonHighlight;
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.ImageAlign = ContentAlignment.MiddleRight;
            btnActualizar.Location = new Point(36, 215);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Padding = new Padding(0, 0, 4, 0);
            btnActualizar.Size = new Size(137, 49);
            btnActualizar.TabIndex = 23;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlign = ContentAlignment.MiddleLeft;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.MidnightBlue;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = SystemColors.ButtonHighlight;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = ContentAlignment.MiddleRight;
            btnNuevo.Location = new Point(36, 154);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Padding = new Padding(0, 0, 4, 0);
            btnNuevo.Size = new Size(137, 49);
            btnNuevo.TabIndex = 19;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleLeft;
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(labelAdvertencia);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(972, 433);
            panel4.Name = "panel4";
            panel4.Size = new Size(192, 22);
            panel4.TabIndex = 60;
            // 
            // labelAdvertencia
            // 
            labelAdvertencia.AutoSize = true;
            labelAdvertencia.Font = new Font("Arial", 10F);
            labelAdvertencia.Location = new Point(41, 3);
            labelAdvertencia.Name = "labelAdvertencia";
            labelAdvertencia.Size = new Size(0, 16);
            labelAdvertencia.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(19, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // stockMin
            // 
            stockMin.Enabled = false;
            stockMin.Location = new Point(370, 202);
            stockMin.Name = "stockMin";
            stockMin.Size = new Size(62, 26);
            stockMin.TabIndex = 61;
            stockMin.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // stockMax
            // 
            stockMax.Enabled = false;
            stockMax.Location = new Point(494, 203);
            stockMax.Name = "stockMax";
            stockMax.Size = new Size(62, 26);
            stockMax.TabIndex = 62;
            stockMax.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(330, 206);
            label12.Name = "label12";
            label12.Size = new Size(37, 18);
            label12.TabIndex = 63;
            label12.Text = "Min:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(451, 206);
            label13.Name = "label13";
            label13.Size = new Size(41, 18);
            label13.TabIndex = 64;
            label13.Text = "Max:";
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1448, 768);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(stockMax);
            Controls.Add(stockMin);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(txtPrecioLista);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(numGanancia);
            Controls.Add(txtDireccion);
            Controls.Add(cmbCargo);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvLista);
            Controls.Add(txtBuscar);
            Controls.Add(cmbDepartamento);
            Controls.Add(txtSalario);
            Controls.Add(txtTelefono);
            Controls.Add(dtpNacimiento);
            Controls.Add(txtNombre);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Font = new Font("Arial", 12F);
            Margin = new Padding(4);
            Name = "FrmEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmEmpleados_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGanancia).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtDireccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockMax).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private ToolStrip toolStrip1;
        private ToolStripButton btnVentas;
        private TextBox txtPrecioLista;
        private Label label11;
        private Label label10;
        private NumericUpDown numGanancia;
        private NumericUpDown txtDireccion;
        private ComboBox cmbCargo;
        private Button btnCancelar;
        private Button btnGuardar;
        private DataGridView dgvLista;
        private TextBox txtBuscar;
        private ComboBox cmbDepartamento;
        private TextBox txtSalario;
        private TextBox txtTelefono;
        private DateTimePicker dtpNacimiento;
        private TextBox txtNombre;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btnSalir;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnNuevo;
        private Panel panel4;
        private PictureBox pictureBox3;
        private Label labelAdvertencia;
        private NumericUpDown stockMin;
        private NumericUpDown stockMax;
        private Label label12;
        private Label label13;
    }
}