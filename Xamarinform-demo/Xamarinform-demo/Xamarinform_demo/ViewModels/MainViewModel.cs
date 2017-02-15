﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using Xamarin.Forms;

namespace Xamarinform_demo.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        private string _maintext;
        private string _hoten;
        public Command CommandTest { get; set; }

        public string HoTen
        {
            get { return _hoten; }
            set
            {
                if (_hoten != value)
                {
                    _hoten = value;
                    Thaydoi();
                    OnPropertyChanged();
                }
            }
        }

        public string MainText
        {
            get { return _maintext; }
            set
            {
                if (_maintext != value)
                {
                    _maintext = value;

                    OnPropertyChanged();
                }
            }
        }

        public void Thaydoi()
        {
            MainText = HoTen;
            
        }

        private void LoadTest()
        {
            throw new NotImplementedException();
        }

        public MainViewModel()
        {
            MainText = "Hello VNPT Long An";
            CommandTest = new Command(LoadTest);
        }
    }
}
