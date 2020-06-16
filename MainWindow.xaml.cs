using System;
using System.Threading;
using System.Windows;
using System.Windows.Media;

namespace MorseCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int TimeUnitDuration = 500;

        private Thread playThread;

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

        private void Play(object sender, RoutedEventArgs e)
        {
            if (playThread == null)
            {
                playThread = new Thread(new ParameterizedThreadStart(Play));
                playThread.Start(textBox.Text);
                bPlay.Content = "Stop";
            }
            else
            {
                playThread.Interrupt();
            }
        }

        private void Play(object text)
        {
            Console.WriteLine("Starting playback");
            try
            {
                foreach (char c in (string)text)
                {
                    Wait(1);
                    Console.WriteLine("Play: " + c);
                    switch (c)
                    {
                        case '.':
                            Flash(1);
                            break;
                        case '-':
                            Flash(3);
                            break;
                        case ' ':
                            // Bij ieder teken wachten we ook al 1 eenheid en 1 + 2 = 3.
                            Wait(2);
                            break;
                        case '/':
                            // Om een '/' staan ook al spaties en 1 + 2 + 1 + 1 + 2 = 7.
                            break;
                        default:
                            throw new FormatException("Invalid character: " + c);
                    }
                }
                Console.WriteLine("Playback completed");
            }
            catch (ThreadInterruptedException)
            {
                Console.WriteLine("Playback aborted");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Playback error: " + ex);
            }

            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                textBox.Background = Brushes.White;
                bPlay.Content = "Afspelen";
            }));
            playThread = null;
        }

        private void Flash(int duration)
        {
            SetBackground(Brushes.Yellow);
            Wait(duration);
            SetBackground(Brushes.White);
        }

        private void Wait(int duration)
        {
            Thread.Sleep(duration * TimeUnitDuration);
        }

        private void SetBackground(Brush brush)
        {
            Application.Current.Dispatcher.Invoke(new Action(() =>
            {
                textBox.Background = brush;
            }));
        }
    }
}