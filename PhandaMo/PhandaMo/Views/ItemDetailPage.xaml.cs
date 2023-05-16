using System.ComponentModel;
using Xamarin.Forms;
using PhandaMo.ViewModels;

namespace PhandaMo.Views
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