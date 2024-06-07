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
	public partial class ForgotPasswordScreen : ContentPage
	{
		public ForgotPasswordScreen ()
		{
			InitializeComponent();
		}

        private async void AceptButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginScreen());
        }
    }
}