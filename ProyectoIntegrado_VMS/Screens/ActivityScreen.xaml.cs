using ProyectoIntegrado_VMS.Content;
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
	public partial class ActivityScreen : ContentPage
	{
		CodeManagement management = new CodeManagement();
		public ActivityScreen (string titulo, string horario, string descripcion, int personasActual, int personasMaximo)
		{

            InitializeComponent();

			reemplazarElementos(titulo, horario, descripcion, personasActual, personasMaximo);
            
		}

        private void reemplazarElementos(string titulo, string horario, string descripcion, int personasActual, int personasMaximo)
        {
            activityLabel.Text = titulo;
            hourLabel.Text = horario;
            descLabel.Text = descripcion;
            peopleLabel.Text = personasActual + "/" + personasMaximo;
        }

        // Metodo que hace acceder al usuario a la actividad seleccionada
        private async void EnterActivityClicked(object sender, EventArgs e)
        {
			// no tiene ningun sentido
			management.personasActualmente(0,0);

            // se inscribirá al evento
        }
    }
}