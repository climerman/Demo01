using Demo01.ViewModels;
using Demo01.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Demo01
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
