using Demo01.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Demo01.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}