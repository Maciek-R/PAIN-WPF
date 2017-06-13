using System.Windows;

namespace Pojazdy.View
{
    public partial class VehicleView : Window
    {
        public VehicleView()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
