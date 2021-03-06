﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using zumomusicstore.Models;
using zumomusicstore.ViewModels;

namespace zumomusicstore.Views
{
    public partial class StoreView : ContentPage
    {
        public StoreView(StoreViewModel viewModel)
        {
            this.BindingContext = viewModel;

            InitializeComponent();
        }

        public void OnItemTapped(object sender, ItemTappedEventArgs args)
        {
            ((StoreViewModel)this.BindingContext).NavigateToAlbum(Navigation, args.Item as Album);
        }
    }
}
