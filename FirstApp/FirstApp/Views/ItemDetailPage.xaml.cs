using FirstApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace FirstApp.Views
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