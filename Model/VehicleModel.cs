using System;

namespace Pojazdy.Model
{
    class VehicleModel : ObservableObject
    {
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
                    OnPropertyChanged("ProductionYear");
                }
            }
        }

        public int ProductionYear
        {
            get
            {
                return ProductionDate.Year;
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

        public VehicleModel()
        {
            Brand = "Marka";
            Model = "Model";

            ProductionDate = DateTime.Today;
            Identyficator = "ABC 111";
        }

        public VehicleModel(string brandName = "Marka", string modelName = "Model", DateTime productionDate = new DateTime(), string identyficator = "")
        {
            Brand = brandName;
            Model = modelName;
       
                ProductionDate = productionDate;
            Identyficator = identyficator;
        }
    }
}
