using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhones
{
    internal class MobilePhone:INotifyPropertyChanged
    {
        public string PhoneName { get; set; }
        public string Image { get; set; }
        public string Manufacturer { get; set; }
        public float Price { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
