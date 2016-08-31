using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App2
{
    static class UniverseManager
    {
        static List<Entity> EntityList= new List<Entity>();

        public static void BuildPlanet(Point pnt, int size)
        {
            Planet Temp = new Planet(pnt, size);
            EntityList.Add(Temp);
        }

    }
}