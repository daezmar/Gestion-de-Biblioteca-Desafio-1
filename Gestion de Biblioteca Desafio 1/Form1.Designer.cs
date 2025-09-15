namespace Gestion_de_Biblioteca_Desafio_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewLibros = new System.Windows.Forms.DataGridView();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.dataGridViewPrestamos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTLibro = new System.Windows.Forms.Label();
            this.txtTituloLibro = new System.Windows.Forms.TextBox();
            this.txtAutorLibro = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtAnioLibro = new System.Windows.Forms.TextBox();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.lblcorreo = new System.Windows.Forms.Label();
            this.btnAgregarLibro = new System.Windows.Forms.Button();
            this.btnEditarLibro = new System.Windows.Forms.Button();
            this.btnEliminarLibro = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.dateTimePickerFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEliminarPrestamo = new System.Windows.Forms.Button();
            this.btnAgregarPrestamo = new System.Windows.Forms.Button();
            this.chartLibros = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartUsuarios = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnEditarPrestamo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewLibros);
            this.groupBox1.Location = new System.Drawing.Point(214, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(407, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Libros";
            // 
            // dataGridViewLibros
            // 
            this.dataGridViewLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibros.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewLibros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewLibros.Name = "dataGridViewLibros";
            this.dataGridViewLibros.Size = new System.Drawing.Size(401, 150);
            this.dataGridViewLibros.TabIndex = 0;
            this.dataGridViewLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLibros_CellClick);
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(342, 150);
            this.dataGridViewUsuarios.TabIndex = 1;
            this.dataGridViewUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuarios_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewUsuarios);
            this.groupBox2.Location = new System.Drawing.Point(214, 264);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(348, 174);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administrar Usuarios";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbLibro);
            this.groupBox3.Controls.Add(this.cmbUsuario);
            this.groupBox3.Controls.Add(this.dataGridViewPrestamos);
            this.groupBox3.Location = new System.Drawing.Point(262, 470);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(561, 176);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gestionar Prestamos";
            // 
            // cmbLibro
            // 
            this.cmbLibro.FormattingEnabled = true;
            this.cmbLibro.Location = new System.Drawing.Point(192, 20);
            this.cmbLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(108, 21);
            this.cmbLibro.TabIndex = 0;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(6, 19);
            this.cmbUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(180, 21);
            this.cmbUsuario.TabIndex = 1;
            // 
            // dataGridViewPrestamos
            // 
            this.dataGridViewPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrestamos.Location = new System.Drawing.Point(6, 48);
            this.dataGridViewPrestamos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewPrestamos.Name = "dataGridViewPrestamos";
            this.dataGridViewPrestamos.Size = new System.Drawing.Size(549, 123);
            this.dataGridViewPrestamos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestión de Biblioteca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(653, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aplicación de escritorio para la gestión de una biblioteca que permite adminstrar" +
    " libros, usuarios y préstamos meidante un CRUD completo";
            // 
            // lblTLibro
            // 
            this.lblTLibro.AutoSize = true;
            this.lblTLibro.Location = new System.Drawing.Point(38, 96);
            this.lblTLibro.Name = "lblTLibro";
            this.lblTLibro.Size = new System.Drawing.Size(33, 13);
            this.lblTLibro.TabIndex = 1;
            this.lblTLibro.Text = "Titulo";
            // 
            // txtTituloLibro
            // 
            this.txtTituloLibro.Location = new System.Drawing.Point(80, 89);
            this.txtTituloLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTituloLibro.Name = "txtTituloLibro";
            this.txtTituloLibro.Size = new System.Drawing.Size(100, 20);
            this.txtTituloLibro.TabIndex = 5;
            // 
            // txtAutorLibro
            // 
            this.txtAutorLibro.Location = new System.Drawing.Point(80, 125);
            this.txtAutorLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAutorLibro.Name = "txtAutorLibro";
            this.txtAutorLibro.Size = new System.Drawing.Size(100, 20);
            this.txtAutorLibro.TabIndex = 7;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(38, 132);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(32, 13);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Autor";
            // 
            // txtAnioLibro
            // 
            this.txtAnioLibro.Location = new System.Drawing.Point(80, 163);
            this.txtAnioLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAnioLibro.Name = "txtAnioLibro";
            this.txtAnioLibro.Size = new System.Drawing.Size(100, 20);
            this.txtAnioLibro.TabIndex = 9;
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(38, 170);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 8;
            this.lblAnio.Text = "Año";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(80, 298);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNombreUsuario.TabIndex = 11;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(38, 305);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Location = new System.Drawing.Point(80, 334);
            this.txtCorreoUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtCorreoUsuario.TabIndex = 13;
            // 
            // lblcorreo
            // 
            this.lblcorreo.AutoSize = true;
            this.lblcorreo.Location = new System.Drawing.Point(38, 342);
            this.lblcorreo.Name = "lblcorreo";
            this.lblcorreo.Size = new System.Drawing.Size(32, 13);
            this.lblcorreo.TabIndex = 12;
            this.lblcorreo.Text = "Email";
            // 
            // btnAgregarLibro
            // 
            this.btnAgregarLibro.Location = new System.Drawing.Point(40, 209);
            this.btnAgregarLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarLibro.Name = "btnAgregarLibro";
            this.btnAgregarLibro.Size = new System.Drawing.Size(75, 22);
            this.btnAgregarLibro.TabIndex = 2;
            this.btnAgregarLibro.Text = "Agregar";
            this.btnAgregarLibro.UseVisualStyleBackColor = true;
            this.btnAgregarLibro.Click += new System.EventHandler(this.btnAgregarLibro_Click);
            // 
            // btnEditarLibro
            // 
            this.btnEditarLibro.Location = new System.Drawing.Point(122, 209);
            this.btnEditarLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditarLibro.Name = "btnEditarLibro";
            this.btnEditarLibro.Size = new System.Drawing.Size(75, 22);
            this.btnEditarLibro.TabIndex = 14;
            this.btnEditarLibro.Text = "Editar";
            this.btnEditarLibro.UseVisualStyleBackColor = true;
            this.btnEditarLibro.Click += new System.EventHandler(this.btnEditarLibro_Click);
            // 
            // btnEliminarLibro
            // 
            this.btnEliminarLibro.Location = new System.Drawing.Point(80, 238);
            this.btnEliminarLibro.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarLibro.Name = "btnEliminarLibro";
            this.btnEliminarLibro.Size = new System.Drawing.Size(75, 22);
            this.btnEliminarLibro.TabIndex = 15;
            this.btnEliminarLibro.Text = "Eliminar";
            this.btnEliminarLibro.UseVisualStyleBackColor = true;
            this.btnEliminarLibro.Click += new System.EventHandler(this.btnEliminarLibro_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(80, 399);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 22);
            this.btnEliminarUsuario.TabIndex = 18;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(122, 370);
            this.btnEditarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(75, 22);
            this.btnEditarUsuario.TabIndex = 17;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(40, 370);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(75, 22);
            this.btnAgregarUsuario.TabIndex = 16;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.Location = new System.Drawing.Point(38, 490);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(51, 13);
            this.lblPrestamo.TabIndex = 19;
            this.lblPrestamo.Text = "Préstamo";
            // 
            // dateTimePickerFechaPrestamo
            // 
            this.dateTimePickerFechaPrestamo.Location = new System.Drawing.Point(40, 512);
            this.dateTimePickerFechaPrestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerFechaPrestamo.Name = "dateTimePickerFechaPrestamo";
            this.dateTimePickerFechaPrestamo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaPrestamo.TabIndex = 20;
            // 
            // dateTimePickerFechaDevolucion
            // 
            this.dateTimePickerFechaDevolucion.Location = new System.Drawing.Point(40, 564);
            this.dateTimePickerFechaDevolucion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerFechaDevolucion.Name = "dateTimePickerFechaDevolucion";
            this.dateTimePickerFechaDevolucion.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaDevolucion.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 542);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Devolución";
            // 
            // btnEliminarPrestamo
            // 
            this.btnEliminarPrestamo.Location = new System.Drawing.Point(105, 633);
            this.btnEliminarPrestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            this.btnEliminarPrestamo.Size = new System.Drawing.Size(75, 22);
            this.btnEliminarPrestamo.TabIndex = 25;
            this.btnEliminarPrestamo.Text = "Eliminar";
            this.btnEliminarPrestamo.UseVisualStyleBackColor = true;
            this.btnEliminarPrestamo.Click += new System.EventHandler(this.btnEliminarPrestamo_Click);
            // 
            // btnAgregarPrestamo
            // 
            this.btnAgregarPrestamo.Location = new System.Drawing.Point(66, 603);
            this.btnAgregarPrestamo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarPrestamo.Name = "btnAgregarPrestamo";
            this.btnAgregarPrestamo.Size = new System.Drawing.Size(75, 22);
            this.btnAgregarPrestamo.TabIndex = 23;
            this.btnAgregarPrestamo.Text = "Agregar";
            this.btnAgregarPrestamo.UseVisualStyleBackColor = true;
            this.btnAgregarPrestamo.Click += new System.EventHandler(this.btnAgregarPrestamo_Click);
            // 
            // chartLibros
            // 
            chartArea5.Name = "ChartArea1";
            this.chartLibros.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartLibros.Legends.Add(legend5);
            this.chartLibros.Location = new System.Drawing.Point(627, 89);
            this.chartLibros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartLibros.Name = "chartLibros";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartLibros.Series.Add(series5);
            this.chartLibros.Size = new System.Drawing.Size(300, 157);
            this.chartLibros.TabIndex = 26;
            this.chartLibros.Text = "chart1";
            // 
            // chartUsuarios
            // 
            chartArea6.Name = "ChartArea1";
            this.chartUsuarios.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartUsuarios.Legends.Add(legend6);
            this.chartUsuarios.Location = new System.Drawing.Point(627, 264);
            this.chartUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartUsuarios.Name = "chartUsuarios";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartUsuarios.Series.Add(series6);
            this.chartUsuarios.Size = new System.Drawing.Size(300, 157);
            this.chartUsuarios.TabIndex = 27;
            this.chartUsuarios.Text = "chart2";
            // 
            // btnEditarPrestamo
            // 
            this.btnEditarPrestamo.Location = new System.Drawing.Point(147, 603);
            this.btnEditarPrestamo.Name = "btnEditarPrestamo";
            this.btnEditarPrestamo.Size = new System.Drawing.Size(75, 23);
            this.btnEditarPrestamo.TabIndex = 1;
            this.btnEditarPrestamo.Text = "Editar";
            this.btnEditarPrestamo.UseVisualStyleBackColor = true;
            this.btnEditarPrestamo.Click += new System.EventHandler(this.btnEditarPrestamo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 712);
            this.Controls.Add(this.btnEditarPrestamo);
            this.Controls.Add(this.chartUsuarios);
            this.Controls.Add(this.chartLibros);
            this.Controls.Add(this.btnEliminarPrestamo);
            this.Controls.Add(this.btnAgregarPrestamo);
            this.Controls.Add(this.dateTimePickerFechaDevolucion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePickerFechaPrestamo);
            this.Controls.Add(this.lblPrestamo);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.btnEliminarLibro);
            this.Controls.Add(this.btnEditarLibro);
            this.Controls.Add(this.btnAgregarLibro);
            this.Controls.Add(this.txtCorreoUsuario);
            this.Controls.Add(this.lblcorreo);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtAnioLibro);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.txtAutorLibro);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtTituloLibro);
            this.Controls.Add(this.lblTLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Gestión de Biblioteca";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewLibros;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewPrestamos;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTLibro;
        private System.Windows.Forms.TextBox txtTituloLibro;
        private System.Windows.Forms.TextBox txtAutorLibro;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtAnioLibro;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.Label lblcorreo;
        private System.Windows.Forms.Button btnAgregarLibro;
        private System.Windows.Forms.Button btnEditarLibro;
        private System.Windows.Forms.Button btnEliminarLibro;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaDevolucion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEliminarPrestamo;
        private System.Windows.Forms.Button btnAgregarPrestamo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLibros;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsuarios;
        private System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.Button btnEditarPrestamo;
    }
}

