using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxStation.Data.models
{
    class Locker : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public Locker(string json)
        {
            JObject jObject = JObject.Parse(json);
            Idx = json["idx"];
            Type = json['type'];
            Number = json['number'];
            StationName = json['stationName'];
            StationUUID = json['stationUUID'];
            StationLocation = json['stationLocation'];
        }

        private int idx;
        public int Idx
        {
            get
            {
                return idx;
            }
            set
            {
                idx = value;
                OnPropertyChanged("Idx");
            }
        }

        private string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }

        private string number;
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
                OnPropertyChanged("Number");
            }
        }

        private string stationName;
        public string StationName
        {
            get
            {
                return stationName;
            }
            set
            {
                stationName = value;
                OnPropertyChanged("StationName");
            }
        }

        private string stationUUID;
        public string StationUUID
        {
            get
            {
                return stationUUID;
            }
            set
            {
                stationUUID = value;
                OnPropertyChanged("StationUUID");
            }
        }

        private string stationLocation;
        public string StationLocation
        {
            get
            {
                return stationLocation;
            }
            set
            {
                stationLocation = value;
                OnPropertyChanged("StationLocation");
            }
        }

    }
    
}
