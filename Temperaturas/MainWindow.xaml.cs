using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Práctica_1_1
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

        private void Boton_Transformar_Click(object sender, RoutedEventArgs e)
        {
            TextBox tbc = Text_Celsius;
            TextBox tbf = Text_Fahrenheit;
            TextBox tf = Text_Fah;
            TextBox tc = Text_Cel;

            double celsius, fahrenheit, C, F;

            C = double.Parse(tbc.Text);
            F = double.Parse(tbf.Text);

            celsius = (F - 32) * (5.0/9.0);
            fahrenheit = (C * (9.0/5.0)) +32;

            tf.Text = fahrenheit.ToString();
            tc.Text = celsius.ToString();
        }
    }
}
