using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TuristAppV3Test.Annotations;
using TuristAppV3Test.Model;

namespace TuristAppV3Test.Viewmodel
{
    public class AnmeldelseRestaurantViewmodel : INotifyPropertyChanged
    {
        private ObservableCollection<AnmeldelseModel> _anmeldelser;
        private AnmeldelseModel _SelectedAnmeldelse;

        private OpretAnmeldelseModelHandler _opretAnmeldelseModelHandler;
        private RelayCommand _opretAnmeldelseCommand;

        public ObservableCollection<AnmeldelseModel> Anmeldelser
        {
            get { return _anmeldelser; }
            set { _anmeldelser = value; }
        }

        public AnmeldelseModel SelectedAnmeldelseModel
        {
            get { return _SelectedAnmeldelse; }
            set
            {
                _SelectedAnmeldelse = value;
                OnPropertyChanged("SelectedAnmeldelseModel");
            }
        }

        public OpretAnmeldelseModelHandler OpretAnmeldelseModelHandler
        {
            get { return _opretAnmeldelseModelHandler; }
            set { _opretAnmeldelseModelHandler = value; }
        }

        public RelayCommand OpretAnmeldelseCommand
        {
            get { return _opretAnmeldelseCommand; }
            set { _opretAnmeldelseCommand = value; }
        }

        public AnmeldelseRestaurantViewmodel()
        {
            _anmeldelser = new ObservableCollection<AnmeldelseModel>();
            _anmeldelser.Add(new AnmeldelseModel("Feee' restaurant", "Daniel Winther Jensen", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed egestas ipsum in lorem varius, eget rhoncus ex ultrices. Praesent dui magna, pulvinar sed felis quis, lacinia varius mauris. Mauris a convallis orci."));

            _opretAnmeldelseModelHandler = new OpretAnmeldelseModelHandler(_anmeldelser);
            _opretAnmeldelseCommand = new RelayCommand(_opretAnmeldelseModelHandler.OpretAnmeldelse);

        }

        #region Notify
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
