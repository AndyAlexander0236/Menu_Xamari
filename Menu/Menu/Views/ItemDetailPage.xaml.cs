using Menu.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Menu.Views
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