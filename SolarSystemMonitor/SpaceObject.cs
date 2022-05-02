using System;
using System.Collections.Generic;
using System.Text;

namespace SolarSystemMonitor
{
    public class SpaceObject
    {
        public SpaceObject(string name, string mass, double relativeSpeed, double gravitationalForce, ObjectTypes objectType)
        {
            Name = name;
            Mass = mass;
            RelativeSpeed = relativeSpeed;
            GravitationalFroce = gravitationalForce;
            ObjectType = objectType;
        }

        public string Name { get; set; }
        public string Mass { get; set; }
        public double RelativeSpeed { get; set; }
        public double GravitationalFroce { get; set; }
        public ObjectTypes ObjectType { get; set; }

        public enum ObjectTypes { Star, Planet, Moon, Asteroid, Satellite }
    }
}
