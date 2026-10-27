using MauiAppNet11.Models;
using MauiAppNet11.PageModels;

namespace MauiAppNet11.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}