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
    public class KategoriModel : INotifyPropertyChanged
    {
        private string _kategori;

        public KategoriModel(string kategori)
        {
            _kategori = kategori;
        }

        public string Kategori
        {
            get { return _kategori; }
            set { _kategori = value; }
        }

        public override string ToString()
        {
            return  _kategori;
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
