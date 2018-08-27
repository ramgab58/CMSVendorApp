using System;
using System.Collections.ObjectModel;
namespace TestApplication
{
    public class MainViewModel
    {
        public ObservableCollection<Order> Orders { get; set; }
        public MainViewModel()
        {
            Orders = new ObservableCollection<Order>
            {
                new Order
                {
                    ShipperName = "Gab Pascual",
                    City = "Cuyahoga Falls",
                    State = "OH",
                    Zip = 44221,
                    Address1 = "1300 Bailey Rd"
                },
                new Order
                {
                    ShipperName = "Derrick Rose",
                    City = "Stow",
                    State = "OH",
                    Zip = 44224,
                    Address1 = "3290 Kent Rd"
                },
                new Order
                {
                    ShipperName = "Kobe Bryant",
                    City = "Hudson",
                    State = "OH",
                    Zip = 44236,
                    Address1 = "1234 Street"
                }
            };
        }
    }


}
