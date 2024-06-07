using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoIntegrado_VMS.Screens
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginScreen : ContentPage
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private async void LoginButtonClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

           
            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                DisplayAlert("Error", "Error en el usuario o contraseña.", "OK");
                return;
            }

            if(username == "a" && password == "a")
            {
                //DisplayAlert("Exito", "El usuario se ha conectado correctamente", "OK");
                await Navigation.PushAsync( new MainScreen() );
                
            }
        }

        private async void ForgotPasswordClicked(object sender, EventArgs e)
        {
            bool respuesta = await DisplayAlert("Cambiar contraseña", "¿Estas seguro que quieres cambiar tu contraseña?", "Si", "No");
            
            if (respuesta)
            {
                await Navigation.PushAsync(new ForgotPasswordScreen());
            }
        }
    }
}