using System;
using System.Windows;

namespace MorseCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBox.Focus();
        }

        private void ToMorse(object sender, RoutedEventArgs e)
        {
            Convert(true);
        }

        private void FromMorse(object sender, RoutedEventArgs e)
        {
            Convert(false);
        }

        private void Convert(bool to)
        {
            try
            {
                textBox.Text = to ? Morse.To(textBox.Text) : Morse.From(textBox.Text);
            }
            catch (MorseException ex)
            {
                MessageBox.Show("Ongeldige invoer: " + ex.Value, "Fout",
                   MessageBoxButton.OK, MessageBoxImage.Error);
                textBox.Select(ex.Index, ex.Length);
                textBox.Focus();
            }
        }
    }
}