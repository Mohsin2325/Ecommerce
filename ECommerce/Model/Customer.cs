﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace ECommerce.Model
{
    [DataContract (Name ="Customer"),Serializable]
    public class Customer:INotifyPropertyChanged
    {
        private string _name;
        private int _id;
        private bool _isChecked;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                    new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
        
        public bool IsChecked
        {
            get
            {
                return _isChecked;
            }
            set
            {
                _isChecked = value;
                OnPropertyChanged("IsChecked");
            }
        }
        
        [Display(Name="First Name")]
        [DataMember(Name ="firstname")]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        [DataMember(Name = "lastname")]
        public string LastName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("LastName");
            }
        }
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }

    }
}
