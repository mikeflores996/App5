using App5.NewFolder3;
using HelloWorld;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static PrivBus.Clases.Usuario;

namespace PrivBus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        public HomePage()
        {
            InitializeComponent();
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }
        protected override async void OnAppearing()
        {
            var users = await _connection.Table<User>().ToListAsync();
            usersListView.ItemsSource = users;
            base.OnAppearing();
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PushModalAsync(new Login());
            return true;
        }
    }
}