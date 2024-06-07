using ProyectoIntegrado_VMS.Content;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoIntegrado_VMS.Screens
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainScreen : ContentPage
    {
        public ObservableCollection<Item> elementos { get; set; }
        // NO SE DEBE RETROCEDER UNA VEZ ENTRADO A ESTA CLASE
        public MainScreen()
        {
            InitializeComponent();

            RoleLabel.Text = "User Role = ";

            elementos = new ObservableCollection<Item>
            {
                new Item { Titulo = "ACTIVIDAD 1", Horario = "8.30-11.30", Descripcion = "Viaje a las catedrales de Sevilla", personasActual = 3, personasMaximo = 10},
                new Item { Titulo = "ACTIVIDAD 2", Horario = "20.00-22.00", Descripcion = "Boda en el centro de Sevilla", personasActual = 15, personasMaximo = 30 }
            };

            collectionView.ItemsSource = elementos;
        }

        private async void OnHomeButtonClicked(object sender, EventArgs e)
        {

        }

        private async void OnPage1ButtonClicked(object sender, EventArgs e)
        {

        }



        private async void SettingsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingScreen());
        }

        private async void EnterActivityClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            var item = button.BindingContext as Item;
            if (item != null)
            {
                await Navigation.PushAsync(new ActivityScreen(item.Titulo, item.Horario, item.Descripcion, item.personasActual, item.personasMaximo));
            }
        }
    }
}