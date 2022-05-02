using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SolarSystemMonitor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlanetPage : ContentPage
    {
        public static List<SpaceObject> Planets;
        public PlanetPage()
        {
            InitializeComponent();

            Planets = GetPlanets();
            PlanetListView.ItemsSource = Planets;
        }

        private List<SpaceObject> GetPlanets()
        {
            List<SpaceObject> res = new List<SpaceObject>();

            res.Add(new SpaceObject("Mercury", 1, 10, 5, SpaceObject.ObjectTypes.Planet));
            res.Add(new SpaceObject("Venus", 1, 10, 5, SpaceObject.ObjectTypes.Planet));
            res.Add(new SpaceObject("Earth", 1, 10, 5, SpaceObject.ObjectTypes.Planet));
            res.Add(new SpaceObject("Mars", 1, 10, 5, SpaceObject.ObjectTypes.Planet));
            res.Add(new SpaceObject("Jupiter", 1, 10, 5, SpaceObject.ObjectTypes.Planet));
            res.Add(new SpaceObject("Saturn", 1, 10, 5, SpaceObject.ObjectTypes.Planet));
            res.Add(new SpaceObject("Uranus", 1, 10, 5, SpaceObject.ObjectTypes.Planet));
            res.Add(new SpaceObject("Neptune", 1, 10, 5, SpaceObject.ObjectTypes.Planet));

            return res;
        }

        private async void PlanetTapped(object sender, ItemTappedEventArgs e)
        {
            SpaceObjectPage page = new SpaceObjectPage(PlanetListView.SelectedItem as SpaceObject);
            await Navigation.PushAsync(page);
        }
    }
}