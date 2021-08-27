using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxStation.Data.models
{
    class OccupiedLocker : INotifyPropertyChanged
    
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public OccupiedLocker(string json)
        {
            Idx = json['idx'];
            LockerIdx = json['lockerIdx'];
            password = json['password'];
            Title = json['title'];
            Info = json['info'];
            IsOpen = json['isOpen'];
            Date = json['date'];
            TrustId = json['trustId'];
            IsPaid = json['isPaid'];
        }
        private string idx;
        public string Idx
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

        private string lockerIdx;
        public string LockerIdx
        {
            get
            {
                return lockerIdx;
            }
            set
            {
                lockerIdx = value;
                OnPropertyChanged("LockerIdx");
            }
        }
        
        private string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        private string title;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        
        private string info;
        public string Info
        {
            get
            {
                return info;
            }
            set
            {
                info = value;
                OnPropertyChanged("Info");
            }
        }

        private string isOpen;
        public string IsOpen
        {
            get
            {
                return isOpen;
            }
            set
            {
                isOpen = value;
                OnPropertyChanged("IsOpen");
            }
        }
        
        private string date;
        public string Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                OnPropertyChanged("Date");
            }
        }

        private string trustId;
        public string TrustId
        {
            get
            {
                return trustId;
            }
            set
            {
                trustId = value;
                OnPropertyChanged("TrustId");
            }
        }
        
        private string isPaid;
        public string IsPaid
        {
            get
            {
                return isPaid;
            }
            set
            {
                isPaid = value;
                OnPropertyChanged("IsPaid");
            }
        }
    }
}
