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

			// Asignar valores ( los obtiene del usuario de la base de datos )
			string nombre = "Vicente";
			string apellidos = "Marin Suazo";
			string fechaNacimiento = "19/03/2004";

			insertarValores(nombre, apellidos, fechaNacimiento);
			agregarIdiomas();
		}

        private void agregarIdiomas()
        {
			var lista = new List<string>()
			{
				"Español", "Ingles"
			};
			foreach (var item in lista)
			{
				LanguagePicker.Items.Add(item);
			}

        }

        private void insertarValores(string nombre, string apellidos, string fechaNac)
		{
			nombreLabel.Text = "Nombre: " + nombre;
			apellidosLabel.Text = "Apellidos: " + apellidos;
			fechaNacLabel.Text = "Fecha nacimiento: " + fechaNac;
		}
		
        private async void OnInfoButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoScreen());
        }
        private async void OnProblemButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProblemScreen());
        }
    }
}