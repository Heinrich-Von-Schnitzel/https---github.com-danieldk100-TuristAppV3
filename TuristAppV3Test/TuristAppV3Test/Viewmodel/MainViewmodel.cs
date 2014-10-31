using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TuristAppV3Test.Annotations;
using TuristAppV3Test.Model;

namespace TuristAppV3Test.Viewmodel
{
    public class MainViewmodel : INotifyPropertyChanged
    {
        private RestaurantModel _selectedRestaurant;

        public ObservableCollection<KategoriModel> Kategorier { get; set; }
        public ObservableCollection<RestaurantModel> Restauranter { get; set; }
        private string beskrivelse = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ex ante, vestibulum tempus convallis vel, gravida vel arcu. Phasellus eget nunc placerat urna mollis pulvinar.";

        public MainViewmodel()
        {
            Kategorier = new ObservableCollection<KategoriModel>();
            Kategorier.Add(new KategoriModel("Fastfood"));
            Kategorier.Add(new KategoriModel("Familierestauranter"));
            Kategorier.Add(new KategoriModel("Fine restauranter"));

            Restauranter = new ObservableCollection<RestaurantModel>();
            Restauranter.Add(new RestaurantModel("McDonalds", "../Assets/restaurant1.jpg", beskrivelse, "14-16", "Roskildevej 97", "88888888"));
            Restauranter.Add(new RestaurantModel("Burger King", "../Assets/restaurant2.jpg", beskrivelse, "14-15", "Roskildevej 17", "88888888"));
            Restauranter.Add(new RestaurantModel("Sunset Boulevard", "../Assets/restaurant1.jpg", beskrivelse, "10-16", "Roskildevej 101", "88888888"));

            Restauranter.Add(new RestaurantModel("Jensens Bøfhus", "../Assets/restaurant2.jpg", beskrivelse, "9-18", "Skinkevej 1", "44444444"));
            Restauranter.Add(new RestaurantModel("Restaurant Bryggegården", "../Assets/restaurant1.jpg", beskrivelse, "9-10", "Skinkevej 480", "44444444"));
            Restauranter.Add(new RestaurantModel("Restaurant Bone's", "../Assets/restaurant2.jpg", beskrivelse, "17-18", "Skinkevej 222", "44444444"));

            Restauranter.Add(new RestaurantModel("Prindsen", "../Assets/restaurant2.jpg", beskrivelse, "9-18", "Københavnsvej 114", "22222222"));
            Restauranter.Add(new RestaurantModel("Vigen", "../Assets/restaurant1.jpg", beskrivelse, "6-24", "Københavnsvej 666", "22222222"));
            Restauranter.Add(new RestaurantModel("Upstairs", "../Assets/restaurant1.jpg", beskrivelse, "23-24", "Københavnsvej 0", "22222222"));
        }

        public RestaurantModel SelectedRestaurantModel
        {
            get { return _selectedRestaurant; }
            set
            {
                _selectedRestaurant = value;
                OnPropertyChanged("SelectedRestaurantModel");
            }
        }

        public static KategoriModel SelectedKategori { get; set; }

        #region

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

    }
}
