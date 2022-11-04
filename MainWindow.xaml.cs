using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Superheroe.modelos;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Superheroe
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int pagina = 1;
        public MainWindow()
        {
            InitializeComponent();
            ShowHeroes();
        }

        public void ShowHeroes() {
            List<Superhero> superheroes = new List<Superhero>();
            superheroes = Superhero.GetSamples();

            datosSuperheroeDockPanel.DataContext = superheroes[pagina - 1];
            if (((Superhero)datosSuperheroeDockPanel.DataContext).Heroe == true)
            {
                SolidColorBrush c = new SolidColorBrush();
                c.Color = Colors.LightGreen;
                ventanaWindow.Background = c;
            }
            else
            {
                SolidColorBrush e = new SolidColorBrush();
                e.Color = Colors.IndianRed;
                ventanaWindow.Background = e;
            }
            if (((Superhero)datosSuperheroeDockPanel.DataContext).Vengador == true)
            {
                AImagen.Visibility = Visibility.Visible;
            }
            else
            {
                AImagen.Visibility = Visibility.Collapsed;
            }
            if (((Superhero)datosSuperheroeDockPanel.DataContext).Xmen == true)
            {
                XImagen.Visibility = Visibility.Visible;
            }
            else
            {
                XImagen.Visibility = Visibility.Collapsed;
            }
        }

        private void ImageRight_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (pagina < 3 && pagina>0) {
                pagina++;
                numeroPaginaTextBlock.Text = $"{pagina}/3";
                ShowHeroes();
            }
        }

        private void ImageLeft_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (pagina <= 3 && pagina > 1)
            {
                pagina--;
                numeroPaginaTextBlock.Text = $"{pagina}/3";
                ShowHeroes();
            }
        }
    }
}
