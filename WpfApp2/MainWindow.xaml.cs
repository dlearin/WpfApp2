﻿using System;
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

namespace WpfApp2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> listaPob = new List<Poblaciones>();

            listaPob.Add(new Poblaciones() { Poblacion1 = "Madrid", Poblacion2 = "Barcelona", Temperatura1 = 15, Temperatura2 = 17, DiferenciaTemp = 2 }) ;
            listaPob.Add(new Poblaciones() { Poblacion1 = "Valencia", Poblacion2 = "Alicante", Temperatura1 = 15, Temperatura2 = 17, DiferenciaTemp = 1});
            listaPob.Add(new Poblaciones() { Poblacion1 = "Malaga", Poblacion2 = "Bilbao", Temperatura1 = 15, Temperatura2 = 17, DiferenciaTemp =13});
            listaPob.Add(new Poblaciones() { Poblacion1 = "Sevilla", Poblacion2 = "Coruña", Temperatura1 = 15, Temperatura2 = 17, DiferenciaTemp = 14});
            
            listaPoblaciones.ItemsSource = listaPob; 

}

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (listaPoblaciones.SelectedItem != null) { 

            MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " "
                + (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " ºC " + (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " "
                + (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " ºC");
            }
            else
            {
                MessageBox.Show("Selecciona un elemento");            }
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (listaPoblaciones.SelectedItem != null)
            {

                MessageBox.Show((listaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + " "
                    + (listaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " ºC " + (listaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + " "
                    + (listaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " ºC");
            }
            else
            {
                MessageBox.Show("Selecciona un elemento");
            }
        }
    }
    }





    public class Poblaciones
    {

        public string Poblacion1 { get; set; }

        public int Temperatura1 { get; set; }

        public string Poblacion2 { get; set; }

        public int Temperatura2 { get; set; }

        public int DiferenciaTemp { get; set; }




    }
}
