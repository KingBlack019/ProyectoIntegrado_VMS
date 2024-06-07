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
	public partial class ProblemScreen : ContentPage
	{
		public ProblemScreen()
		{
			InitializeComponent ();
		}

		private async void OnSendReportClicked(object sender, EventArgs e)
		{
			// hacer el proceso con la base de datos de que el reporte se ha guardado en la base de datos y existe
			await DisplayAlert("Aviso", "Se ha enviado el reporte correctamente", "Ok");

			await Navigation.PushAsync( new SettingScreen() );
		}

    }
}