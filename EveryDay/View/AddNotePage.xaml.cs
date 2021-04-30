using System;
using System.Collections.Generic;
using EveryDay.Model;
using Xamarin.Forms;
using EveryDay;

namespace EveryDay.View
{
    public partial class AddNotePage : ContentPage
    {
        public AddNotePage()
        {
            InitializeComponent();
        }

        private void SaveNote(object sender, EventArgs e)
        {
            var modelClass = (ModelClass)BindingContext;
            if (!String.IsNullOrEmpty(modelClass.Text))
            {
                App.Database.SaveItem(modelClass);
            }
            this.Navigation.PopAsync();
        }
        private void DeleteNote(object sender, EventArgs e)
        {
            var modelClass = (ModelClass)BindingContext;
            App.Database.DeleteItem(modelClass.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}
