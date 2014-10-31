using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristAppV3Test.Model;

namespace TuristAppV3Test.Viewmodel
{
    public class OpretAnmeldelseModelHandler
    {
        private string _overskrift;
        private string _forfatter;
        private string _tekst;

        private ObservableCollection<AnmeldelseModel> _anmeldelse;


        public string Overskrift
        {
            get { return _overskrift; }
            set { _overskrift = value; }
        }

        public string Forfatter
        {
            get { return _forfatter; }
            set { _forfatter = value; }
        }

        public string Tekst
        {
            get { return _tekst; }
            set { _tekst = value; }
        }

        public OpretAnmeldelseModelHandler(ObservableCollection<AnmeldelseModel> anmeldelse)
        {
            _anmeldelse = anmeldelse;
        }

        public void OpretAnmeldelse()
        {
            AnmeldelseModel p = new AnmeldelseModel(_overskrift, _forfatter, _tekst);
            _anmeldelse.Add(p);

        }
    }
}
