using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EveryDay.Model;
using EveryDay.View;
using Xamarin.Forms;

namespace EveryDay
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            ListNote.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ModelClass modelClass = (ModelClass)e.SelectedItem;
            AddNotePage addNotePage = new AddNotePage();
            addNotePage.BindingContext = modelClass;
            await Navigation.PushAsync(addNotePage);
        }

        private async void plus_Clicked(Object sender, EventArgs e)
        {
            ModelClass modelClass = new ModelClass();
            AddNotePage addNotePage = new AddNotePage();
            addNotePage.BindingContext = modelClass;
            await Navigation.PushAsync(addNotePage);
        }
    }
}
