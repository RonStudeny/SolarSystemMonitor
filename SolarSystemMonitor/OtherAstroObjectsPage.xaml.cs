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
    public partial class OtherAstroObjectsPage : ContentPage
    {
        public static List<SpaceObject> objects = new List<SpaceObject>();
        public OtherAstroObjectsPage()
        {
            InitializeComponent();
            AddObjectPage.NewObjectEvent += Refresh;
            ObjectListView.ItemsSource = objects;
        }

        private async void AddObject_Clicked(object sender, EventArgs e)
        {
            AddObjectPage addObject = new AddObjectPage();
            await Navigation.PushAsync(addObject);
        }

        private void ObjectTapped(object sender, ItemTappedEventArgs e) // view 
        {

        }
        private void Refresh() => ObjectListView.ItemsSource = objects;

    }
}