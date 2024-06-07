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
	public partial class SettingScreen : ContentPage
	{
		// Al acceder aquí deberia de tener un objeto de tipo persona que guarde sus datos 
		public SettingScreen()
		{
			InitializeComponent();

			// Asignar valores
			string nombre = "Vicente";
			string apellidos = "Marin Suazo";
			string fechaNacimiento = "19/03/2004";

			insertarValores(nombre, apellidos, fechaNacimiento);

		}

        private async void InfoButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoScreen());
        }

        private void insertarValores(string nombre, string apellidos, string fechaNac)
		{
			nombreLabel.Text = "Nombre: " + nombre;
			apellidosLabel.Text = "Apellidos: " + apellidos;
			fechaNacLabel.Text = "Fecha nacimiento: " + fechaNac;
		}
	}
}