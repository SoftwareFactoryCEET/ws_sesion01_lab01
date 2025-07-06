using Models;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GUIWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Circunferencia circunferencia;
        public MainWindow()
        {
            InitializeComponent();
            circunferencia = new Circunferencia();
        }

        private void ButtonCalcular_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (RadioButtonArea.IsChecked == true)
                {
                    circunferencia.SetRadio(Convert.ToDouble(TexBoxRadio.Text));
                    LabelResultado.Content = $"El área de la circunferencia es: {circunferencia.Area()} m^2";

                }
                else if (RadioButtonPerimetro.IsChecked == true)
                {
                    circunferencia.SetRadio(Convert.ToDouble(TexBoxRadio.Text));
                    LabelResultado.Content = $"El peímetro de la circunferencia es: {circunferencia.Perimetro()} m";
                }
                else
                {
                    LabelResultado.Content = "Debe seleccionar un tipo de operación (área ó Perímetro)";
                }
            }
            catch (ArgumentException aex)
            {

                LabelResultado.Content = aex.Message;
            }


           
        }

        private void TexBoxRadio_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Permitir solo dígitos y punto decimal
            e.Handled = !Regex.IsMatch(e.Text, @"^[0-9\.]+$");

        }
    }
}