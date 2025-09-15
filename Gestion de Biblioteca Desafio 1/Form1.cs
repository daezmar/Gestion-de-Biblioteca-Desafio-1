using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Gestion_de_Biblioteca_Desafio_1
{
    public partial class Form1 : Form
    {
        private List<Libro> libros = new List<Libro>();
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Prestamo> prestamos = new List<Prestamo>();
        private int ultimoIdLibro = 0;
        private int ultimoIdUsuario = 0;
        private int ultimoIdPrestamo = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            ConfigurarDataGridViews();
            CargarDatosDePrueba();
            ActualizarTodo();
        }

        private void ConfigurarDataGridViews()
        {
            // Configuración de la tabla de Libros
            dataGridViewLibros.AutoGenerateColumns = false;
            dataGridViewLibros.Columns.Add("ID", "ID");
            dataGridViewLibros.Columns.Add("Titulo", "Título");
            dataGridViewLibros.Columns.Add("Autor", "Autor");
            dataGridViewLibros.Columns.Add("Anio", "Año");

            // Configuración de la tabla de Usuarios
            dataGridViewUsuarios.AutoGenerateColumns = false;
            dataGridViewUsuarios.Columns.Add("ID", "ID");
            dataGridViewUsuarios.Columns.Add("Nombre", "Nombre");
            dataGridViewUsuarios.Columns.Add("CorreoElectronico", "Correo Electrónico");

            // Configuración de la tabla de Préstamos
            dataGridViewPrestamos.AutoGenerateColumns = false;
            dataGridViewPrestamos.Columns.Add("ID", "ID");
            dataGridViewPrestamos.Columns.Add("Usuario", "Usuario");
            dataGridViewPrestamos.Columns.Add("Libro", "Libro");
            dataGridViewPrestamos.Columns.Add("FechaDePrestamo", "Fecha de Préstamo");
            dataGridViewPrestamos.Columns.Add("FechaDeDevolucion", "Fecha de Devolución");
        }

        private void CargarDatosDePrueba()
        {
            // Libros de prueba
            libros.Add(new Libro { ID = ++ultimoIdLibro, Titulo = "El Gran Gatsby", Autor = "F. Scott Fitzgerald", Anio = "1925" });
            libros.Add(new Libro { ID = ++ultimoIdLibro, Titulo = "Matar a un Ruiseñor", Autor = "Harper Lee", Anio = "1960" });
            libros.Add(new Libro { ID = ++ultimoIdLibro, Titulo = "1984", Autor = "George Orwell", Anio = "1949" });
            libros.Add(new Libro { ID = ++ultimoIdLibro, Titulo = "Orgullo y Prejuicio", Autor = "Jane Austen", Anio = "1813" });

            // Usuarios de prueba
            usuarios.Add(new Usuario { ID = ++ultimoIdUsuario, Nombre = "Juan Perez", CorreoElectronico = "juan.perez@email.com" });
            usuarios.Add(new Usuario { ID = ++ultimoIdUsuario, Nombre = "Maria Gomez", CorreoElectronico = "maria.gomez@email.com" });
            usuarios.Add(new Usuario { ID = ++ultimoIdUsuario, Nombre = "Ana Torres", CorreoElectronico = "ana.torres@email.com" });

            // Préstamos de prueba
            prestamos.Add(new Prestamo { ID = ++ultimoIdPrestamo, ID_Usuario = 1, ID_Libro = 1, FechaDePrestamo = DateTime.Now.AddDays(-10), FechaDeDevolucion = DateTime.Now.AddDays(-5) });
            prestamos.Add(new Prestamo { ID = ++ultimoIdPrestamo, ID_Usuario = 2, ID_Libro = 2, FechaDePrestamo = DateTime.Now.AddDays(-20), FechaDeDevolucion = DateTime.Now.AddDays(-15) });
            prestamos.Add(new Prestamo { ID = ++ultimoIdPrestamo, ID_Usuario = 3, ID_Libro = 3, FechaDePrestamo = DateTime.Now.AddDays(-5), FechaDeDevolucion = DateTime.Now.AddDays(-2) });
        }

        private void ActualizarTodo()
        {
            ActualizarDataGridViewLibros();
            ActualizarDataGridViewUsuarios();
            ActualizarDataGridViewPrestamos();
            CargarComboPrestamos();
            ActualizarGraficos();
        }

        // Lógica para Libros

        private void dataGridViewLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegurarse de que el clic es en una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridViewLibros.Rows[e.RowIndex];
                txtTituloLibro.Text = fila.Cells[1].Value.ToString();
                txtAutorLibro.Text = fila.Cells[2].Value.ToString();
                txtAnioLibro.Text = fila.Cells[3].Value.ToString();
            }
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTituloLibro.Text) || string.IsNullOrWhiteSpace(txtAutorLibro.Text) || string.IsNullOrWhiteSpace(txtAnioLibro.Text))
            {
                MessageBox.Show("Complete todos los campos para agregar un libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Libro nuevoLibro = new Libro
            {
                ID = ++ultimoIdLibro,
                Titulo = txtTituloLibro.Text,
                Autor = txtAutorLibro.Text,
                Anio = txtAnioLibro.Text
            };
            libros.Add(nuevoLibro);
            ActualizarDataGridViewLibros();
            LimpiarCamposLibros();
        }

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            if (dataGridViewLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del libro seleccionado
            int idLibro = (int)dataGridViewLibros.SelectedRows[0].Cells[0].Value;
            Libro libroAEditar = libros.FirstOrDefault(l => l.ID == idLibro);

            if (libroAEditar != null)
            {
                libroAEditar.Titulo = txtTituloLibro.Text;
                libroAEditar.Autor = txtAutorLibro.Text;
                libroAEditar.Anio = txtAnioLibro.Text;
                ActualizarDataGridViewLibros();
                MessageBox.Show("Libro editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dataGridViewLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = (int)dataGridViewLibros.SelectedRows[0].Cells[0].Value;
            libros.RemoveAll(l => l.ID == id);
            ActualizarDataGridViewLibros();
        }

        private void ActualizarDataGridViewLibros()
        {
            dataGridViewLibros.Rows.Clear();
            foreach (var libro in libros)
            {
                dataGridViewLibros.Rows.Add(libro.ID, libro.Titulo, libro.Autor, libro.Anio);
            }
            ActualizarGraficos();
        }

        private void LimpiarCamposLibros()
        {
            txtTituloLibro.Clear();
            txtAutorLibro.Clear();
            txtAnioLibro.Clear();
        }

        // Lógica para Usuarios

        private void dataGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asegurarse de que el clic es en una fila válida
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridViewUsuarios.Rows[e.RowIndex];
                txtNombreUsuario.Text = fila.Cells[1].Value.ToString();
                txtCorreoUsuario.Text = fila.Cells[2].Value.ToString();
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) || string.IsNullOrWhiteSpace(txtCorreoUsuario.Text))
            {
                MessageBox.Show("Complete todos los campos para agregar un usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario nuevoUsuario = new Usuario
            {
                ID = ++ultimoIdUsuario,
                Nombre = txtNombreUsuario.Text,
                CorreoElectronico = txtCorreoUsuario.Text
            };
            usuarios.Add(nuevoUsuario);
            ActualizarDataGridViewUsuarios();
            LimpiarCamposUsuarios();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el ID del usuario seleccionado
            int idUsuario = (int)dataGridViewUsuarios.SelectedRows[0].Cells[0].Value;
            Usuario usuarioAEditar = usuarios.FirstOrDefault(u => u.ID == idUsuario);

            if (usuarioAEditar != null)
            {
                usuarioAEditar.Nombre = txtNombreUsuario.Text;
                usuarioAEditar.CorreoElectronico = txtCorreoUsuario.Text;
                ActualizarDataGridViewUsuarios();
                MessageBox.Show("Usuario editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = (int)dataGridViewUsuarios.SelectedRows[0].Cells[0].Value;
            usuarios.RemoveAll(u => u.ID == id);
            ActualizarDataGridViewUsuarios();
        }

        private void ActualizarDataGridViewUsuarios()
        {
            dataGridViewUsuarios.Rows.Clear();
            foreach (var usuario in usuarios)
            {
                dataGridViewUsuarios.Rows.Add(usuario.ID, usuario.Nombre, usuario.CorreoElectronico);
            }
            ActualizarGraficos();
        }

        private void LimpiarCamposUsuarios()
        {
            txtNombreUsuario.Clear();
            txtCorreoUsuario.Clear();
        }

        // Lógica para Préstamos
        private void CargarComboPrestamos()
        {
            // Limpiar los ComboBox antes de cargar
            cmbUsuario.DataSource = null;
            cmbLibro.DataSource = null;

            cmbUsuario.DataSource = usuarios;
            cmbUsuario.DisplayMember = "Nombre";
            cmbUsuario.ValueMember = "ID";

            cmbLibro.DataSource = libros;
            cmbLibro.DisplayMember = "Titulo";
            cmbLibro.ValueMember = "ID";
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.SelectedItem == null || cmbLibro.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un usuario y un libro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuario = (int)cmbUsuario.SelectedValue;
            int idLibro = (int)cmbLibro.SelectedValue;

            Prestamo nuevoPrestamo = new Prestamo
            {
                ID = ++ultimoIdPrestamo,
                ID_Usuario = idUsuario,
                ID_Libro = idLibro,
                FechaDePrestamo = dateTimePickerFechaPrestamo.Value,
                FechaDeDevolucion = dateTimePickerFechaDevolucion.Value
            };
            prestamos.Add(nuevoPrestamo);
            ActualizarDataGridViewPrestamos();
        }

        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrestamos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = (int)dataGridViewPrestamos.SelectedRows[0].Cells[0].Value;
            prestamos.RemoveAll(p => p.ID == id);
            ActualizarDataGridViewPrestamos();
        }

        private void btnEditarPrestamo_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada en el DataGridView
            if (dataGridViewPrestamos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un préstamo para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtiene el ID del préstamo de la fila seleccionada
            int idPrestamo = (int)dataGridViewPrestamos.SelectedRows[0].Cells[0].Value;

            // Busca el objeto Prestamo en la lista
            Prestamo prestamoAEditar = prestamos.FirstOrDefault(p => p.ID == idPrestamo);

            // Si el préstamo existe, actualiza sus propiedades
            if (prestamoAEditar != null)
            {
                // Actualiza los datos del objeto
                // Obtiene los IDs del usuario y libro seleccionados en los ComboBox
                int idUsuarioSeleccionado = (int)cmbUsuario.SelectedValue;
                int idLibroSeleccionado = (int)cmbLibro.SelectedValue;

                // Asigna los nuevos valores al objeto Prestamo
                prestamoAEditar.ID_Usuario = idUsuarioSeleccionado;
                prestamoAEditar.ID_Libro = idLibroSeleccionado;
                prestamoAEditar.FechaDePrestamo = dateTimePickerFechaPrestamo.Value;
                prestamoAEditar.FechaDeDevolucion = dateTimePickerFechaDevolucion.Value;

                // Actualiza el DataGridView para reflejar los cambios
                ActualizarDataGridViewPrestamos();

                MessageBox.Show("Préstamo editado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActualizarDataGridViewPrestamos()
        {
            dataGridViewPrestamos.Rows.Clear();
            foreach (var prestamo in prestamos)
            {
                // Busca los objetos Usuario y Libro correspondientes al préstamo
                var usuario = usuarios.FirstOrDefault(u => u.ID == prestamo.ID_Usuario);
                var libro = libros.FirstOrDefault(l => l.ID == prestamo.ID_Libro);

                // Agrega la fila al DataGridView
                dataGridViewPrestamos.Rows.Add(
                    prestamo.ID,
                    usuario?.Nombre,
                    libro?.Titulo,
                    prestamo.FechaDePrestamo.ToShortDateString(),
                    prestamo.FechaDeDevolucion.ToShortDateString()
                );
            }
            ActualizarGraficos();
        }

        // Lógica para Gráficos
        private void ActualizarGraficos()
        {
            // Gráfico de Libros Más Prestados
            chartLibros.Series.Clear();
            var librosPrestados = prestamos
                .GroupBy(p => p.ID_Libro)
                .Select(g => new { LibroID = g.Key, Cantidad = g.Count() })
                .OrderByDescending(x => x.Cantidad)
                .Take(5)
                .ToList();

            Series serieLibros = new Series("Libros más prestados");
            serieLibros.ChartType = SeriesChartType.Bar;
            foreach (var item in librosPrestados)
            {
                string tituloLibro = libros.FirstOrDefault(l => l.ID == item.LibroID)?.Titulo ?? "Desconocido";
                serieLibros.Points.AddXY(tituloLibro, item.Cantidad);
            }
            chartLibros.Series.Add(serieLibros);

            // Gráfico de Usuarios Más Activos
            chartUsuarios.Series.Clear();
            var usuariosActivos = prestamos
                .GroupBy(p => p.ID_Usuario)
                .Select(g => new { UsuarioID = g.Key, Cantidad = g.Count() })
                .OrderByDescending(x => x.Cantidad)
                .Take(5)
                .ToList();

            Series serieUsuarios = new Series("Usuarios más activos");
            serieUsuarios.ChartType = SeriesChartType.Bar;
            foreach (var item in usuariosActivos)
            {
                string nombreUsuario = usuarios.FirstOrDefault(u => u.ID == item.UsuarioID)?.Nombre ?? "Desconocido";
                serieUsuarios.Points.AddXY(nombreUsuario, item.Cantidad);
            }
            chartUsuarios.Series.Add(serieUsuarios);
        }
    }
}
