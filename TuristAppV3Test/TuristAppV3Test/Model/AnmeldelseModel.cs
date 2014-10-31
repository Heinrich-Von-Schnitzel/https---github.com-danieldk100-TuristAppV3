using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TuristAppV3Test.Annotations;

namespace TuristAppV3Test.Model
{
    public class AnmeldelseModel
    {
        private string _overskrift;
        private string _forfatter;
        private string _tekst;

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

        public AnmeldelseModel(string overskrift, string forfatter, string tekst)
        {
            _overskrift = overskrift;
            _forfatter = forfatter;
            _tekst = tekst;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}", _overskrift, _forfatter, _tekst);
        }
    }
}
