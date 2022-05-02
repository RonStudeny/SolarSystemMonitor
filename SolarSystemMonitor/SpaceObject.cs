using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystemMonitor
{
    public class SpaceObject
    {
        public SpaceObject(string name, double mass, double relativeSpeed, double gravitationalFroce, ObjectTypes objectType)
        {
            Name = name;
            Mass = mass;
            RelativeSpeed = relativeSpeed;
            GravitationalFroce = gravitationalFroce;
            ObjectType = objectType;
        }

        public string Name { get; set; }
        public double Mass { get; set; }
        public double RelativeSpeed { get; set; }
        public double GravitationalFroce { get; set; }
        public ObjectTypes ObjectType { get; set; }

        public enum ObjectTypes { Star, Planet, Moon, Asteroid, Satellite }
    }
}
