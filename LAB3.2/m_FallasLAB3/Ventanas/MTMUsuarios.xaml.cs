using m_FallasLAB3.Clases;
using m_FallasLAB3.Utilidades;
using m_FallasLAB3.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;
using System.Data.SqlClient;
using m_FallasLAB3.BD;

namespace m_FallasLAB3.Ventanas
{
    /// <summary>
    /// Lógica de interacción para MTMUsuarios.xaml
    /// </summary>
    public partial class MTMUsuarios : Window
    {
        public MTMUsuarios()
        {
            InitializeComponent();
            cargarUsuarios();

            btnAgregarUsuario.IsEnabled = true;
            btnActualizar.IsEnabled = false;
            btnEliminar.IsEnabled = false;
            btnGuardar.IsEnabled = false;
            btnCancelar.IsEnabled = false;

            txtUsuario.IsEnabled = false;
            txtNombre.IsEnabled = false;
            txtIdentificacion.IsEnabled = false;
            txtClave.IsEnabled = false;
            txtApellidos.IsEnabled = false;
            txtActualizadoPor.IsEnabled = false;
            txtFechaActualizado.IsEnabled = false;  
            txtRegistradoPor.IsEnabled = false; 
            txtFechaRegistrado.IsEnabled = false;
        }
        public void cargarUsuarios()
        {
            cmbConsultarUsuarios.Items.Clear();
            dtoUsuario usu = new dtoUsuario();
            usu.consultarTodosUsuarios(cmbConsultarUsuarios);
        }

        private void btnAgregarUsuario_Click(object sender, RoutedEventArgs e)
        {
            btnActualizar.IsEnabled= false;
            btnGuardar.IsEnabled = true;
            btnEliminar.IsEnabled= false;
            btnCancelar.IsEnabled= true;
            txtUsuario.IsEnabled = true;
            txtNombre.IsEnabled = true;
            txtIdentificacion.IsEnabled = true;
            txtClave.IsEnabled = true;
            txtApellidos.IsEnabled = true;
            cmbConsultarUsuarios.IsEnabled = false;
            btnAgregarUsuario.IsEnabled=false;
            txtUsuario.Clear();
            txtClave.Clear();
            txtIdentificacion.Clear();
            txtApellidos.Clear();
            txtNombre.Clear();
            txtRegistradoPor.IsEnabled = false;
            txtActualizadoPor.IsEnabled = false;
            txtFechaActualizado.IsEnabled = false;
            txtFechaRegistrado.IsEnabled = false;
        }

        private void btnActualizarUsuario_Click(object sender, RoutedEventArgs e)
        {
            txtActualizadoPor.IsEnabled= false;
            txtRegistradoPor.IsEnabled = false;
            txtFechaActualizado.IsEnabled= false;
            txtFechaRegistrado.IsEnabled= false;

            txtUsuario.IsEnabled = true;
            txtNombre.IsEnabled = true;
            txtClave.IsEnabled= true;
            txtIdentificacion.IsEnabled= true;
            txtApellidos.IsEnabled = true;

            btnAgregarUsuario.IsEnabled = true;
            btnCancelar.IsEnabled = true;
            btnEliminar.IsEnabled = true;
            btnGuardar.IsEnabled = true;


            string estado;
            if (txtUsuario.Text.Length > 0 && txtClave.Text.Length > 0 && txtNombre.Text.Length > 0 && txtApellidos.Text.Length > 0 && txtIdentificacion.Text.Length > 0)
            {
                if (ckEstado.IsChecked == true)
                {
                    estado = "A";
                }
                else
                {
                    estado = "I";
                }

                clsUsuario usuario = new clsUsuario(0, txtUsuario.Text, txtClave.Text, txtIdentificacion.Text, estado, txtNombre.Text, txtApellidos.Text, variablesGloables.usuariologin, DateTime.Now);

                //data transfer object DTO que comunica con la base de datos,
                dtoUsuario usu = new dtoUsuario();
                if (usu.ActualizarUsuario(usuario, cmbConsultarUsuarios.SelectedItem.ToString()) == true)
                {
                    MessageBox.Show("Datos Modificados con éxito!");
                }
                else
                {
                    MessageBox.Show("Datos incorrectos!");
                }
            }
            else
            {
                MessageBox.Show("Debes completar los campos de Usuario y Clave");
            }
            Close();
        }

        private void btnBuscarUsuario_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmbConsultarUsuarios_Click(object sender, ContextMenuEventArgs e)
        {
            #region
            btnActualizar.IsEnabled= true;
            btnAgregarUsuario.IsEnabled = false;
            btnCancelar.IsEnabled = true;
            btnEliminar.IsEnabled = false;
            btnGuardar.IsEnabled = true;

            #endregion
        }

        private void btnGuardarUsuario_Click(object sender, RoutedEventArgs e)
        {
            string estado;
            if (txtUsuario.Text.Length > 0 && txtClave.Text.Length > 0 && txtNombre.Text.Length > 0 && txtApellidos.Text.Length > 0 && txtIdentificacion.Text.Length >0)
            {
                if (ckEstado.IsChecked == true)
                {
                    estado = "A";
                }
                else
                {
                    estado = "I";
                }

                clsUsuario usuario = new clsUsuario(txtUsuario.Text, txtClave.Text, txtIdentificacion.Text, estado,
                                                    txtNombre.Text, txtApellidos.Text, variablesGloables.usuariologin, DateTime.Now);

                dtoUsuario usu = new dtoUsuario();
                if (usu.guardarUsuario(usuario) == true)
                {
                    MessageBox.Show("Datos guardados");        
                    txtNombre.Clear();
                    txtApellidos.Clear();
                    txtIdentificacion.Clear();
                    txtUsuario.Clear();
                    txtClave.Clear();
                    btnAgregarUsuario.IsEnabled= true;
                    cmbConsultarUsuarios.IsEnabled= true;
                    btnGuardar.IsEnabled= false;
                    btnCancelar.IsEnabled= false;
                
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Debes completar los todos los campos.");
            }


        }

        private void btnEliminarUsuario_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmbConsultarUsuarios_SelecChanged(object sender, SelectionChangedEventArgs e)
        {

            txtUsuario.Text = cmbConsultarUsuarios.SelectedValue.ToString();
            btnActualizar.IsEnabled = true;
            btnAgregarUsuario.IsEnabled = false;
            btnCancelar.IsEnabled = true;
            btnEliminar.IsEnabled = false;
            btnGuardar.IsEnabled = false;

            txtNombre.IsEnabled = true;
            txtApellidos.IsEnabled = true;
            txtIdentificacion.IsEnabled = true;
            txtClave.IsEnabled = true;
            txtUsuario.IsEnabled = true;
        }

        private void btnCancelarUsuario_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult opcion;
            opcion = MessageBox.Show("Esta seguro que desea cancelar", "Salir", MessageBoxButton.YesNo, MessageBoxImage.Question);


            if (opcion == MessageBoxResult.Yes)
            {
                btnActualizar.IsEnabled = false;
                btnGuardar.IsEnabled = false;
                btnEliminar.IsEnabled = false;
                btnAgregarUsuario.IsEnabled = true;
                btnCancelar.IsEnabled = false;

                txtUsuario.IsEnabled = true;
                txtNombre.IsEnabled = true;
                txtIdentificacion.IsEnabled = true;
                txtClave.IsEnabled = true;
                txtApellidos.IsEnabled = true;
                cmbConsultarUsuarios.IsEnabled = true;
                txtUsuario.Clear();
                txtClave.Clear();
                txtIdentificacion.Clear();
                txtApellidos.Clear();
                txtNombre.Clear();
                txtRegistradoPor.IsEnabled = false;
                txtActualizadoPor.IsEnabled = false;
                txtFechaActualizado.IsEnabled = false;
                txtFechaRegistrado.IsEnabled = false;
            }
        }
    }
}
