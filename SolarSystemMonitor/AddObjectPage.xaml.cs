﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SolarSystemMonitor
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddObjectPage : ContentPage
    {
        List<string> picks = new List<string>();

        public AddObjectPage()
        {
            InitializeComponent();

            picks.Add("Star");
            picks.Add("Planet");
            picks.Add("Moon");
            picks.Add("Asteroid");
            picks.Add("Satellite");

            TypePicker.ItemsSource = picks;
        }

        private async void AddButton_Clicked(object sender, EventArgs e) // 
        {
            OtherAstroObjectsPage.SpaceObjectsList.Add(new SpaceObject(NameEntry.Text, MassEntry.Text, Convert.ToDouble(SpeedEntry.Text), 1, (SpaceObject.ObjectTypes)TypePicker.SelectedIndex));
            await Navigation.PopAsync();
        }
    }
}