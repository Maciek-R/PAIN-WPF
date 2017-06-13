using System;
using System.Windows.Input;
using Pojazdy.Model;

namespace Pojazdy.ViewModel
{
    class VehicleViewModel : ObservableObject
    {
        private VehicleModel vehicle;
        public VehicleModel Vehicle
        {
            get { return vehicle; }
            set
            {
                vehicle = value;
                OnPropertyChanged("Vehicle");
            }
        }

        private string brand;
        public string Brand
        {
            get { return brand; }
            set
            {
                if (value != brand)
                {
                    brand = value;
                    OnPropertyChanged("Brand");
                }
            }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set
            {
                if (value != model)
                {
                    model = value;
                    OnPropertyChanged("Model");
                }
            }
        }

        private DateTime productionDate;
        public DateTime ProductionDate
        {
            get { return productionDate; }
            set
            {
                if (value != productionDate)
                {
                    productionDate = value;
                    OnPropertyChanged("ProductionDate");
                }
            }
        }

        private string identyficator;
        public string Identyficator
        {
            get { return identyficator; }
            set
            {
                if (value != identyficator)
                {
                    identyficator = value;
                    OnPropertyChanged("Identyficator");
                }
            }
        }

        private ICommand saveVehicleCommand;
        public ICommand SaveVehicleCommand
        {
            get
            {
                if (saveVehicleCommand == null)
                {
                    saveVehicleCommand = new RelayCommand(
                        param => saveVehicle()
                    );
                }
                return saveVehicleCommand;
            }
        }

        private ICommand closeVehicleCommand;
        public ICommand CloseVehicleCommand
        {
            get
            {
                if (closeVehicleCommand == null)
                {
                    closeVehicleCommand = new RelayCommand(
                        param => saveVehicle()
                    );
                }
                return closeVehicleCommand;
            }
        }

        public VehicleViewModel(VehicleModel vehicle)
        {
            Vehicle = vehicle;
            Brand = Vehicle.Brand;
            Model = vehicle.Model;
            ProductionDate = vehicle.ProductionDate;
            Identyficator = vehicle.Identyficator;
        }

        private void saveVehicle()
        {
            Vehicle.Brand = Brand;
            Vehicle.Model = Model;
            Vehicle.ProductionDate = ProductionDate;
            Vehicle.Identyficator = Identyficator;
        }
    }
}
