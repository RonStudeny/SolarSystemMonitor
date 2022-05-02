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

            res.Add(new SpaceObject("Mercury", "3.285 x 10^24", 47.85, 3.7, SpaceObject.ObjectTypes.Planet));
            res.Add(new SpaceObject("Venus", "4.867 x 10^24", 35.02, 8.87, SpaceObject.ObjectTypes.Planet));
            res.Add(new SpaceObject("Earth", "5.972 x 10^24", 30, 9.81, SpaceObject.ObjectTypes.Planet));
            res.Add(new SpaceObject("Mars", "6.39 x 10^23", 24.07, 3.72, SpaceObject.ObjectTypes.Planet));
            res.Add(new SpaceObject("Jupiter", "1.898 x 10^27", 13.06, 24.79, SpaceObject.ObjectTypes.Planet));
            res.Add(new SpaceObject("Saturn", "5.683 x 10^26", 9.68, 10.44, SpaceObject.ObjectTypes.Planet));
            res.Add(new SpaceObject("Uranus", "8.681 x 10^25", 6.81, 8.87, SpaceObject.ObjectTypes.Planet));
            res.Add(new SpaceObject("Neptune", "1.024 x 10^26", 5.43, 11.15, SpaceObject.ObjectTypes.Planet));

            return res;
        }

        private async void PlanetTapped(object sender, ItemTappedEventArgs e)
        {
            SpaceObjectPage page = new SpaceObjectPage(PlanetListView.SelectedItem as SpaceObject);
            await Navigation.PushAsync(page);
        }
    }
}