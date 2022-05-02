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
        public SpaceObjectPage(SpaceObject so)
        {
            InitializeComponent();
            WriteStats(so);
        }

        public virtual void WriteStats(SpaceObject so)
        {
            ObjectName.Text = so.Name;
            ObjectMass.Text = $"Mass: {so.Mass.ToString()} kg";
            ObjectSpeed.Text = $"Relative speed: {so.RelativeSpeed.ToString()} km/s";
            ObjectGravForce.Text = $"Gravitational force: {so.GravitationalFroce.ToString()} m/s^2";
            ObjectType.Text = $"Category: {so.ObjectType.ToString()}";
        }
    }
}