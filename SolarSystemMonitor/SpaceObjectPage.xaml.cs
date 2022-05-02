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
    public partial class SpaceObjectPage : ContentPage
    {
        public SpaceObjectPage(SpaceObject spaceObject)
        {
            InitializeComponent();
            ObjectName.Text = spaceObject.Name;
        }
    }
}