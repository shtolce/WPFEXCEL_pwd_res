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
    class LoggerModelController:INotifyPropertyChanged
    {
        private string _LogFilePath;
        private string _LastOperationResult;
        public string LastOperationResult
        {
            get { return this._LastOperationResult; }
            set
            {
                this._LastOperationResult = value;
                OnPropertyChanged("LastOperationResult");
            }
        }
        public string LogFilePath
        {
            get {return this._LogFilePath; }
            set {
                this._LogFilePath = value;
                OnPropertyChanged("LogFilePath");
                }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop="")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public void WriteLog(string sMessage)
        {
        }
        public void OpenLog(string sLogFile)
        {
        }
        public void CloseLog()
        {
        }
    }
}
