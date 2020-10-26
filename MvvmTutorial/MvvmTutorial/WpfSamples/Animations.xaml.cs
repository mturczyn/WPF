using System.Diagnostics;
using System.Windows;
using System.Windows.Media;

namespace MvvmTutorial.WpfSamples
{
    /// <summary>
    /// Interaction logic for Animations.xaml
    /// </summary>
    public partial class Animations
    {
        public Animations() => InitializeComponent();

        private void FirstButtonColorAnimation_Completed(object sender, System.EventArgs e)
        {
            Debug.WriteLine("Setting first button to black background");
            FirstButton.Background = Brushes.Black;
        }

        private void SecondButtonColorAnimation_Completed(object sender, System.EventArgs e)
        {
            Debug.WriteLine("Setting second button to black background");
            SecondButtonStroyboard.Remove(SecondButton);
            SecondButton.Background = Brushes.Black;
        }
    }
}
