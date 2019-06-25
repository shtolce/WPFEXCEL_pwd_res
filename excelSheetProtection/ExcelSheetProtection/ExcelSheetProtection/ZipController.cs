using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression; //работа с ZIP
using System.IO;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExcelSheetProtection
{
    class ZipController:INotifyPropertyChanged
    {
        //
        private string _InitialFolderPath;
        private string _ZipLocationPath;
        private string _ExtractPath;
        public string InitialFolderPath
        {
            get {return this._InitialFolderPath; }
            set {
                this._InitialFolderPath = value;
                OnPropertyChanged("InitialFolderPath");
                }
        }
        public string ZipLocationPath
        {
            get { return this._ZipLocationPath;}
            set {
                this._ZipLocationPath = value;
                OnPropertyChanged("ZipLocationPath");
                }
        }
        public string ExtractPath
        {
            get { return this._ExtractPath; }
            set {
                this._ExtractPath = value;
                OnPropertyChanged("ExtractPath");
                }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop="")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public bool OpenZipArchive()
        {
            return true;
        }
        public bool ExtractZipArchive()
        {
            return true;
        }

    }
}
