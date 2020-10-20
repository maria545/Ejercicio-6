
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Ejercicio_6
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

        private void Imagen_MouseMove(object sender, MouseEventArgs e)
        {
            Image imagen = (Image)sender;
            imagen.Opacity = 1;
        }
        private void Imagen_MouseLeave(object sender, MouseEventArgs e)
        {
            Image imagen = (Image)sender;
            imagen.Opacity = 0.5;
        }
    }
}
