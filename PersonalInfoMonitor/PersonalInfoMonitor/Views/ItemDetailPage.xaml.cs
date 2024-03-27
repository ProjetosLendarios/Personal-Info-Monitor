using PersonalInfoMonitor.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PersonalInfoMonitor.Views
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