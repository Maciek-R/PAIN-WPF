using System;
using System.Collections.ObjectModel;
using System.Windows;
using Pojazdy.Model;
using Pojazdy.ViewModel;

namespace Pojazdy.View
{
    public partial class VehicleListView : Window
    {
        public VehicleListView()
        {
            InitializeComponent();

            var vehicles = new ObservableCollection<VehicleModel>
            {
                new VehicleModel("Opel", "Vectra", new DateTime(2005,11,11), "QWE123"),
                new VehicleModel("Audi", "A3", new DateTime(2004,07,28), "NOLM796"),
                new VehicleModel("Skoda", "Felicia", new DateTime(2015,04,25), "WA123"),
                new VehicleModel("Fiat", "Seicento", new DateTime(2007,02,16), "CS728"),
        
            };

            DataContext = new VehicleListViewModel(vehicles);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        private void buttonShow_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
