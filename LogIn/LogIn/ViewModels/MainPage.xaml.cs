using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace LogIn
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            if (userEntry.Text == "Admin" && passwordEntry.Text == "123")
            {
                await DisplayAlert("Saludos!", "Bienvenido: Admin", "Ok");
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                await DisplayAlert("Alerta", "No pueden existir campos vacíos", "Ok");
            }

        }
        private async void OnButtonClicked2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }


    }

}
