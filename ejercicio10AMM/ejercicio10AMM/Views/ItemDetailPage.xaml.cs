using ejercicio10AMM.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ejercicio10AMM.Views
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