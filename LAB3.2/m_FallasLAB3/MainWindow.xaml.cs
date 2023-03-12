using m_FallasLAB3.Clases;
using m_FallasLAB3.Datos;
using m_FallasLAB3.Utilidades;
using m_FallasLAB3.Ventanas;
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

namespace m_FallasLAB3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtUsuario_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            util.validarSoloLetras(e);
        }

        private void btnIngresar_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsuario.Text.Length > 0 && txtClave.Password.ToString().Length > 0)
            {
                clsUsuario usuario = new clsUsuario(txtUsuario.Text, txtClave.Password.ToString());

                //data transfer object DTO que comunica con la base de datos
                dtoUsuario usu = new dtoUsuario();
                if (usu.validarIngreso(usuario) == true)
                {
                    variablesGloables.usuariologin = usuario.Usuario;
                    Ventanas.Menu ventana = new Ventanas.Menu();
                    ventana.ShowDialog();

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

        }
    }
}
