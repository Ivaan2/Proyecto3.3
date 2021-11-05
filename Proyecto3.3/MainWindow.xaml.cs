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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Proyecto3._3
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            if ((bool)this.modalidad1.IsChecked)
            {
                MessageBox.Show("Nombre: " + this.nombre.Text + ", apellidos: " + this.apellidos.Text + ". \nCurso: " + this.curso.Text + ", modalidad: " + this.modalidad1.Content);
            }
            else
            {
                MessageBox.Show("Nombre: " + this.nombre.Text + ", apellidos: " + this.apellidos.Text + ". \nCurso: " + this.curso.Text + ", modalidad: " + this.modalidad2.Content);
            }
        }
        
    }
}
