﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QkPay.Models;
using Xamarin.Forms;

namespace QkPay.Pages
{
    public partial class MainPage : ContentPage
    {

        User _user;

        public MainPage(User user)
        {
            InitializeComponent();

            _user = user;

            BindingContext = this;
        }

        public string Avatar
        {
            get { return _user.Avatar; }
        }
    }
}
