using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TuristAppV3Test.Annotations;

namespace TuristAppV3Test.Model
{
    public class RestaurantModel : INotifyPropertyChanged
    {
        private string _restaurant;
        private string _billede;
        private string _beskrivelse;
        private string _aabningstider;
        private string _adresse;
        private string _telefon;

        public RestaurantModel(string restaurant, string billede, string beskrivelse, string aabningstider, string adresse, string telefon)
        {
            _restaurant = restaurant;
            _billede = billede;
            _beskrivelse = beskrivelse;
            _aabningstider = aabningstider;
            _adresse = adresse;
            _telefon = telefon;
        }

        public string Restaurant
        {
            get { return _restaurant; }
            set { _restaurant = value; }
        }

        public string Billede
        {
            get { return _billede; }
            set { _billede = value; }
        }

        public string Beskrivelse
        {
            get { return _beskrivelse; }
            set { _beskrivelse = value; }
        }

        public string Aabningstider
        {
            get { return _aabningstider; }
            set { _aabningstider = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        //public static RestaurantModel SelectedKate { get; set; }

        public override string ToString()
        {
            return _restaurant;
        }

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
