using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DnDMasterTool.Annotations;

namespace DnDMasterTool
{
    public class INPC : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(params string[] propertys)
        {
            if (PropertyChanged != null)
                foreach (var property in propertys)
                    PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
