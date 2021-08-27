using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxStation.Data
{
    class Users: INotifyPropertyChanged
    {
        //유저 연락처/ 가입시 비밀번호/ 연결된 비콘
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Users(string userPh, string userPw, string condBc)
        {
            UserPhone = userPh;
            UserPW = userPw;
            ConnectedBeacon = condBc;

        }

        private string userPhone;
        public string UserPhone
        {
            get
            {
                return userPhone;
                ;
            }
            set
            {
                userPhone = value;
                OnPropertyChanged("UserPhone");
            }
        }
        
        private string userPW;
        public string UserPW
        {
            get
            {
                return userPW;
                ;
            }
            set
            {
                userPW = value;
                OnPropertyChanged("UserPW");
            }
        }

        private string connectedBeacon;
        public string ConnectedBeacon
        {
            get
            {
                return connectedBeacon;
                ;
            }
            set
            {
                connectedBeacon = value;
                OnPropertyChanged("ConnectedBeacon");
            }
        }
    
    }
}
