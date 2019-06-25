using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExcelSheetProtection
{
    class XmlParserController:INotifyPropertyChanged
    {
        private string _XmlFullPath;
        public string XmlFullPath
        {
            get {return this._XmlFullPath; }
            set {
                this._XmlFullPath = value;
                OnPropertyChanged("XmlFullPath");
                }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop="")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public bool ParseXmlFile()
        {
            return true;
        }
        public bool OpenXmlFile()
        {
            return true;
        }
        public bool FixXmlPassword()
        {
            return true;
        }

    }
}
