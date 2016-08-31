using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Drawing;

namespace App2
{
    class Planet : Entity
    {

        private int intSize;

        public Planet(Point pnt):base(pnt)
        {
            intSize = 5;
        }

        public Planet(Point pnt, int size) : base(pnt)
        {
            intSize = size;
        }


    }
}