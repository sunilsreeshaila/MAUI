﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemo.Models
{
    //public class Person
    //{
    //    public string Name { get; set; }
    //    public string Phone { get; set; }
    //    public string Address { get; set; }
    //}

    public class Person : INotifyPropertyChanged
    {
        private string name;
        private string phone;
        private string address;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public string Phone
        {
            get => phone; set
            {
                phone = value;
                OnPropertyChanged();
            }
        }
        public string Address
        {
            get => address; set
            {
                address = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}
