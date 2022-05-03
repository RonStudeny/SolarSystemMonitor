using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SolarSystemMonitor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OtherAstroObjectsPage : ContentPage
    {
        public static ObservableCollection<SpaceObject> SpaceObjectsList { get; set; }
        public OtherAstroObjectsPage()
        {
            InitializeComponent();
            SpaceObjectsList = new ObservableCollection<SpaceObject>();
            SpaceObjectsList.Add(new SpaceObject("Moon", "7.347 x 10^22", 1.02, 1.62, SpaceObject.ObjectTypes.Moon));
            ObjectListView.ItemsSource = SpaceObjectsList;
        }

        private async void AddObject_Clicked(object sender, EventArgs e) // add a new space object with custom params
        {
            AddObjectPage addObject = new AddObjectPage();
            await Navigation.PushAsync(addObject);
        }

        private async void ObjectTapped(object sender, ItemTappedEventArgs e) // view tappet object
        {
            SpaceObjectPage page = new SpaceObjectPage(ObjectListView.SelectedItem as SpaceObject);
            await Navigation.PushAsync(page);
        }

    }
}