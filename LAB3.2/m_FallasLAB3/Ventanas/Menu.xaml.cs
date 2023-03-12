using System.Windows;


namespace m_FallasLAB3.Ventanas
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void btnUsuario_Click(object sender, RoutedEventArgs e)
        {
            MTMUsuarios ventana = new MTMUsuarios();
            ventana.ShowDialog();
        }
    }
}
