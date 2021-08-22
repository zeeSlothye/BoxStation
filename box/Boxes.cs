using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tizen.Applications;

namespace BoxStation
{
    public class Boxes: INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Boxes(string stn, string bxn, string iso, string umb, string mask)
        {
            StationName = stn;
            BoxNumber = bxn;
            IsOpen = iso;
            Umbrella = umb;
            Mask = mask;
        }

        private string stationName;
        public string StationName
        {
            get
            {
                return "버스 정류장: "+stationName;
            }
            set
            {
                stationName = value;
                OnPropertyChanged("StationName");
            }
        }

        private string boxNumber;
        public string BoxNumber
        {
            get
            {
                return boxNumber;
            }
            set
            {
                boxNumber = value;
                OnPropertyChanged("BoxNumber");
            }
        }

        private string isOpen;
        public string IsOpen
        {
            get
            {
                return Application.Current.DirectoryInfo.Resource+"/images/isOpen/"+isOpen;
            }
            set
            {
                isOpen = value;
                OnPropertyChanged("IsOpen");
            }
        }

        private string umbrella;
        public string Umbrella
        {
            get
            {
                return "남은 우산 수: "+umbrella;
            }
            set
            {
                umbrella = value;
                OnPropertyChanged("Umbrella");
            }
        }

        private string mask;
        public string Mask
        {
            get
            {
                return "남은 마스크 수: " + mask;
            }
            set
            {
                mask = value;
                OnPropertyChanged("Mask");
            }
        }
    }

}

