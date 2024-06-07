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
	public partial class UsersScreen : ContentPage
	{
		// Aqui se mostrara una lista de usuarios que estarán inscritas al evento/actividad
		public UsersScreen()
		{
			InitializeComponent ();
		}
	}
}